using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_O_Nator.models {
    public class server {
        public string human_name  {get; set; }
        public string human_comment  {get; set; }
        public string host    {get; set; }
        public string user    {get; set; }
        public string password {get; set; }
        public string display { get {
                string o="";
                if(string.IsNullOrWhiteSpace(human_name)) return connection_string;
                if(null==human_comment) human_comment="";
                o =""+human_name+" ----  "+human_comment;

                return o;
            }

            }
        public string connection_string {
            get {
                string o="";
                o="Data Source="+host+"; User Id="+user+"; Password="+password+";";
                return o;
            }
        }
        public server() {
            human_name   ="";
            human_comment="";
            host         ="";
            user         ="";
            password     ="";

        }

    }
}
