using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_Nha_Tro_Demo
{
    public partial class NhanVienPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataGridViewCellEventArgs vt;

        public NhanVienPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NhanVienPage_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            khoamo(true);
            conn.Open();

            cmd = new SqlCommand("select * from NhanVien", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;

            conn.Close();
        }

        public void khoacn(bool gt)
        {
            confirmfix.Enabled = gt;
            add.Enabled = gt;
            fix.Enabled = gt;
            del.Enabled = gt;
        }

        public void xoatrangg()
        {
            // txtcode.Text = "";
            txtname.Text = "";
            txtdate.Text = "";
            txtsalary.Text = "";
            txtgender.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            if (dataGridView.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtcode.Text = row.Cells[0].Value.ToString();
                txtname.Text = row.Cells[1].Value.ToString();
                txtdate.Text = row.Cells[2].Value.ToString();
                txtgender.Text = row.Cells[3].Value.ToString();
                txtphone.Text = row.Cells[4].Value.ToString();
                txtemail.Text = row.Cells[5].Value.ToString();
                txtsalary.Text = row.Cells[6].Value.ToString();
            }
            conn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // txtcode.Text = "";
            txtname.Text = "";
            txtdate.Text = "";
            txtsalary.Text = "";
            txtgender.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
        }

        public void khoamo(bool b)
        {
            add.Enabled = b;
            fix.Enabled = b;
            del.Enabled = b;
            exit.Enabled = b;

            
            clear.Enabled = !b;
            write.Enabled = !b;
            dontwrite.Enabled = !b;
            confirmfix.Enabled = !b;

            txtcode.ReadOnly = b;
            txtdate.ReadOnly = b;
            txtgender.Enabled = !b;
            txtname.ReadOnly = b;
            txtsalary.ReadOnly = b;
            txtphone.ReadOnly = b;
            txtemail.ReadOnly = b;
        }

        public void khoamofix(bool c)
        {
            add.Enabled= c;
            fix.Enabled = c;
            del.Enabled = c;
            exit.Enabled = c;

            clear.Enabled = !c;
            confirmfix.Enabled = !c;
            dontwrite.Enabled= !c;

            txtcode.ReadOnly = c;
            txtdate.ReadOnly = c;
            txtgender.Enabled = !c;
            txtname.ReadOnly = c;
            txtsalary.ReadOnly = c;
            txtphone.ReadOnly = c;
            txtemail.ReadOnly = c;
        }

        public void disablefix(bool a)
        {
            confirmfix.Enabled = !a;
        }

        private void add_Click(object sender, EventArgs e)
        {
            xoatrangg();
            khoamo(false);
            disablefix(true);
            txtname.Focus();


        }

        private void fix_Click(object sender, EventArgs e)
        {
            khoamofix(false);
            txtname.Focus();
        }

        private void del_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (MessageBox.Show("Bạn có muốn xóa nhân viên [ " + txtname.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string queryString = @"DELETE FROM NhanVien WHERE tenNV = @tennhanvien";
                cmd.CommandText = queryString;

                cmd.Parameters.AddWithValue("@tennhanvien", txtname.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa nhân viên " + txtname.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                
            }

                
            conn.Close();
            

        }

        private void dontwrite_Click(object sender, EventArgs e)
        {
            try
            {
                xoatrangg();
                khoamo(true);
                dataGridView_CellContentClick(sender, vt);
            }
            catch (Exception)
            {

            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            
            if (txtname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

            conn.Open();
            string queryString = @"INSERT INTO NhanVien (tenNV, NgaySinh, gioiTinh, soDT, email, luong) VALUES (@tennhanvien, @ngaysinh, @gioitinh, @sodienthoai, @email, @luong)";
            cmd.CommandText = queryString;
            
            // cmd.Parameters.AddWithValue("@manhanvien", txtcode.Text);
            cmd.Parameters.AddWithValue("@tennhanvien", txtname.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", txtdate.Text);
            cmd.Parameters.AddWithValue("@gioitinh", txtgender.Text);
            cmd.Parameters.AddWithValue("@sodienthoai", txtphone.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@luong", txtsalary.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm Nhân Viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamo(true);

        }

        private void confirmfix_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

            string queryString = @"UPDATE NhanVien SET tenNV = @tennv, ngaySinh = @ngaysinh, gioiTinh = @gioitinh, soDT = @sodt, email = @email, luong = @luong WHERE maNV = @manhanvien";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@manhanvien", txtcode.Text);
            cmd.Parameters.AddWithValue("@tennv", txtname.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", txtdate.Text);
            cmd.Parameters.AddWithValue("@gioitinh", txtgender.Text);
            cmd.Parameters.AddWithValue("@sodt", txtphone.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@luong", txtsalary.Text);


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa Nhân Viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamofix(true);
        }
    }
}
