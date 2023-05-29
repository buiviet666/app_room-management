namespace QL_Nha_Tro_Demo
{
    partial class TraPhongPage
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
            this.searchboxkhtraphong = new System.Windows.Forms.TextBox();
            this.dataGridViewtrapkh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewtrap = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntrap = new System.Windows.Forms.Button();
            this.trapten = new System.Windows.Forms.TextBox();
            this.trapsdt = new System.Windows.Forms.TextBox();
            this.trapemail = new System.Windows.Forms.TextBox();
            this.trapaddress = new System.Windows.Forms.TextBox();
            this.trapgender = new System.Windows.Forms.TextBox();
            this.trapdate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.cleartrap = new System.Windows.Forms.Button();
            this.trapcode = new System.Windows.Forms.TextBox();
            this.trapmaphong = new System.Windows.Forms.TextBox();
            this.trangthaitraphong = new System.Windows.Forms.TextBox();
            this.mathuephong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrapkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Trả Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập tên khách hàng";
            // 
            // searchboxkhtraphong
            // 
            this.searchboxkhtraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboxkhtraphong.Location = new System.Drawing.Point(92, 86);
            this.searchboxkhtraphong.Name = "searchboxkhtraphong";
            this.searchboxkhtraphong.Size = new System.Drawing.Size(289, 27);
            this.searchboxkhtraphong.TabIndex = 4;
            // 
            // dataGridViewtrapkh
            // 
            this.dataGridViewtrapkh.AllowUserToAddRows = false;
            this.dataGridViewtrapkh.AllowUserToDeleteRows = false;
            this.dataGridViewtrapkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtrapkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dataGridViewtrapkh.Location = new System.Drawing.Point(409, 60);
            this.dataGridViewtrapkh.Name = "dataGridViewtrapkh";
            this.dataGridViewtrapkh.ReadOnly = true;
            this.dataGridViewtrapkh.RowHeadersWidth = 51;
            this.dataGridViewtrapkh.RowTemplate.Height = 24;
            this.dataGridViewtrapkh.Size = new System.Drawing.Size(439, 145);
            this.dataGridViewtrapkh.TabIndex = 5;
            this.dataGridViewtrapkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtrapkh_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKH";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soDTKH";
            this.Column4.HeaderText = "Số ĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "emailKH";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gioiTinhKH";
            this.Column6.HeaderText = "Giới Tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(166, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên KH: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số ĐT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày Đi:";
            // 
            // dataGridViewtrap
            // 
            this.dataGridViewtrap.AllowUserToAddRows = false;
            this.dataGridViewtrap.AllowUserToDeleteRows = false;
            this.dataGridViewtrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridViewtrap.Location = new System.Drawing.Point(12, 375);
            this.dataGridViewtrap.Name = "dataGridViewtrap";
            this.dataGridViewtrap.ReadOnly = true;
            this.dataGridViewtrap.RowHeadersWidth = 51;
            this.dataGridViewtrap.RowTemplate.Height = 24;
            this.dataGridViewtrap.Size = new System.Drawing.Size(695, 153);
            this.dataGridViewtrap.TabIndex = 9;
            this.dataGridViewtrap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtrap_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "maThuePhong";
            this.Column7.HeaderText = "Mã Thuê Phòng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "maKH";
            this.Column8.HeaderText = "Mã Khách Hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "maPhong";
            this.Column9.HeaderText = "Mã Phòng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ngayDen";
            this.Column10.HeaderText = "Ngày Đến";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ngayDi";
            this.Column11.HeaderText = "Ngày Đi";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // btntrap
            // 
            this.btntrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrap.Location = new System.Drawing.Point(744, 375);
            this.btntrap.Name = "btntrap";
            this.btntrap.Size = new System.Drawing.Size(90, 42);
            this.btntrap.TabIndex = 10;
            this.btntrap.Text = "Trả Phòng";
            this.btntrap.UseVisualStyleBackColor = true;
            this.btntrap.Click += new System.EventHandler(this.btntrap_Click);
            // 
            // trapten
            // 
            this.trapten.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapten.Location = new System.Drawing.Point(132, 240);
            this.trapten.Name = "trapten";
            this.trapten.Size = new System.Drawing.Size(268, 29);
            this.trapten.TabIndex = 11;
            // 
            // trapsdt
            // 
            this.trapsdt.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapsdt.Location = new System.Drawing.Point(132, 287);
            this.trapsdt.Name = "trapsdt";
            this.trapsdt.Size = new System.Drawing.Size(268, 29);
            this.trapsdt.TabIndex = 11;
            // 
            // trapemail
            // 
            this.trapemail.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapemail.Location = new System.Drawing.Point(132, 330);
            this.trapemail.Name = "trapemail";
            this.trapemail.Size = new System.Drawing.Size(268, 29);
            this.trapemail.TabIndex = 11;
            // 
            // trapaddress
            // 
            this.trapaddress.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapaddress.Location = new System.Drawing.Point(512, 287);
            this.trapaddress.Name = "trapaddress";
            this.trapaddress.Size = new System.Drawing.Size(322, 29);
            this.trapaddress.TabIndex = 11;
            // 
            // trapgender
            // 
            this.trapgender.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapgender.Location = new System.Drawing.Point(512, 240);
            this.trapgender.Name = "trapgender";
            this.trapgender.Size = new System.Drawing.Size(322, 29);
            this.trapgender.TabIndex = 11;
            // 
            // trapdate
            // 
            this.trapdate.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapdate.Location = new System.Drawing.Point(512, 329);
            this.trapdate.Name = "trapdate";
            this.trapdate.Size = new System.Drawing.Size(322, 29);
            this.trapdate.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(744, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cleartrap
            // 
            this.cleartrap.Location = new System.Drawing.Point(744, 423);
            this.cleartrap.Name = "cleartrap";
            this.cleartrap.Size = new System.Drawing.Size(90, 42);
            this.cleartrap.TabIndex = 14;
            this.cleartrap.Text = "Xóa trắng";
            this.cleartrap.UseVisualStyleBackColor = true;
            this.cleartrap.Click += new System.EventHandler(this.cleartrap_Click);
            // 
            // trapcode
            // 
            this.trapcode.Location = new System.Drawing.Point(383, 212);
            this.trapcode.Name = "trapcode";
            this.trapcode.Size = new System.Drawing.Size(17, 22);
            this.trapcode.TabIndex = 15;
            this.trapcode.Visible = false;
            // 
            // trapmaphong
            // 
            this.trapmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapmaphong.Location = new System.Drawing.Point(713, 403);
            this.trapmaphong.Name = "trapmaphong";
            this.trapmaphong.Size = new System.Drawing.Size(24, 27);
            this.trapmaphong.TabIndex = 16;
            this.trapmaphong.Visible = false;
            // 
            // trangthaitraphong
            // 
            this.trangthaitraphong.Location = new System.Drawing.Point(713, 436);
            this.trangthaitraphong.Name = "trangthaitraphong";
            this.trangthaitraphong.Size = new System.Drawing.Size(24, 22);
            this.trangthaitraphong.TabIndex = 18;
            this.trangthaitraphong.Text = "Đã Trả";
            this.trangthaitraphong.Visible = false;
            // 
            // mathuephong
            // 
            this.mathuephong.Location = new System.Drawing.Point(713, 375);
            this.mathuephong.Name = "mathuephong";
            this.mathuephong.Size = new System.Drawing.Size(24, 22);
            this.mathuephong.TabIndex = 19;
            this.mathuephong.Visible = false;
            // 
            // TraPhongPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.mathuephong);
            this.Controls.Add(this.trangthaitraphong);
            this.Controls.Add(this.trapmaphong);
            this.Controls.Add(this.trapcode);
            this.Controls.Add(this.cleartrap);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.trapdate);
            this.Controls.Add(this.trapgender);
            this.Controls.Add(this.trapaddress);
            this.Controls.Add(this.trapemail);
            this.Controls.Add(this.trapsdt);
            this.Controls.Add(this.trapten);
            this.Controls.Add(this.btntrap);
            this.Controls.Add(this.dataGridViewtrap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewtrapkh);
            this.Controls.Add(this.searchboxkhtraphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TraPhongPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraPhongPage";
            this.Load += new System.EventHandler(this.TraPhongPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrapkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchboxkhtraphong;
        private System.Windows.Forms.DataGridView dataGridViewtrapkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewtrap;
        private System.Windows.Forms.Button btntrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox trapten;
        private System.Windows.Forms.TextBox trapsdt;
        private System.Windows.Forms.TextBox trapemail;
        private System.Windows.Forms.TextBox trapaddress;
        private System.Windows.Forms.TextBox trapgender;
        private System.Windows.Forms.DateTimePicker trapdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cleartrap;
        private System.Windows.Forms.TextBox trapcode;
        private System.Windows.Forms.TextBox trapmaphong;
        private System.Windows.Forms.TextBox trangthaitraphong;
        private System.Windows.Forms.TextBox mathuephong;
    }
}