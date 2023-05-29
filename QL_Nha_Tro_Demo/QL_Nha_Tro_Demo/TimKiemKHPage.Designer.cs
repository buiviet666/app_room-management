namespace QL_Nha_Tro_Demo
{
    partial class TimKiemKHPage
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
            this.dataGridViewsearchkh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchboxhow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchboxkey = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchexit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsearchkh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tìm Kiếm";
            // 
            // dataGridViewsearchkh
            // 
            this.dataGridViewsearchkh.AllowUserToAddRows = false;
            this.dataGridViewsearchkh.AllowUserToDeleteRows = false;
            this.dataGridViewsearchkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsearchkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewsearchkh.Location = new System.Drawing.Point(12, 240);
            this.dataGridViewsearchkh.Name = "dataGridViewsearchkh";
            this.dataGridViewsearchkh.ReadOnly = true;
            this.dataGridViewsearchkh.RowHeadersWidth = 51;
            this.dataGridViewsearchkh.RowTemplate.Height = 24;
            this.dataGridViewsearchkh.Size = new System.Drawing.Size(836, 288);
            this.dataGridViewsearchkh.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cách tìm kiếm: ";
            // 
            // searchboxhow
            // 
            this.searchboxhow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchboxhow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboxhow.FormattingEnabled = true;
            this.searchboxhow.Items.AddRange(new object[] {
            "Tất cả",
            "Tên khách hàng",
            "Địa chỉ",
            "Số điện thoại"});
            this.searchboxhow.Location = new System.Drawing.Point(102, 142);
            this.searchboxhow.Name = "searchboxhow";
            this.searchboxhow.Size = new System.Drawing.Size(272, 28);
            this.searchboxhow.TabIndex = 11;
            this.searchboxhow.SelectedIndexChanged += new System.EventHandler(this.searchboxhow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ khóa: ";
            // 
            // searchboxkey
            // 
            this.searchboxkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboxkey.Location = new System.Drawing.Point(453, 142);
            this.searchboxkey.Name = "searchboxkey";
            this.searchboxkey.Size = new System.Drawing.Size(288, 27);
            this.searchboxkey.TabIndex = 12;
            // 
            // searchbtn
            // 
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Location = new System.Drawing.Point(453, 189);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(91, 37);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Tìm Kiếm";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchexit
            // 
            this.searchexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchexit.Location = new System.Drawing.Point(650, 189);
            this.searchexit.Name = "searchexit";
            this.searchexit.Size = new System.Drawing.Size(91, 37);
            this.searchexit.TabIndex = 13;
            this.searchexit.Text = "Thoát";
            this.searchexit.UseVisualStyleBackColor = true;
            this.searchexit.Click += new System.EventHandler(this.searchexit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKH";
            this.Column1.HeaderText = "mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKH";
            this.Column2.HeaderText = "tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.HeaderText = "địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soDTKH";
            this.Column4.HeaderText = "số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "emailKH";
            this.Column5.HeaderText = "email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gioiTinhKH";
            this.Column6.HeaderText = "giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // searchclear
            // 
            this.searchclear.Location = new System.Drawing.Point(550, 189);
            this.searchclear.Name = "searchclear";
            this.searchclear.Size = new System.Drawing.Size(91, 37);
            this.searchclear.TabIndex = 14;
            this.searchclear.Text = "Xóa trắng";
            this.searchclear.UseVisualStyleBackColor = true;
            this.searchclear.Click += new System.EventHandler(this.searchclear_Click);
            // 
            // TimKiemKHPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.searchclear);
            this.Controls.Add(this.searchexit);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchboxkey);
            this.Controls.Add(this.searchboxhow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewsearchkh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemKHPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemKHPage";
            this.Load += new System.EventHandler(this.TimKiemKHPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsearchkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewsearchkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchboxhow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchboxkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button searchexit;
        private System.Windows.Forms.Button searchclear;
    }
}