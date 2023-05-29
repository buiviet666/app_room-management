using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_Nha_Tro_Demo
{
    public partial class TraPhongPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataGridViewCellEventArgs vt;
        string sql;

        public void laynguonkh()
        {
            sql = "select * from KhachHang";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewtrapkh.DataSource = dataTable;
        }

        public void laynguonthuephong()
        {
            sql = "select * from ThuePhong";
            cmd = new SqlCommand(sql, conn) ;
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewtrap.DataSource = dataTable;
        }

        public void laynguonmaphongtp()
        {

        }
        public void khoamo(bool l)
        {
            trapten.ReadOnly = l;
            trapsdt.ReadOnly = l;
            trapemail.ReadOnly = l;
            trapgender.ReadOnly = l;
            trapaddress.ReadOnly = l;
        }
        public TraPhongPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TraPhongPage_Load(object sender, EventArgs e)
        {
            khoamo(true);
            conn.Open();

            laynguonkh();
            laynguonthuephong();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (searchboxkhtraphong.Text == "")
            {
                cmd = new SqlCommand("select * from KhachHang", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewtrapkh.DataSource = dataTable;
            } 
            else
            {
                cmd = new SqlCommand("select * from KhachHang where tenKH LIKE N'%" + searchboxkhtraphong.Text.Trim() + "%'", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewtrapkh.DataSource = dataTable;
                MessageBox.Show("Tìm kiếm tên khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }

        private void cleartrap_Click(object sender, EventArgs e)
        {
            trapten.Text = "";
            trapsdt.Text = "";
            trapemail.Text = "";
            trapgender.Text = "";
            trapaddress.Text = "";
        }

        private void dataGridViewtrapkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            if (dataGridViewtrapkh.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewtrapkh.Rows[e.RowIndex];
                trapcode.Text = row.Cells[0].Value.ToString();
                trapten.Text = row.Cells[1].Value.ToString();
                trapaddress.Text = row.Cells[2].Value.ToString();
                trapsdt.Text = row.Cells[3].Value.ToString();
                trapemail.Text = row.Cells[4].Value.ToString();
                trapgender.Text = row.Cells[5].Value.ToString();
            }
            conn.Close();
        }

        private void btntrap_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string queryString = @"UPDATE ThuePhong SET tinhTrangThue = @tinhtrangtraphong, ngayDi = @ngaydi WHERE maThuePhong = @mathuephong; UPDATE Phong SET tinhTrang = N'Trống' WHERE maPhong = @maphong;";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@mathuephong", mathuephong.Text);
            cmd.Parameters.AddWithValue("@maphong", trapmaphong.Text);
            cmd.Parameters.AddWithValue("@ngaydi", trapdate.Value.ToString("MM/dd/yyyy"));
            // cmd.Parameters.AddWithValue("@ngaydi", trapdate.Text);
            cmd.Parameters.AddWithValue("@tinhtrangtraphong", trangthaitraphong.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Trả phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewtrap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            if (dataGridViewtrap.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewtrap.Rows[e.RowIndex];
                mathuephong.Text = row.Cells[0].Value.ToString();
                trapmaphong.Text = row.Cells[2].Value.ToString();
            }
            conn.Close();
        }
    }
}
