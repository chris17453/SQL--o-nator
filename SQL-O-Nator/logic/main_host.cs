using SQL_O_Nator.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_O_Nator {
    public partial class main {
        public void f_delete_host() {
            host_config.server=null;

            if(null!=sources.SelectedItem) g.connections.Remove((server)sources.SelectedItem);
        }
        public void f_show_host() {
            source_split.Panel2Collapsed=false;
        }
        public void f_hide_host() {
            source_split.Panel2Collapsed=true;
        }
        public void f_toggle_host() {
            int len=sources.Items.Count;
            for(int i=0;i<len;i++) {
                bool value=false;
                if(sources.GetItemCheckState(i)==CheckState.Checked) value=false; else value=true;
                sources.SetItemChecked(i,value);

            }
        }
    }
}
