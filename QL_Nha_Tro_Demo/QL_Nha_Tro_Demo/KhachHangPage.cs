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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace QL_Nha_Tro_Demo
{
    public partial class KhachHangPage : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataGridViewCellEventArgs vt;

        public void khoamokh(bool kh)
        {
            addkh.Enabled = kh;
            fixkh.Enabled = kh;
            exitkh.Enabled = kh;

            dellkh.Enabled = !kh;
            clearkh.Enabled = !kh;
            fixconfirmkh.Enabled = !kh;
            addconfirmkh.Enabled = !kh;
            cancelkh.Enabled = !kh;

            khname.ReadOnly = kh;
            khphone.ReadOnly = kh;
            khemail.ReadOnly = kh;
            khgender.Enabled = !kh;
            khaddress.ReadOnly = kh;
        }

        public void khoamokhfix(bool fixkh)
        {
            fixconfirmkh.Enabled = !fixkh;
        }

        public void khoamokhadd(bool addkh) 
        {
            addconfirmkh.Enabled = !addkh;
        }

        public void khoamokhdel(bool delkh)
        {
            dellkh.Enabled = delkh;
        }

        public void xoatrangkh()
        {
            khcode.Text = "";
            khname.Text = "";
            khphone.Text = "";
            khemail.Text = "";
            khgender.Text = "";
            khaddress.Text = "";
        }

        public KhachHangPage()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KhachHangPage_Load(object sender, EventArgs e)
        {
            khname.Focus();
            khoamokh(true);
            conn.Open();

            cmd = new SqlCommand("select * from KhachHang", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewKH.DataSource = dataTable;

            conn.Close();
        }

        private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            if (dataGridViewKH.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                khoamokhdel(true);
                vt = e;
                DataGridViewRow row = dataGridViewKH.Rows[e.RowIndex];
                khcode.Text = row.Cells[0].Value.ToString();
                khname.Text = row.Cells[1].Value.ToString();
                khaddress.Text = row.Cells[2].Value.ToString();
                khphone.Text = row.Cells[3].Value.ToString();
                khemail.Text = row.Cells[4].Value.ToString();
                khgender.Text = row.Cells[5].Value.ToString();
            }

            conn.Close();
        }

        private void cancelkh_Click(object sender, EventArgs e)
        {
            try
            {
                xoatrangkh();
                khoamokh(true);
                dataGridViewKH_CellContentClick(sender, vt);
            }
            catch (Exception)
            {

            }
        }

        private void addkh_Click(object sender, EventArgs e)
        {
            khoamokh(false);
            khoamokhfix(true);
            xoatrangkh();
            khname.Focus();
        }

        private void clearkh_Click(object sender, EventArgs e)
        {
            khcode.Text = "";
            khname.Text = "";
            khphone.Text = "";
            khemail.Text = "";
            khgender.Text = "";
            khaddress.Text = "";
        }

        private void fixkh_Click(object sender, EventArgs e)
        {
            khoamokh(false);
            khoamokhadd(true);
            khname.Focus();
        }

        private void dellkh_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (MessageBox.Show("Bạn có muốn xóa khách hàng [ " + khname.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string queryString = @"DELETE FROM KhachHang WHERE tenKH = @tenkhachhang";
                cmd.CommandText = queryString;

                cmd.Parameters.AddWithValue("@tenkhachhang", khname.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa khách hàng " + khname.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

            conn.Close();
        }

        private void addconfirmkh_Click(object sender, EventArgs e)
        {
            if (khname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                khname.Focus();
                return;
            }

            conn.Open();
            string queryString = @"INSERT INTO KhachHang (tenKH, diaChi, soDTKH, emailKH, gioiTinhKH) VALUES (@tenkhachhang, @diachi, @sodienthoai, @email, @gioitinh)";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@tenkhachhang", khname.Text);
            cmd.Parameters.AddWithValue("@diachi", khaddress.Text);
            cmd.Parameters.AddWithValue("@sodienthoai", khphone.Text);
            cmd.Parameters.AddWithValue("@email", khemail.Text);
            cmd.Parameters.AddWithValue("@gioitinh", khgender.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm Khách Hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamokh(true);
        }

        private void fixconfirmkh_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (khname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                khname.Focus();
                return;
            }

            string queryString = @"UPDATE KhachHang SET tenKH = @tenkhachhang, soDTKH = @sodienthoai, diaChi = @diachi, emailKH = @email, gioiTinhKH = @gioitinh WHERE maKH = @makhachhang";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@makhachhang", khcode.Text);
            cmd.Parameters.AddWithValue("@tenkhachhang", khname.Text);
            cmd.Parameters.AddWithValue("@sodienthoai", khphone.Text);
            cmd.Parameters.AddWithValue("@diachi", khaddress.Text);
            cmd.Parameters.AddWithValue("@email", khemail.Text);
            cmd.Parameters.AddWithValue("@gioitinh", khgender.Text);


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamokh(true);
            khoamokhdel(true);
        }
    }
}
