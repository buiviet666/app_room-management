namespace QL_Nha_Tro_Demo
{
    partial class SDDichVuPage
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgDichVu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDVSuDung = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.sddvadd = new System.Windows.Forms.Button();
            this.sddvdell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.dgKhach = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.giadichvu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDVSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Sử Dụng Dịch Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh Sách Dịch Vụ";
            // 
            // dgDichVu
            // 
            this.dgDichVu.AllowUserToAddRows = false;
            this.dgDichVu.AllowUserToDeleteRows = false;
            this.dgDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgDichVu.Location = new System.Drawing.Point(296, 316);
            this.dgDichVu.Name = "dgDichVu";
            this.dgDichVu.ReadOnly = true;
            this.dgDichVu.RowHeadersWidth = 51;
            this.dgDichVu.RowTemplate.Height = 24;
            this.dgDichVu.Size = new System.Drawing.Size(552, 189);
            this.dgDichVu.TabIndex = 10;
            this.dgDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDichVu_CellContentClick);
            this.dgDichVu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDichVu_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDV";
            this.Column1.HeaderText = "Mã Dịch Vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenDV";
            this.Column2.HeaderText = "Tên Dịch Vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "giaDV";
            this.Column3.HeaderText = "Giá Dịch Vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DVT";
            this.Column4.HeaderText = "Đơn Vị Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh Sách Dịch Vụ Đã Sử Dụng";
            // 
            // dgDVSuDung
            // 
            this.dgDVSuDung.AllowUserToAddRows = false;
            this.dgDVSuDung.AllowUserToDeleteRows = false;
            this.dgDVSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDVSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column5,
            this.Column6,
            this.Column13,
            this.Column9,
            this.Column14,
            this.Column7,
            this.Column10});
            this.dgDVSuDung.Location = new System.Drawing.Point(296, 97);
            this.dgDVSuDung.Name = "dgDVSuDung";
            this.dgDVSuDung.ReadOnly = true;
            this.dgDVSuDung.RowHeadersWidth = 51;
            this.dgDVSuDung.RowTemplate.Height = 24;
            this.dgDVSuDung.Size = new System.Drawing.Size(552, 147);
            this.dgDVSuDung.TabIndex = 11;
            this.dgDVSuDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDVSuDung_CellContentClick);
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "IDSDDV";
            this.Column16.HeaderText = "ID";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "maThuePhong";
            this.Column5.HeaderText = "MaThuephong";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "maDV";
            this.Column6.HeaderText = "Mã DV";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "tenDV";
            this.Column13.HeaderText = "Tên dịch vụ";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "soLuong";
            this.Column9.HeaderText = "Số Lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "giaDV";
            this.Column14.HeaderText = "Giá";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "thanhTien";
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ngaySD";
            this.Column10.HeaderText = "Ngày Sử Dụng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(758, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sddvadd
            // 
            this.sddvadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sddvadd.Location = new System.Drawing.Point(566, 260);
            this.sddvadd.Name = "sddvadd";
            this.sddvadd.Size = new System.Drawing.Size(90, 40);
            this.sddvadd.TabIndex = 12;
            this.sddvadd.Text = "Thêm";
            this.sddvadd.UseVisualStyleBackColor = true;
            this.sddvadd.Click += new System.EventHandler(this.sddvadd_Click);
            // 
            // sddvdell
            // 
            this.sddvdell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sddvdell.Location = new System.Drawing.Point(662, 260);
            this.sddvdell.Name = "sddvdell";
            this.sddvdell.Size = new System.Drawing.Size(90, 40);
            this.sddvdell.TabIndex = 12;
            this.sddvdell.Text = "Xóa";
            this.sddvdell.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(29, 108);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(226, 24);
            this.cboPhong.TabIndex = 14;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // dgKhach
            // 
            this.dgKhach.AllowUserToAddRows = false;
            this.dgKhach.AllowUserToDeleteRows = false;
            this.dgKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column15});
            this.dgKhach.Location = new System.Drawing.Point(12, 153);
            this.dgKhach.Name = "dgKhach";
            this.dgKhach.ReadOnly = true;
            this.dgKhach.RowHeadersWidth = 51;
            this.dgKhach.RowTemplate.Height = 24;
            this.dgKhach.Size = new System.Drawing.Size(258, 352);
            this.dgKhach.TabIndex = 15;
            this.dgKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhach_CellContentClick);
            this.dgKhach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKhach_CellMouseClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "maKH";
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "tenKH";
            this.Column11.HeaderText = "Họ Tên";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "soDTKH";
            this.Column12.HeaderText = "SĐT";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "maThuePhong";
            this.Column15.HeaderText = "Mã thuê phòng";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "SL:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(504, 263);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(56, 22);
            this.txtSoluong.TabIndex = 17;
            this.txtSoluong.Text = "1";
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.Location = new System.Drawing.Point(292, 261);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(15, 24);
            this.lblMaDV.TabIndex = 16;
            this.lblMaDV.Text = ".";
            this.lblMaDV.Visible = false;
            // 
            // giadichvu
            // 
            this.giadichvu.Location = new System.Drawing.Point(542, 288);
            this.giadichvu.Name = "giadichvu";
            this.giadichvu.Size = new System.Drawing.Size(18, 22);
            this.giadichvu.TabIndex = 18;
            this.giadichvu.Visible = false;
            // 
            // SDDichVuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.giadichvu);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.lblMaDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgKhach);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sddvadd);
            this.Controls.Add(this.sddvdell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDVSuDung);
            this.Controls.Add(this.dgDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SDDichVuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDDichVuPage";
            this.Load += new System.EventHandler(this.SDDichVuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDVSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDVSuDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sddvadd;
        private System.Windows.Forms.Button sddvdell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DataGridView dgKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.TextBox giadichvu;
    }
}