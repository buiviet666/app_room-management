namespace QL_Nha_Tro_Demo
{
    partial class KhachHangPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khname = new System.Windows.Forms.TextBox();
            this.khgender = new System.Windows.Forms.ComboBox();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addkh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.khphone = new System.Windows.Forms.TextBox();
            this.khemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.khaddress = new System.Windows.Forms.TextBox();
            this.khcode = new System.Windows.Forms.TextBox();
            this.fixkh = new System.Windows.Forms.Button();
            this.dellkh = new System.Windows.Forms.Button();
            this.fixconfirmkh = new System.Windows.Forms.Button();
            this.clearkh = new System.Windows.Forms.Button();
            this.addconfirmkh = new System.Windows.Forms.Button();
            this.cancelkh = new System.Windows.Forms.Button();
            this.exitkh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng: ";
            // 
            // khname
            // 
            this.khname.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khname.Location = new System.Drawing.Point(203, 113);
            this.khname.Name = "khname";
            this.khname.Size = new System.Drawing.Size(228, 24);
            this.khname.TabIndex = 1;
            // 
            // khgender
            // 
            this.khgender.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khgender.FormattingEnabled = true;
            this.khgender.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.khgender.Location = new System.Drawing.Point(553, 113);
            this.khgender.Name = "khgender";
            this.khgender.Size = new System.Drawing.Size(228, 27);
            this.khgender.TabIndex = 2;
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.AllowUserToAddRows = false;
            this.dataGridViewKH.AllowUserToDeleteRows = false;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewKH.Location = new System.Drawing.Point(29, 286);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.ReadOnly = true;
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(802, 242);
            this.dataGridViewKH.TabIndex = 3;
            this.dataGridViewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKH";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKH";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soDTKH";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "emailKH";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gioiTinhKH";
            this.Column5.HeaderText = "Giới Tính";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "diaChi";
            this.Column6.HeaderText = "Địa Chỉ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // addkh
            // 
            this.addkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addkh.Location = new System.Drawing.Point(90, 211);
            this.addkh.Name = "addkh";
            this.addkh.Size = new System.Drawing.Size(82, 52);
            this.addkh.TabIndex = 4;
            this.addkh.Text = "Thêm";
            this.addkh.UseVisualStyleBackColor = true;
            this.addkh.Click += new System.EventHandler(this.addkh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // khphone
            // 
            this.khphone.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khphone.Location = new System.Drawing.Point(203, 145);
            this.khphone.Name = "khphone";
            this.khphone.Size = new System.Drawing.Size(228, 24);
            this.khphone.TabIndex = 1;
            // 
            // khemail
            // 
            this.khemail.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khemail.Location = new System.Drawing.Point(203, 181);
            this.khemail.Name = "khemail";
            this.khemail.Size = new System.Drawing.Size(228, 24);
            this.khemail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ: ";
            // 
            // khaddress
            // 
            this.khaddress.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khaddress.Location = new System.Drawing.Point(553, 145);
            this.khaddress.Name = "khaddress";
            this.khaddress.Size = new System.Drawing.Size(228, 24);
            this.khaddress.TabIndex = 1;
            // 
            // khcode
            // 
            this.khcode.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khcode.Location = new System.Drawing.Point(756, 181);
            this.khcode.Name = "khcode";
            this.khcode.Size = new System.Drawing.Size(25, 24);
            this.khcode.TabIndex = 1;
            this.khcode.Visible = false;
            // 
            // fixkh
            // 
            this.fixkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixkh.Location = new System.Drawing.Point(178, 211);
            this.fixkh.Name = "fixkh";
            this.fixkh.Size = new System.Drawing.Size(82, 52);
            this.fixkh.TabIndex = 4;
            this.fixkh.Text = "Sửa";
            this.fixkh.UseVisualStyleBackColor = true;
            this.fixkh.Click += new System.EventHandler(this.fixkh_Click);
            // 
            // dellkh
            // 
            this.dellkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dellkh.Location = new System.Drawing.Point(266, 211);
            this.dellkh.Name = "dellkh";
            this.dellkh.Size = new System.Drawing.Size(82, 52);
            this.dellkh.TabIndex = 4;
            this.dellkh.Text = "Xóa";
            this.dellkh.UseVisualStyleBackColor = true;
            this.dellkh.Click += new System.EventHandler(this.dellkh_Click);
            // 
            // fixconfirmkh
            // 
            this.fixconfirmkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixconfirmkh.Location = new System.Drawing.Point(442, 211);
            this.fixconfirmkh.Name = "fixconfirmkh";
            this.fixconfirmkh.Size = new System.Drawing.Size(82, 52);
            this.fixconfirmkh.TabIndex = 4;
            this.fixconfirmkh.Text = "Xác Nhận";
            this.fixconfirmkh.UseVisualStyleBackColor = true;
            this.fixconfirmkh.Click += new System.EventHandler(this.fixconfirmkh_Click);
            // 
            // clearkh
            // 
            this.clearkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearkh.Location = new System.Drawing.Point(354, 211);
            this.clearkh.Name = "clearkh";
            this.clearkh.Size = new System.Drawing.Size(82, 52);
            this.clearkh.TabIndex = 4;
            this.clearkh.Text = "Xóa Trắng";
            this.clearkh.UseVisualStyleBackColor = true;
            this.clearkh.Click += new System.EventHandler(this.clearkh_Click);
            // 
            // addconfirmkh
            // 
            this.addconfirmkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addconfirmkh.Location = new System.Drawing.Point(530, 211);
            this.addconfirmkh.Name = "addconfirmkh";
            this.addconfirmkh.Size = new System.Drawing.Size(82, 52);
            this.addconfirmkh.TabIndex = 4;
            this.addconfirmkh.Text = "Ghi";
            this.addconfirmkh.UseVisualStyleBackColor = true;
            this.addconfirmkh.Click += new System.EventHandler(this.addconfirmkh_Click);
            // 
            // cancelkh
            // 
            this.cancelkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelkh.Location = new System.Drawing.Point(618, 211);
            this.cancelkh.Name = "cancelkh";
            this.cancelkh.Size = new System.Drawing.Size(82, 52);
            this.cancelkh.TabIndex = 4;
            this.cancelkh.Text = "Hủy Bỏ";
            this.cancelkh.UseVisualStyleBackColor = true;
            this.cancelkh.Click += new System.EventHandler(this.cancelkh_Click);
            // 
            // exitkh
            // 
            this.exitkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitkh.Location = new System.Drawing.Point(706, 211);
            this.exitkh.Name = "exitkh";
            this.exitkh.Size = new System.Drawing.Size(82, 52);
            this.exitkh.TabIndex = 4;
            this.exitkh.Text = "Thoát";
            this.exitkh.UseVisualStyleBackColor = true;
            this.exitkh.Click += new System.EventHandler(this.button8_Click);
            // 
            // KhachHangPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitkh);
            this.Controls.Add(this.cancelkh);
            this.Controls.Add(this.addconfirmkh);
            this.Controls.Add(this.clearkh);
            this.Controls.Add(this.fixconfirmkh);
            this.Controls.Add(this.dellkh);
            this.Controls.Add(this.fixkh);
            this.Controls.Add(this.addkh);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.khgender);
            this.Controls.Add(this.khcode);
            this.Controls.Add(this.khemail);
            this.Controls.Add(this.khphone);
            this.Controls.Add(this.khaddress);
            this.Controls.Add(this.khname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHangPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHangPage";
            this.Load += new System.EventHandler(this.KhachHangPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox khname;
        private System.Windows.Forms.ComboBox khgender;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Button addkh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox khphone;
        private System.Windows.Forms.TextBox khemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox khaddress;
        private System.Windows.Forms.TextBox khcode;
        private System.Windows.Forms.Button fixkh;
        private System.Windows.Forms.Button dellkh;
        private System.Windows.Forms.Button fixconfirmkh;
        private System.Windows.Forms.Button clearkh;
        private System.Windows.Forms.Button addconfirmkh;
        private System.Windows.Forms.Button cancelkh;
        private System.Windows.Forms.Button exitkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}