namespace UI
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("超级管理员");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("医护人员");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("权限管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("医生");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("护士");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("用户数据", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("手术调度");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("流程控制");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("数据分析");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("密码管理");
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BackColor = System.Drawing.Color.DodgerBlue;
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.ExpandSelectFirst = false;
            this.uiNavMenu1.FillColor = System.Drawing.Color.White;
            this.uiNavMenu1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ForeColor = System.Drawing.Color.Black;
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.HotTracking = true;
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(3, 3);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode1.Name = "节点6";
            treeNode1.Tag = "cjgly";
            treeNode1.Text = "超级管理员";
            treeNode2.Name = "节点7";
            treeNode2.Tag = "yhry";
            treeNode2.Text = "医护人员";
            treeNode3.Name = "节点4";
            treeNode3.Text = "权限管理";
            treeNode4.Name = "节点1";
            treeNode4.Tag = "ys";
            treeNode4.Text = "医生";
            treeNode5.Name = "节点2";
            treeNode5.Tag = "hs";
            treeNode5.Text = "护士";
            treeNode6.Name = "节点0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            treeNode6.Text = "用户数据";
            treeNode7.Name = "节点9";
            treeNode7.Tag = "ssdd";
            treeNode7.Text = "手术调度";
            treeNode8.Name = "节点10";
            treeNode8.Tag = "lckz";
            treeNode8.Text = "流程控制";
            treeNode9.Name = "节点12";
            treeNode9.Text = "数据分析";
            treeNode10.Name = "节点11";
            treeNode10.Tag = "mmgl";
            treeNode10.Text = "密码管理";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.ShowPlusMinus = false;
            this.uiNavMenu1.ShowRootLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(191, 618);
            this.uiNavMenu1.TabIndex = 2;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(200, 3);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.ShowActiveCloseButton = true;
            this.uiTabControl1.Size = new System.Drawing.Size(792, 618);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 4;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel1.Controls.Add(this.uiNavMenu1, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTabControl1, 1, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(994, 624);
            this.uiTableLayoutPanel1.TabIndex = 5;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 659);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "main";
            this.Text = "主界面";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.main_Load);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UINavMenu uiNavMenu1;
        private Sunny.UI.UITabControl uiTabControl1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
    }
}