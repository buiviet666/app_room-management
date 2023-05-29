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

namespace QL_Nha_Tro_Demo
{
    public partial class TimKiemPhongPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public void xoatrang()
        {
            searchboxtextroom.Text = "";
        }
        public TimKiemPhongPage()
        {
            InitializeComponent();
        }

        private void TimKiemPhongPage_Load(object sender, EventArgs e)
        {
            searchboxroom.Text = "Tất cả";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (searchboxroom.Text == "Tất cả")
            {
                cmd = new SqlCommand("select * from Phong", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewroomsearch.DataSource = dataTable;
            }

            if (searchboxroom.Text == "Mã phòng")
            {
                cmd = new SqlCommand("select * from Phong where maPhong LIKE N'%" + searchboxtextroom.Text.Trim() + "%'", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewroomsearch.DataSource = dataTable;
                MessageBox.Show("Tìm kiếm mã phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (searchboxroom.Text == "Tên Phòng")
            {
                cmd = new SqlCommand("select * from Phong where tenPhong LIKE N'%" + searchboxtextroom.Text.Trim() + "%'", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewroomsearch.DataSource = dataTable;
                MessageBox.Show("Tìm kiếm tên phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (searchboxroom.Text == "Loại Phòng")
            {
                cmd = new SqlCommand("select * from Phong where loaiPhong LIKE N'%" + searchboxtextroom.Text.Trim() + "%'", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewroomsearch.DataSource = dataTable;
                MessageBox.Show("Tìm kiếm loại phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (searchboxroom.Text == "Tình Trạng")
            {
                cmd = new SqlCommand("select * from Phong where tinhTrang LIKE N'%" + searchboxtextroom.Text.Trim() + "%'", conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewroomsearch.DataSource = dataTable;
                MessageBox.Show("Tìm kiếm tình trạng phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoatrang();
        }

        private void searchboxroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
