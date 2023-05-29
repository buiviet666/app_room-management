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
    public partial class PhongPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataGridViewCellEventArgs vt;

        public void khoamoroom(bool rom)
        {
            btnexitr.Enabled = rom;

            btnfixr.Enabled = !rom;
            btncofirmr.Enabled = !rom;
            btncancelr.Enabled = !rom;

            rcode.ReadOnly = rom;
            rname.ReadOnly = rom;
            rprice.ReadOnly = rom;
            roption.Enabled = !rom;
            rstatus.Enabled = !rom;
        }

        public void khoamofixroom(bool orom)
        {
            btnfixr.Enabled = orom;
            
        }

        public void khoamodulieu(bool dlrom)
        {
            btnfixr.Enabled = !dlrom;

            rcode.ReadOnly = dlrom;
            rname.ReadOnly = dlrom;
            rprice.ReadOnly = dlrom;
        }
        public PhongPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PhongPage_Load(object sender, EventArgs e)
        {
            khoamoroom(true);
            rname.Focus();

            conn.Open();

            cmd = new SqlCommand("select * from Phong", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewroom.DataSource = dataTable;

            conn.Close();
        }

        private void btnexitr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            if (dataGridViewroom.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                khoamofixroom(true);
                vt = e;
                DataGridViewRow row = dataGridViewroom.Rows[e.RowIndex];
                rcode.Text = row.Cells[0].Value.ToString();
                roption.Text = row.Cells[1].Value.ToString();
                rname.Text = row.Cells[2].Value.ToString();
                rprice.Text = row.Cells[3].Value.ToString();
                rstatus.Text = row.Cells[4].Value.ToString();
            }

            conn.Close();
        }

        private void btnfixr_Click(object sender, EventArgs e)
        {
            khoamoroom(false);
            khoamodulieu(true);

        }

        private void btncancelr_Click(object sender, EventArgs e)
        {
            try
            {
                khoamoroom(true);
                dataGridViewroom_CellContentClick(sender, vt);
            }
            catch (Exception)
            {

            }
        }

        private void btncofirmr_Click(object sender, EventArgs e)
        {
            conn.Open();

            string queryString = @"UPDATE Phong SET loaiPhong = @loaiphong, tenPhong = @tenphong, giaPhong = @giaphong, tinhTrang = @tinhtrang WHERE maPhong = @maphong";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@maphong", rcode.Text);
            cmd.Parameters.AddWithValue("@loaiphong", roption.Text);
            cmd.Parameters.AddWithValue("@tenPhong", rname.Text);
            cmd.Parameters.AddWithValue("@giaPhong", rprice.Text);
            cmd.Parameters.AddWithValue("@tinhTrang", rstatus.Text);


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa Thông Tin Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamoroom(true);
        }
    }
}
