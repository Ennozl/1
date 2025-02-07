using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    
    public partial class Admin
    {
        public Admin()
        {

        }
        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public string pwd { get; set; }
    }
}

