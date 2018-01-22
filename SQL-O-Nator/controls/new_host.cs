using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_O_Nator.models;

namespace SQL_O_Nator.controls {
    public partial class new_host : UserControl {
        public new_host() {
            InitializeComponent();
        }
        public server _server { get; set; }

        [System.ComponentModel.Bindable(true)] 
        public server server { get { return _server; }
                                set {
                                        if( value==null) {
                                            host.Text="";
                                            name.Text="";
                                            desc.Text="";
                                            user.Text="";
                                            pass.Text="";
                                        } else {
                                            if(!String.IsNullOrWhiteSpace(value.host))           host.Text=value.host;           else host.Text="";
                                            if(!String.IsNullOrWhiteSpace(value.human_name))     name.Text=value.human_name;     else name.Text="";
                                            if(!String.IsNullOrWhiteSpace(value.human_comment))  desc.Text=value.human_comment;  else desc.Text="";
                                            if(!String.IsNullOrWhiteSpace(value.user))           user.Text=value.user;           else user.Text="";
                                            if(!String.IsNullOrWhiteSpace(value.password))       pass.Text=value.password;       else pass.Text="";
                                        }
                                        _server=value;
                    
                                } }
        
        public event EventHandler Save;
        public event EventHandler Cancel;

        private void groupBox1_Enter(Object sender, EventArgs e) {

        }

        private void save_Click(Object sender, EventArgs e) {
            server.host         =host.Text;
            server.human_name   =name.Text;
            server.human_comment=desc.Text;
            server.user         =user.Text;
            server.password     =pass.Text;
            if (this.Save!= null)
            this.Save(this, e); 
        }

        private void cancel_Click(Object sender, EventArgs e) {
            if(this.Cancel!=null)this.Cancel(this,e);
        }
    }
}
