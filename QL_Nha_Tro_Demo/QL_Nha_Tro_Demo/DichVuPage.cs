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
    public partial class DichVuPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataGridViewCellEventArgs vt;

        public void khoamodv(bool serv)
        {
            adddv.Enabled = serv;
            fixdv.Enabled = serv;
            exitdv.Enabled = serv;

            deldv.Enabled = !serv;
            cleardv.Enabled = !serv;
            addconfirmdv.Enabled = !serv;
            fixconfirmdv.Enabled = !serv;
            canceldv.Enabled = !serv;

            dvcode.ReadOnly = serv;
            dvname.ReadOnly = serv;
            dvprice.ReadOnly = serv;
            dvdvt.ReadOnly = serv;
        }

        public void khoamodvdel(bool servdel)
        {
            deldv.Enabled = servdel;
        }

        public void khoamodvadd(bool servadd)
        {
            dvcode.ReadOnly = servadd;

            deldv.Enabled = !servadd;
            fixconfirmdv.Enabled = !servadd;
        }

        public void khoamodvfix(bool servfix)
        {
            dvcode.ReadOnly = servfix;
            deldv.Enabled = !servfix;

            cleardv.Enabled = !servfix;
            addconfirmdv.Enabled = !servfix;
        }

        public void xoatrangdv()
        {
            dvcode.Text = "";
            dvname.Text = "";
            dvprice.Text = "";
            dvdvt.Text = "";
        }

        public DichVuPage()
        {
            InitializeComponent();
        }

        private void DichVuPage_Load(object sender, EventArgs e)
        {
            khoamodv(true);
            dvname.Focus();

            conn.Open();

            cmd = new SqlCommand("select * from DichVu", conn);
            adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewdv.DataSource = dataTable;

            conn.Close();
        }

        private void dataGridViewdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            if (dataGridViewdv.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                khoamodvdel(true);
                vt = e;
                DataGridViewRow row = dataGridViewdv.Rows[e.RowIndex];
                dvcode.Text = row.Cells[0].Value.ToString();
                dvname.Text = row.Cells[1].Value.ToString();
                dvprice.Text = row.Cells[2].Value.ToString();
                dvdvt.Text = row.Cells[3].Value.ToString();
            }

            conn.Close();
        }

        private void exitdv_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cleardv_Click(object sender, EventArgs e)
        {
            dvcode.Text = "";
            dvname.Text = "";
            dvprice.Text = "";
            dvdvt.Text = "";
        }

        private void canceldv_Click(object sender, EventArgs e)
        {
            try
            {
                xoatrangdv();
                khoamodv(true);
                dataGridViewdv_CellContentClick(sender, vt);
            }
            catch (Exception)
            {

            }
        }

        private void adddv_Click(object sender, EventArgs e)
        {
            khoamodv(false);
            khoamodvadd(true);
            xoatrangdv();
            dvname.Focus();
        }

        private void fixdv_Click(object sender, EventArgs e)
        {
            khoamodv(false);
            khoamodvfix(true);
            dvname.Focus();
        }

        private void addconfirmdv_Click(object sender, EventArgs e)
        {
            if (dvname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dvname.Focus();
                return;
            }

            conn.Open();
            string queryString = @"INSERT INTO DichVu (tenDV, giaDV, DVT) VALUES (@tendichvu, @giadichvu, @donvitinh)";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@tendichvu", dvname.Text);
            cmd.Parameters.AddWithValue("@giadichvu", dvprice.Text);
            cmd.Parameters.AddWithValue("@donvitinh", dvdvt.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm Dịch Vụ thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamodv(true);
        }

        private void fixconfirmdv_Click(object sender, EventArgs e)
        {

            if (dvname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dvname.Focus();
                return;
            }

            conn.Open();
            string queryString = @"UPDATE DichVu SET tenDV = @tendichvu, giaDV = @giadichvu, DVT = @donvitinh WHERE maDV = @madichvu";
            cmd.CommandText = queryString;

            cmd.Parameters.AddWithValue("@madichvu", dvcode.Text);
            cmd.Parameters.AddWithValue("@tendichvu", dvname.Text);
            cmd.Parameters.AddWithValue("@giadichvu", dvprice.Text);
            cmd.Parameters.AddWithValue("@donvitinh", dvdvt.Text);


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa Dịch Vụ thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khoamodv(true);
        }

        private void deldv_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (MessageBox.Show("Bạn có muốn xóa Dịch Vụ [ " + dvname.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string queryString = @"DELETE FROM DichVu WHERE maDV = @madichvu";
                cmd.CommandText = queryString;

                cmd.Parameters.AddWithValue("@madichvu", dvcode.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa Dịch Vụ " + dvname.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

            conn.Close();
        }
    }
}
