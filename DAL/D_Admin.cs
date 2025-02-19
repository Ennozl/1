using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class D_Admin
    {
        public bool Login(Admin m_admin)
        {
            string query = "SELECT COUNT(1) FROM Admin WHERE admin_name=@admin_name AND pwd = @pwd";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@admin_name",  m_admin.admin_name),
                new SqlParameter("@pwd", m_admin.pwd)
            };
            DataTable resultTable = SqlDbHelper.ExecuteDataTable(query, CommandType.Text, parameters);
            if (resultTable.Rows.Count > 0 && Convert.ToInt32(resultTable.Rows[0][0]) == 1)
            {
                return true; 
            }
            return false; 
        }
    }
}
