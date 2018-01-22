using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_O_Nator.logic;

namespace SQL_O_Nator.models {
    public class group:json_io<group> {
        public BindingList<server> connections=new BindingList<server>();
    }
}
