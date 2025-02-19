using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    
    public class B_Admin
    {
        DAL.D_Admin d_admin = new DAL.D_Admin();
        public int Login(Model.Admin m_admin)
        {
            var res = d_admin.Login(m_admin);
            return res ? 0 : 1;
        }
    }
}
