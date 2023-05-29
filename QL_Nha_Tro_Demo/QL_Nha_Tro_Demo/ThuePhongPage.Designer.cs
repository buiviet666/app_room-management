namespace QL_Nha_Tro_Demo
{
    partial class ThuePhongPage
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
            this.txtpTP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkTP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcomeTP = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txttinhtrangTP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thuê Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin phòng đang trống: ";
            // 
            // txtpTP
            // 
            this.txtpTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpTP.FormattingEnabled = true;
            this.txtpTP.Location = new System.Drawing.Point(282, 75);
            this.txtpTP.Name = "txtpTP";
            this.txtpTP.Size = new System.Drawing.Size(391, 33);
            this.txtpTP.TabIndex = 3;
            this.txtpTP.SelectedIndexChanged += new System.EventHandler(this.txtpTP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin Khách Hàng: ";
            // 
            // txtkTP
            // 
            this.txtkTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtkTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkTP.FormattingEnabled = true;
            this.txtkTP.Location = new System.Drawing.Point(282, 131);
            this.txtkTP.Name = "txtkTP";
            this.txtkTP.Size = new System.Drawing.Size(391, 33);
            this.txtkTP.TabIndex = 3;
            this.txtkTP.SelectedIndexChanged += new System.EventHandler(this.txtkTP_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày đến: ";
            // 
            // txtcomeTP
            // 
            this.txtcomeTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomeTP.CustomFormat = "dd/MM/YYYY";
            this.txtcomeTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomeTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcomeTP.Location = new System.Drawing.Point(282, 182);
            this.txtcomeTP.Name = "txtcomeTP";
            this.txtcomeTP.Size = new System.Drawing.Size(391, 30);
            this.txtcomeTP.TabIndex = 4;
            // 
            // dataGridViewTP
            // 
            this.dataGridViewTP.AllowUserToAddRows = false;
            this.dataGridViewTP.AllowUserToDeleteRows = false;
            this.dataGridViewTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ngayDi});
            this.dataGridViewTP.Location = new System.Drawing.Point(37, 263);
            this.dataGridViewTP.Name = "dataGridViewTP";
            this.dataGridViewTP.ReadOnly = true;
            this.dataGridViewTP.RowHeadersWidth = 51;
            this.dataGridViewTP.RowTemplate.Height = 24;
            this.dataGridViewTP.Size = new System.Drawing.Size(795, 250);
            this.dataGridViewTP.TabIndex = 6;
            this.dataGridViewTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTP_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maThuePhong";
            this.Column1.HeaderText = "Mã Thuê Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maKH";
            this.Column2.HeaderText = "Mã Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "maPhong";
            this.Column3.HeaderText = "Mã Phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayDen";
            this.Column4.HeaderText = "Ngày Đến";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // ngayDi
            // 
            this.ngayDi.HeaderText = "Ngày Đi";
            this.ngayDi.MinimumWidth = 6;
            this.ngayDi.Name = "ngayDi";
            this.ngayDi.ReadOnly = true;
            this.ngayDi.Width = 125;
            // 
            // addTP
            // 
            this.addTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTP.Location = new System.Drawing.Point(679, 181);
            this.addTP.Name = "addTP";
            this.addTP.Size = new System.Drawing.Size(144, 30);
            this.addTP.TabIndex = 7;
            this.addTP.Text = "Thêm Thuê Phòng";
            this.addTP.UseVisualStyleBackColor = true;
            this.addTP.Click += new System.EventHandler(this.addTP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Danh Sách Thuê Phòng";
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Location = new System.Drawing.Point(679, 227);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(144, 30);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Thoát";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(697, 89);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(13, 19);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = ".";
            this.lblMaPhong.Visible = false;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(697, 145);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(13, 19);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = ".";
            this.lblMaKH.Visible = false;
            // 
            // txttinhtrangTP
            // 
            this.txttinhtrangTP.Location = new System.Drawing.Point(566, 218);
            this.txttinhtrangTP.Name = "txttinhtrangTP";
            this.txttinhtrangTP.Size = new System.Drawing.Size(107, 22);
            this.txttinhtrangTP.TabIndex = 9;
            this.txttinhtrangTP.Text = "Đang Hoạt Động";
            this.txttinhtrangTP.Visible = false;
            // 
            // ThuePhongPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.txttinhtrangTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.addTP);
            this.Controls.Add(this.dataGridViewTP);
            this.Controls.Add(this.txtcomeTP);
            this.Controls.Add(this.txtkTP);
            this.Controls.Add(this.txtpTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThuePhongPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThuePhongPage";
            this.Load += new System.EventHandler(this.ThuePhongPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtpTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtkTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtcomeTP;
        private System.Windows.Forms.DataGridView dataGridViewTP;
        private System.Windows.Forms.Button addTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDi;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txttinhtrangTP;
    }
}