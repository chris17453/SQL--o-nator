using SQL_O_Nator.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_O_Nator {
    public partial class main {
         public void f_open_group() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  
            openFileDialog1.Filter = "Sql Group Files|*.sqlcon.txt";  
            openFileDialog1.Title = "Select a Group File";  

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {  
                f_load_group(openFileDialog1.FileName);
            }  
        }
        public void f_load_group(string filename) {
            g=group.Load(filename);
            ((ListBox)sources).DataSource   =g.connections;
            ((ListBox)sources).DisplayMember="display";
            ((ListBox)sources).ValueMember  ="connection_string";
            f_update_settings();
        }
        public void f_new_group() {
            g=new group();
            ((ListBox)sources).DataSource   =g.connections;
            ((ListBox)sources).DisplayMember="display";
            ((ListBox)sources).ValueMember  ="connection_string";
            host_config.server=null;
        }

        public void f_close_group() {
            g=new group();
            ((ListBox)sources).DataSource   =g.connections;
            ((ListBox)sources).DisplayMember="display";
            ((ListBox)sources).ValueMember  ="connection_string";
            host_config.server=null;
        }
        public void f_save_group_as() {
            SaveFileDialog savefile = new SaveFileDialog(); 
            savefile.FileName = "unknown.sqlcon.txt";
            savefile.Filter = "Sql Group Files|*.sqlcon.txt";  
            
            if (savefile.ShowDialog() == DialogResult.OK){
                g.filename=savefile.FileName;
                g.Save();
                f_update_settings();
            }
        }
        public void f_save_group() {
            if(null==g.filename) f_save_group_as();
            else                 g.Save();
            f_update_settings();
        }
        public void f_add_host() {
            server s=new server();
            g.connections.Add(s);
            sources.SelectedItem=s;
            host_config.server=(server)sources.SelectedItem;                //first add issues... get over it.
            source_split.Panel2Collapsed=false;
        }
    }
}
