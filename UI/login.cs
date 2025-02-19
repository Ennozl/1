using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace UI
{
    public partial class login : UIForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Model.Admin m_admin = new Model.Admin();
            m_admin.admin_name = uiTextBox1.Text;
            m_admin.pwd = uiTextBox2.Text;

            BLL.B_Admin b_Admin = new BLL.B_Admin();
            if (b_Admin.Login(m_admin) == 0)
            {

                this.DialogResult = DialogResult.OK;
                main main = new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
                uiTextBox1.Text = string.Empty;
                uiTextBox2.Text = string.Empty;
            }
        }
    }
}
