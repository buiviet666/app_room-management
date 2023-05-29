using QL_Nha_Tro_Demo.QLKSEZDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_Nha_Tro_Demo
{
    public partial class SDDichVuPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string sql;
        int sophong, mathuephong, madv;
        

        public void laynguondv()
        {
            sql = "select madv,tendv,giadv,dvt from dichvu";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgDichVu.DataSource = dataTable;
        }

        public void laynguonphong()
        {
            cmd = new SqlCommand("select maphong,tenphong from Phong", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cboPhong.DataSource = dataTable;
            cboPhong.DisplayMember = "tenphong";
            cboPhong.ValueMember = "maphong";
        }

        public void laynguonkhachhang()
        {
            try
            {
                sophong = -1;
                sql = "select KhachHang.maKH,tenKH,soDTKH,mathuephong from KhachHang inner join thuephong on khachhang.makh=thuephong.makh where tinhtrangthue = N'Đang Thuê'";
                if (cboPhong.Text != "")           
                {
                    sophong = (int) cboPhong.SelectedValue;
                    sql = sql + " and maphong = " + sophong;
                }
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgKhach.DataSource = dataTable;
            }
            catch(Exception) { }
        }

        public void laynguonsddv()
        {
            if (sophong == -1) return;
            sql = "select idSDDV, maThuePhong,DichVu.MaDV, tenDV, soluong, giaDV, thanhtien,ngaySD " +
                " from DichVu inner join SDDV on DichVu.MaDV=SDDV.MaDV "+ 
                " where mathuephong = " + mathuephong;
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgDVSuDung.DataSource = dataTable;
        }

        
        public SDDichVuPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void SDDichVuPage_Load(object sender, EventArgs e)
        {
            conn.Open();

            laynguonphong();
            laynguondv();            

            conn.Close();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            laynguonkhachhang();
            
        }

        private void dgKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sddvadd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string queryString = @"INSERT INTO SDDV (maDV, maThuePhong, soLuong, thanhTien, ngaySD) VALUES (@madichvu, @mathuephong, @soluong, @thanhtien, GETDATE());";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@madichvu", madv.ToString());
            cmd.Parameters.AddWithValue("@mathuephong", mathuephong.ToString());
            cmd.Parameters.AddWithValue("@soluong", txtSoluong.Text);

            float giadichvuValue = float.Parse(giadichvu.Text);
            float soluongValue = float.Parse(txtSoluong.Text);
            float thanhtien = giadichvuValue * soluongValue;

            cmd.Parameters.AddWithValue("@thanhtien", thanhtien.ToString());
            

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Thêm dịch vụ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgDVSuDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgDichVu.RowCount <= 0) return;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgDichVu.Rows[e.RowIndex];
                    madv = int.Parse(row.Cells[0].Value.ToString());
                    giadichvu.Text = row.Cells[2].Value.ToString();
                    lblMaDV.Text = madv + ". " + row.Cells[1].Value.ToString();                    
                }


            }
            catch (Exception) { }
        }

        private void dgKhach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgKhach.RowCount <= 0) return;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgKhach.Rows[e.RowIndex];
                    mathuephong = int.Parse(row.Cells[3].Value.ToString());
                    laynguonsddv();
                }
            }
            catch (Exception) { }
        }
    }
}
