namespace QL_Nha_Tro_Demo
{
    partial class TimKiemPhongPage
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
            this.searchboxroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchboxtextroom = new System.Windows.Forms.TextBox();
            this.searchroom = new System.Windows.Forms.Button();
            this.clearroom = new System.Windows.Forms.Button();
            this.exitroom = new System.Windows.Forms.Button();
            this.dataGridViewroomsearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewroomsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cách tìm kiếm: ";
            // 
            // searchboxroom
            // 
            this.searchboxroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchboxroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboxroom.FormattingEnabled = true;
            this.searchboxroom.Items.AddRange(new object[] {
            "Tất cả",
            "Mã phòng",
            "Loại Phòng",
            "Tên Phòng",
            "Tình Trạng"});
            this.searchboxroom.Location = new System.Drawing.Point(129, 150);
            this.searchboxroom.Name = "searchboxroom";
            this.searchboxroom.Size = new System.Drawing.Size(271, 28);
            this.searchboxroom.TabIndex = 12;
            this.searchboxroom.SelectedIndexChanged += new System.EventHandler(this.searchboxroom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ khóa: ";
            // 
            // searchboxtextroom
            // 
            this.searchboxtextroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboxtextroom.Location = new System.Drawing.Point(506, 151);
            this.searchboxtextroom.Name = "searchboxtextroom";
            this.searchboxtextroom.Size = new System.Drawing.Size(271, 27);
            this.searchboxtextroom.TabIndex = 14;
            // 
            // searchroom
            // 
            this.searchroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchroom.Location = new System.Drawing.Point(504, 198);
            this.searchroom.Name = "searchroom";
            this.searchroom.Size = new System.Drawing.Size(87, 49);
            this.searchroom.TabIndex = 15;
            this.searchroom.Text = "Tìm kiếm";
            this.searchroom.UseVisualStyleBackColor = true;
            this.searchroom.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearroom
            // 
            this.clearroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearroom.Location = new System.Drawing.Point(597, 198);
            this.clearroom.Name = "clearroom";
            this.clearroom.Size = new System.Drawing.Size(87, 49);
            this.clearroom.TabIndex = 15;
            this.clearroom.Text = "Xóa trắng";
            this.clearroom.UseVisualStyleBackColor = true;
            this.clearroom.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitroom
            // 
            this.exitroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitroom.Location = new System.Drawing.Point(690, 198);
            this.exitroom.Name = "exitroom";
            this.exitroom.Size = new System.Drawing.Size(87, 49);
            this.exitroom.TabIndex = 15;
            this.exitroom.Text = "Thoát";
            this.exitroom.UseVisualStyleBackColor = true;
            this.exitroom.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewroomsearch
            // 
            this.dataGridViewroomsearch.AllowUserToAddRows = false;
            this.dataGridViewroomsearch.AllowUserToDeleteRows = false;
            this.dataGridViewroomsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewroomsearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewroomsearch.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewroomsearch.Name = "dataGridViewroomsearch";
            this.dataGridViewroomsearch.ReadOnly = true;
            this.dataGridViewroomsearch.RowHeadersWidth = 51;
            this.dataGridViewroomsearch.RowTemplate.Height = 24;
            this.dataGridViewroomsearch.Size = new System.Drawing.Size(836, 264);
            this.dataGridViewroomsearch.TabIndex = 16;
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
            this.Column3.DataPropertyName = "loaiPhong";
            this.Column3.HeaderText = "Loại Phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "giaPhong";
            this.Column4.HeaderText = "Giá Phòng";
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
            // TimKiemPhongPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.dataGridViewroomsearch);
            this.Controls.Add(this.exitroom);
            this.Controls.Add(this.clearroom);
            this.Controls.Add(this.searchroom);
            this.Controls.Add(this.searchboxtextroom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchboxroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemPhongPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemPhongPage";
            this.Load += new System.EventHandler(this.TimKiemPhongPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewroomsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchboxroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchboxtextroom;
        private System.Windows.Forms.Button searchroom;
        private System.Windows.Forms.Button clearroom;
        private System.Windows.Forms.Button exitroom;
        private System.Windows.Forms.DataGridView dataGridViewroomsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}