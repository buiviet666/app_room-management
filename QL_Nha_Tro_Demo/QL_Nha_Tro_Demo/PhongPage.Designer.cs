namespace QL_Nha_Tro_Demo
{
    partial class PhongPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rprice = new System.Windows.Forms.TextBox();
            this.rcode = new System.Windows.Forms.TextBox();
            this.roption = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rstatus = new System.Windows.Forms.ComboBox();
            this.btnfixr = new System.Windows.Forms.Button();
            this.btncofirmr = new System.Windows.Forms.Button();
            this.btncancelr = new System.Windows.Forms.Button();
            this.btnexitr = new System.Windows.Forms.Button();
            this.dataGridViewroom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewroom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Phòng: ";
            // 
            // rname
            // 
            this.rname.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rname.Location = new System.Drawing.Point(213, 161);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(211, 24);
            this.rname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Phòng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá Phòng: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rprice
            // 
            this.rprice.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rprice.Location = new System.Drawing.Point(579, 124);
            this.rprice.Name = "rprice";
            this.rprice.Size = new System.Drawing.Size(211, 24);
            this.rprice.TabIndex = 8;
            // 
            // rcode
            // 
            this.rcode.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcode.Location = new System.Drawing.Point(213, 124);
            this.rcode.Name = "rcode";
            this.rcode.Size = new System.Drawing.Size(211, 24);
            this.rcode.TabIndex = 8;
            // 
            // roption
            // 
            this.roption.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roption.FormattingEnabled = true;
            this.roption.Items.AddRange(new object[] {
            "",
            "Đơn",
            "Đôi",
            "Bốn"});
            this.roption.Location = new System.Drawing.Point(213, 198);
            this.roption.Name = "roption";
            this.roption.Size = new System.Drawing.Size(211, 27);
            this.roption.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Phòng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tình Trạng: ";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // rstatus
            // 
            this.rstatus.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstatus.FormattingEnabled = true;
            this.rstatus.Items.AddRange(new object[] {
            "",
            "Trống",
            "Đang Hoạt Động",
            "Đang Sửa",
            "Đang Đặt"});
            this.rstatus.Location = new System.Drawing.Point(579, 161);
            this.rstatus.Name = "rstatus";
            this.rstatus.Size = new System.Drawing.Size(211, 27);
            this.rstatus.TabIndex = 9;
            // 
            // btnfixr
            // 
            this.btnfixr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfixr.Location = new System.Drawing.Point(140, 251);
            this.btnfixr.Name = "btnfixr";
            this.btnfixr.Size = new System.Drawing.Size(88, 44);
            this.btnfixr.TabIndex = 10;
            this.btnfixr.Text = "Sửa";
            this.btnfixr.UseVisualStyleBackColor = true;
            this.btnfixr.Click += new System.EventHandler(this.btnfixr_Click);
            // 
            // btncofirmr
            // 
            this.btncofirmr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncofirmr.Location = new System.Drawing.Point(301, 251);
            this.btncofirmr.Name = "btncofirmr";
            this.btncofirmr.Size = new System.Drawing.Size(88, 44);
            this.btncofirmr.TabIndex = 10;
            this.btncofirmr.Text = "Xác Nhận";
            this.btncofirmr.UseVisualStyleBackColor = true;
            this.btncofirmr.Click += new System.EventHandler(this.btncofirmr_Click);
            // 
            // btncancelr
            // 
            this.btncancelr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelr.Location = new System.Drawing.Point(472, 251);
            this.btncancelr.Name = "btncancelr";
            this.btncancelr.Size = new System.Drawing.Size(88, 44);
            this.btncancelr.TabIndex = 10;
            this.btncancelr.Text = "Hủy Bỏ";
            this.btncancelr.UseVisualStyleBackColor = true;
            this.btncancelr.Click += new System.EventHandler(this.btncancelr_Click);
            // 
            // btnexitr
            // 
            this.btnexitr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexitr.Location = new System.Drawing.Point(630, 251);
            this.btnexitr.Name = "btnexitr";
            this.btnexitr.Size = new System.Drawing.Size(88, 44);
            this.btnexitr.TabIndex = 10;
            this.btnexitr.Text = "Thoát";
            this.btnexitr.UseVisualStyleBackColor = true;
            this.btnexitr.Click += new System.EventHandler(this.btnexitr_Click);
            // 
            // dataGridViewroom
            // 
            this.dataGridViewroom.AllowUserToAddRows = false;
            this.dataGridViewroom.AllowUserToDeleteRows = false;
            this.dataGridViewroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewroom.Location = new System.Drawing.Point(12, 301);
            this.dataGridViewroom.Name = "dataGridViewroom";
            this.dataGridViewroom.ReadOnly = true;
            this.dataGridViewroom.RowHeadersWidth = 51;
            this.dataGridViewroom.RowTemplate.Height = 24;
            this.dataGridViewroom.Size = new System.Drawing.Size(836, 227);
            this.dataGridViewroom.TabIndex = 11;
            this.dataGridViewroom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewroom_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maPhong";
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenPhong";
            this.Column2.HeaderText = "Tên Phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "giaPhong";
            this.Column3.HeaderText = "Giá Phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "loaiPhong";
            this.Column4.HeaderText = "Loại Phòng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tinhTrang";
            this.Column5.HeaderText = "Tình Trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // PhongPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.dataGridViewroom);
            this.Controls.Add(this.btnexitr);
            this.Controls.Add(this.btncancelr);
            this.Controls.Add(this.btncofirmr);
            this.Controls.Add(this.btnfixr);
            this.Controls.Add(this.rstatus);
            this.Controls.Add(this.roption);
            this.Controls.Add(this.rprice);
            this.Controls.Add(this.rcode);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhongPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhongPage";
            this.Load += new System.EventHandler(this.PhongPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rprice;
        private System.Windows.Forms.TextBox rcode;
        private System.Windows.Forms.ComboBox roption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rstatus;
        private System.Windows.Forms.Button btnfixr;
        private System.Windows.Forms.Button btncofirmr;
        private System.Windows.Forms.Button btncancelr;
        private System.Windows.Forms.Button btnexitr;
        private System.Windows.Forms.DataGridView dataGridViewroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}