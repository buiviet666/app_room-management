namespace QL_Nha_Tro_Demo
{
    partial class DashBoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoad));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNVPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKHPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLPhongPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLDVPage = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CNThuePhongPage = new System.Windows.Forms.ToolStripMenuItem();
            this.CNTraPhongPage = new System.Windows.Forms.ToolStripMenuItem();
            this.CNSuDungDVPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TKKhachHangPage = new System.Windows.Forms.ToolStripMenuItem();
            this.TKPhongPage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(952, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heeToolStripMenuItem,
            this.quảnLýDữLiệuToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heeToolStripMenuItem
            // 
            this.heeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.heeToolStripMenuItem.Name = "heeToolStripMenuItem";
            this.heeToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.heeToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDữLiệuToolStripMenuItem
            // 
            this.quảnLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNVPage,
            this.QLKHPage,
            this.QLPhongPage,
            this.QLDVPage});
            this.quảnLýDữLiệuToolStripMenuItem.Name = "quảnLýDữLiệuToolStripMenuItem";
            this.quảnLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.quảnLýDữLiệuToolStripMenuItem.Text = "Quản Lý Dữ Liệu";
            // 
            // QLNVPage
            // 
            this.QLNVPage.Name = "QLNVPage";
            this.QLNVPage.Size = new System.Drawing.Size(260, 26);
            this.QLNVPage.Text = "Quản Lý Nhân Viên";
            this.QLNVPage.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // QLKHPage
            // 
            this.QLKHPage.Name = "QLKHPage";
            this.QLKHPage.Size = new System.Drawing.Size(260, 26);
            this.QLKHPage.Text = "Quản Lý Khách Hàng";
            this.QLKHPage.Click += new System.EventHandler(this.QLKHPage_Click);
            // 
            // QLPhongPage
            // 
            this.QLPhongPage.Name = "QLPhongPage";
            this.QLPhongPage.Size = new System.Drawing.Size(260, 26);
            this.QLPhongPage.Text = "Quản Lý Thông Tin Phòng";
            this.QLPhongPage.Click += new System.EventHandler(this.QLPhongPage_Click);
            // 
            // QLDVPage
            // 
            this.QLDVPage.Name = "QLDVPage";
            this.QLDVPage.Size = new System.Drawing.Size(260, 26);
            this.QLDVPage.Text = "Quản Lý Dịch Vụ";
            this.QLDVPage.Click += new System.EventHandler(this.QLDVPage_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CNThuePhongPage,
            this.CNTraPhongPage,
            this.CNSuDungDVPage});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // CNThuePhongPage
            // 
            this.CNThuePhongPage.Name = "CNThuePhongPage";
            this.CNThuePhongPage.Size = new System.Drawing.Size(204, 26);
            this.CNThuePhongPage.Text = "Thuê Phòng";
            this.CNThuePhongPage.Click += new System.EventHandler(this.CNThuePhongPage_Click);
            // 
            // CNTraPhongPage
            // 
            this.CNTraPhongPage.Name = "CNTraPhongPage";
            this.CNTraPhongPage.Size = new System.Drawing.Size(204, 26);
            this.CNTraPhongPage.Text = "Trả Phòng";
            this.CNTraPhongPage.Click += new System.EventHandler(this.CNTraPhongPage_Click);
            // 
            // CNSuDungDVPage
            // 
            this.CNSuDungDVPage.Name = "CNSuDungDVPage";
            this.CNSuDungDVPage.Size = new System.Drawing.Size(204, 26);
            this.CNSuDungDVPage.Text = "Sử Dụng Dịch Vụ";
            this.CNSuDungDVPage.Click += new System.EventHandler(this.CNSuDungDVPage_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TKKhachHangPage,
            this.TKPhongPage});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // TKKhachHangPage
            // 
            this.TKKhachHangPage.Name = "TKKhachHangPage";
            this.TKKhachHangPage.Size = new System.Drawing.Size(239, 26);
            this.TKKhachHangPage.Text = "Tìm Kiếm Khách Hàng";
            this.TKKhachHangPage.Click += new System.EventHandler(this.TKKhachHangPage_Click);
            // 
            // TKPhongPage
            // 
            this.TKPhongPage.Name = "TKPhongPage";
            this.TKPhongPage.Size = new System.Drawing.Size(239, 26);
            this.TKPhongPage.Text = "Tìm Kiếm Phòng";
            this.TKPhongPage.Click += new System.EventHandler(this.TKPhongPage_Click);
            // 
            // DashBoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoad";
            this.Load += new System.EventHandler(this.DashBoad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNVPage;
        private System.Windows.Forms.ToolStripMenuItem QLPhongPage;
        private System.Windows.Forms.ToolStripMenuItem QLKHPage;
        private System.Windows.Forms.ToolStripMenuItem QLDVPage;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CNThuePhongPage;
        private System.Windows.Forms.ToolStripMenuItem CNTraPhongPage;
        private System.Windows.Forms.ToolStripMenuItem CNSuDungDVPage;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TKKhachHangPage;
        private System.Windows.Forms.ToolStripMenuItem TKPhongPage;
    }
}