using SQL_O_Nator.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_O_Nator {
    public partial class main {
        string query_name="";
        private void f_new_query() {
            query_window.Text="";
            query_name=null;
        }
        private void f_open_query() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  
            openFileDialog1.Filter = "Sql Files|*.sql";  
            openFileDialog1.Title = "Select a File";  

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {  
                f_load_query(openFileDialog1.FileName);
            }
        }
        private void f_load_query(string filename) {
            string text=System.IO.File.ReadAllText(filename);
            query_name=filename;
            query_window.Text=text;
        }

        private void f_query_save() {
            if(null==query_name) return;
            string text=query_window.Text;
            File.WriteAllText(query_name, text);
        }
        private void f_query_save_as() {
            SaveFileDialog savefile = new SaveFileDialog(); 
            savefile.FileName = "unknown.sql";
            savefile.Filter = "Sql Files|*.sql";  
            if (savefile.ShowDialog() == DialogResult.OK){
                query_name=savefile.FileName;
                f_query_save();

            }
        }
        private void f_query_close() {
            query_window.Text="";
            query_name=null;
        }



        public string[]  f_split_query(string query) {
            string[] splitter = new string[] { "\r\nGO\r\n", "\r\nGO;\r\n" };

            string[] commandTexts = query.Split(splitter,StringSplitOptions.RemoveEmptyEntries);
            return commandTexts;
        }

        private void f_query_run() {
            List<DataTable> results_table=new List<DataTable>();
            string sql_text=strip_comments(query_window.Text);
            if(string.IsNullOrWhiteSpace(sql_text)) {
                MessageBox.Show("No query to run.");
                return;
            }

            string[] querys=f_split_query(sql_text);

            
            StringBuilder results=new StringBuilder();
            int len=sources.Items.Count;
            bool has_rows=false;
            for(int i=0;i<len;i++) {
                server s=(server)sources.Items[i];
                if(sources.GetItemCheckState(i)!=CheckState.Checked) {
                    results.Append(String.Format("Skipping Host ----- {0}-{1}\r\n\r\n",s.human_name,s.connection_string));
                    continue;
                }
                results.Append(String.Format("Trying Next Host ----- {0}-{1}\r\n\r\n",s.human_name,s.connection_string));

                using (SqlConnection sqlConnection = new SqlConnection(s.connection_string)) {
                    try {
                        DateTime start=DateTime.Now;
                        int sql_position=0;    //position of query in file
                        foreach(string query in querys) {
                            SqlCommand cmd = new SqlCommand();
                            SqlDataReader reader;
                            cmd.CommandText = query;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection  = sqlConnection;
                            sqlConnection.Open();
                            if(sqlConnection.State==ConnectionState.Open) {
                                reader = cmd.ExecuteReader();
                                    results.Append(String.Format("Rows Affected {0} \r\n",reader.RecordsAffected));
                                int rows_affected=reader.RecordsAffected;
                                DateTime end=DateTime.Now;        
                                if (reader.HasRows) {
                                    has_rows=true;
                                    results.Append("Has Rows\r\n");
                                } else {
                                    results.Append("No Rows Returned\r\n");
                                }

                                DataTable dt=new DataTable();
                                DataColumn c=new DataColumn("SQL_SERVER");
                                c.DefaultValue=s.human_name;
                                dt.Columns.Add(c);
                                dt.Load(reader);
                                DateTime end_read=DateTime.Now;
                                results_table.Add(dt);
                                System.TimeSpan read_time=end_read-end;
                                System.TimeSpan exec_time=end-start;
                                System.TimeSpan total_time=end_read-start;
                                
                                results.Append(string.Format("Total Time: in seconds {0} \r\n",total_time.Seconds));
                                results.Append(string.Format("QUERY EXEC Time seconds {0} \r\n",exec_time.Seconds));
                                results.Append(string.Format("Data read_time time in seconds {0} \r\n",read_time.Seconds));
                                sql_position++;
                                if(false==f_update_server_hash(sqlConnection,sql_text,query,query_name,sql_position,rows_affected)) {
                                    results.Append(string.Format("Failed log sql_batch.\r\n"));
                                }
                            } else {
                                results.Append(string.Format("Failed to connect\r\n"));
                            }
                        }
                        sqlConnection.Close();
                    } catch (Exception ex) {
                        results.Append("Error "+ex.Message+"\r\n");
                    }
                }
            }
            
            int y=0;
            tabPage1.Controls.Clear();
            foreach(DataTable d in results_table) {
                DataGridView dg = new DataGridView();
                dg.DataSource=d;
                
                if(results_table.Count==1) {
                    dg.Dock=DockStyle.Fill;
                } else {
                    dg.Left=0;
                    dg.Top=y;
                    dg.Width=tabPage1.Width;
                    int h=tabPage1.Height/results_table.Count;
                    if(h<400) h=400;
                    dg.Height=h;
                    y+=dg.Height;
                    dg.Anchor=(AnchorStyles.Left | AnchorStyles.Right  | AnchorStyles.Top);
                    dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dg.AutoResizeColumns();
                    
                    tabPage1.AutoScrollMinSize = new System.Drawing.Size(tabPage1.Width,y);
//                    tabPage1.Resize += TabPage1_Resize;

                }
                
                tabPage1.Controls.Add(dg);
             //   sizeDGV(dg);
            }
            
            query_results.Text=results.ToString();
            if(!has_rows) {
                //tabControl1.TabPages[0].Hide();
                tabControl1.SelectedIndex=1;
            } else {
                //tabControl1.TabPages[0].Show();
                tabControl1.SelectedIndex=0;
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input){
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        string strip_comments(string sql) {
                var blockComments = @"/\*(.*?)\*/";
                var lineComments = @"--(.*?)\r?\n";
                var strings = @"""((\\[^\n]|[^""\n])*)""";
                var verbatimStrings = @"@(""[^""]*"")+";

                string noComments = Regex.Replace(sql+"\r\n",
                blockComments + "|" + lineComments + "|" + strings + "|" + verbatimStrings,
                me => {
                    if (me.Value.StartsWith("/*") || me.Value.StartsWith("--"))
                        return " ";
                    return me.Value;
                },
                RegexOptions.Singleline);
                return noComments;
            }


        private bool f_update_server_hash(SqlConnection conn,string script,string query,string filename,int position,int rows_affected) {
            string      user     =Environment.UserName;
            string      machine  =Environment.MachineName;
            string      DNS      =Dns.GetHostName();
            IPAddress   ip       = Array.FindLast(Dns.GetHostEntry(string.Empty).AddressList,a => a.AddressFamily == AddressFamily.InterNetwork);
            string      sql_hash;
            string      file_hash;
            string      stripped_query=strip_comments(query.Trim());
            string      ip_str="127.0.0.1";
            if(null!=ip) ip_str=ip.ToString(); else ip_str="127.0.0.1";
            using (MD5 md5Hash = MD5.Create())            {
                sql_hash = GetMd5Hash(md5Hash,stripped_query);
                file_hash = GetMd5Hash(md5Hash,script);
            }
            try {
                SqlParameter[] collection={ new SqlParameter("@ip",ip_str),
                                            new SqlParameter("@dns",DNS),
                                            new SqlParameter("@user",user),
                                            new SqlParameter("@machine",machine),
                                            new SqlParameter("@filename",filename),
                                            new SqlParameter("@file_hash",file_hash),
                                            new SqlParameter("@sql_hash",sql_hash),
                                            new SqlParameter("@sql_position",position),
                                            new SqlParameter("@rows_affected",rows_affected)
                                            };
                query=@"INSERT INTO db_hash ([ip],[dns],[user],[machine],[filename],[file_hash],[sql_hash],[sql_position],[rows_affected]) "+
                       "VALUES (@ip,@dns,@user,@machine,@filename,@file_hash,@sql_hash,@sql_position,@rows_affected)";

                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection  = conn;
                    cmd.Parameters.AddRange(collection);
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex ) {
                return false;
            }      
            return true;
        }
    }
}
