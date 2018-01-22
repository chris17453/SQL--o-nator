using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_O_Nator.models;
using SQL_O_Nator.logic;

namespace SQL_O_Nator {
    public partial class main : Form {
        group g;
        settings s;
        public main() {
            InitializeComponent();
            s=settings.Load();
            if(s==null) {
                s =new settings();
                s.Save();
                g=new group();
                ((ListBox)sources).DataSource   =g.connections;
                ((ListBox)sources).DisplayMember="display";
                ((ListBox)sources).ValueMember  ="connection_string";
            } else {
                f_load_group(s.last_group);
            }
            
            f_hide_host();
            //tabControl1.TabPages[0].Hide();
        }

        public void f_update_settings() {
            s.last_group=g.filename;
            s.Save();
        }




        //group
        private void new_group_Click(Object sender, EventArgs e) {
            f_new_group();
        }
        private void add_host_Click_1(Object sender, EventArgs e) {
            f_add_host();
        }
        private void add_host_1_Click(Object sender, EventArgs e) {
            f_add_host();
        }
        private void close_group_Click(Object sender, EventArgs e) {
            f_close_group();
        }
        private void save_group_Click(Object sender, EventArgs e) {
            f_save_group();
        }
        private void save_group_as_Click(Object sender, EventArgs e) {
            f_save_group_as();
        }
        
        private void open_group_1_Click(Object sender, EventArgs e) {
            f_open_group();
        }
        //edit host
        private void host_config_Load(Object sender, EventArgs e) {
        }
        private void host_config_Cancel(Object sender, EventArgs e) {
            f_hide_host();
        }
        private void host_config_Save(Object sender, EventArgs e) {
            f_hide_host();
            f_save_group();
        }
        private void sources_SelectedIndexChanged(Object sender, EventArgs e) {
            host_config.server=(server)sources.SelectedItem;
        }
        private void edit_host_Click(Object sender, EventArgs e) {
            f_show_host();
        }
        private void delete_host_Click(Object sender, EventArgs e) {
            f_delete_host();
        }

        //Query

        private void new_query_Click(Object sender, EventArgs e) {
            f_new_query();
        }

        private void open_query_Click(Object sender, EventArgs e) {
            f_open_query();
        }
        private void open_query_2_Click(Object sender, EventArgs e) {
            f_open_query();
        }

        private void save_query_Click(Object sender, EventArgs e) {
            f_query_save();
        }

        private void save_query_as_Click(Object sender, EventArgs e) {
            f_query_save_as();
        }

        private void close_query_Click(Object sender, EventArgs e) {
            f_query_close();
        }

        private void run_query_1_Click(Object sender, EventArgs e) {
            f_query_run();
        }

        private void test_sources_Click(Object sender, EventArgs e) {
            //f_test_sources();
        }

        private void run_query_Click(Object sender, EventArgs e) {
            f_query_run();
        }

        private void sQLQuerysToolStripMenuItem_Click(Object sender, EventArgs e) {

        }

        private void Toggle_Click(Object sender, EventArgs e) {
           f_toggle_host();
        }

        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e) {
            SQL_O_Nator.controls.about_sqlonator a = new controls.about_sqlonator();
            a.Show();
        }
    }
}
