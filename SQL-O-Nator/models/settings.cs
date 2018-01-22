using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_O_Nator.logic;

namespace SQL_O_Nator.models {

    public class settings : json_io<settings> {
        public string last_group { get; set; }
    }
}
