using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Admin m_admin = new Model.Admin();
            m_admin.admin_name = textBox1.Text;
            m_admin.pwd = textBox2.Text;

            BLL.B_Admin b_Admin = new BLL.B_Admin();
            if (b_Admin.Login(m_admin) == 0)
            {
                
                this.DialogResult = DialogResult.OK;
                main main=new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
