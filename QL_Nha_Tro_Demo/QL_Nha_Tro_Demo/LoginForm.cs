using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_Nha_Tro_Demo
{
    public partial class login : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO985QK;Initial Catalog=QLKSEZ;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr;
        
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from admin where taikhoan=@tenTK and matkhau=@matKhau", conn);
            cmd.Parameters.AddWithValue("@tenTK", taikhoan.Text);
            cmd.Parameters.AddWithValue("@matKhau", matkhau.Text);
            conn.Open();
            
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                MessageBox.Show("Đăng Nhập thành công", "Thông Báo" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashBoad dashBoad = new DashBoad();
                Hide();
                dashBoad.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập thất bại, vui lòng nhập lại Tài Khoản hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taikhoan.Text = "";
                matkhau.Text = "";
                taikhoan.Focus();
            }

            conn.Close();
        }

        private void taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            Show();
            taikhoan.Focus();
        }
    }
}
