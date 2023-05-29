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
    public partial class ThuePhongPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader rdr;
        string sql;
        int maphong, makh;

        public void laynguoncbbp()
        {

            sql = "select maphong,tenphong from Phong where tinhtrang=N'Trống'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            txtpTP.DataSource = dataTable;
            txtpTP.DisplayMember = "tenphong";
            txtpTP.ValueMember = "maphong";
           
        }

        public void laynguonkh()
        {
            sql = "SELECT makh,tenkh FROM KhachHang";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            txtkTP.DataSource = dataTable;
            txtkTP.DisplayMember = "tenkh";
            txtkTP.ValueMember = "makh";
        }
        public ThuePhongPage()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThuePhongPage_Load(object sender, EventArgs e)
        {
            conn.Open();

            laynguonphongthue();
            laynguoncbbp();
            laynguonkh();
            conn.Close();
        }

        void laynguonphongthue()
        {
            cmd = new SqlCommand("select * from ThuePhong", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewTP.DataSource = dataTable;
        }

        private void addTP_Click(object sender, EventArgs e)
        {
            if (lblMaKH.Text == "" || lblMaPhong.Text == "") return;
            conn.Open();
            string queryString = @"INSERT INTO ThuePhong (maKH, maPhong, NgayDen, tinhTrangThue) VALUES (@makhachhang, @maphong, @ngayden, N'Đang Thuê'); UPDATE Phong SET tinhTrang = @tinhtrang WHERE maPhong = @maphong";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@makhachhang", makh);
            cmd.Parameters.AddWithValue("@maphong", maphong);
            cmd.Parameters.AddWithValue("@ngayden", txtcomeTP.Value.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@tinhtrang", txttinhtrangTP.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thuê phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            laynguoncbbp();
            laynguonphongthue();
            lblMaPhong.Text = "";
        }

        private void txtpTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maphong = (int)txtpTP.SelectedValue;
                lblMaPhong.Text = maphong.ToString();
            }catch (Exception) { }
        }

        private void addnewkh_Click(object sender, EventArgs e)
        {

        }

        private void txtkTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                makh = (int)txtkTP.SelectedValue;
                lblMaKH.Text = makh.ToString();
            }
            catch (Exception) { }
        }

        private void dataGridViewTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
