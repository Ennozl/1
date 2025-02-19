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
using UI;

namespace UI
{
    public partial class main : UIForm
    {
        private ys YS;
        private hs HS;
        private cjgly CJGLY;
        private yhry YHRY;
        private ssdd SSDD;
        private lckz LCKZ;
        private sjfx SJFX;
        private mmgl MMGL;
        public main()
        {
            InitializeComponent();


        }
        private void main_Load(object sender, EventArgs e)
        {
            YS = new ys { Text = "医生" };
            HS = new hs { Text = "护士" };
            CJGLY = new cjgly() { Text = "超级管理员" };
            YHRY = new yhry { Text = "医护人员" }; ;
            SSDD = new ssdd { Text = "手术调度" };
            LCKZ = new lckz { Text = "流程控制" };
            SJFX = new sjfx { Text = "数据分析" };
            MMGL = new mmgl { Text = "密码管理" };


        }
        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private UIPage GetPageInstance(string pageName)
        {
            switch (pageName)
            {
                case "医生":
                    if (YS == null || YS.IsDisposed)
                    {
                        YS = new ys { Text = "医生" };
                    }
                    return YS;
                case "护士":
                    if (HS == null || HS.IsDisposed)
                    {
                        HS = new hs { Text = "护士" };
                    }
                    return HS;
                case "超级管理员":
                    if (CJGLY == null || CJGLY.IsDisposed)
                    {
                        CJGLY = new cjgly { Text = "超级管理员" };
                    }
                    return CJGLY;
                case "医护人员":
                    if (YHRY == null || YHRY.IsDisposed)
                    {
                        YHRY = new yhry { Text = "医护人员" };
                    }
                    return YHRY;
                case "手术调度":
                    if (SSDD == null || SSDD.IsDisposed)
                    {
                        SSDD = new ssdd { Text = "手术调度" };
                    }
                    return SSDD;
                case "流程控制":
                    if (LCKZ == null || LCKZ.IsDisposed)
                    {
                        LCKZ = new lckz { Text = "流程控制" };
                    }
                    return LCKZ;
                case "数据分析":
                    if (SJFX == null || SJFX.IsDisposed)
                    {
                        SJFX = new sjfx { Text = "数据分析" };
                    }
                    return SJFX;
                case "密码管理":
                    if (MMGL == null || MMGL.IsDisposed)
                    {
                        MMGL = new mmgl { Text = "密码管理" };
                    }
                    return MMGL;
                default:
                    return null;
            }
        }
        private void uiNavMenu1_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            string pageName = node.Text;
            UIPage pageForm = GetPageInstance(pageName);

            if (pageForm != null)
            {
                // 检查标签页是否已经存在
                int existingIndex = GetExistingTabIndex(pageForm.Text);
                if (existingIndex != -1)
                {
                    // 如果存在，切换到该标签页
                    uiTabControl1.SelectedIndex = existingIndex;
                }
                else
                {
                    // 检查是否已经打开了 10 个标签页
                    if (uiTabControl1.TabPages.Count < 10)
                    {
                        // 如果不存在且未达到最大数量，添加新的标签页
                        uiTabControl1.AddPages(pageForm);
                        uiTabControl1.SelectedIndex = uiTabControl1.TabPages.Count - 1;
                    }
                    else
                    {
                        // 达到最大数量，给出提示
                        MessageBox.Show("最多只能打开 10 个标签页。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private int GetExistingTabIndex(string tabText)
        {
            // 遍历所有标签页，查找是否存在指定文本的标签页
            for (int i = 0; i < uiTabControl1.TabPages.Count; i++)
            {
                if (uiTabControl1.TabPages[i].Text == tabText)
                {
                    return i;
                }
            }
            return -1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uiTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}

    

