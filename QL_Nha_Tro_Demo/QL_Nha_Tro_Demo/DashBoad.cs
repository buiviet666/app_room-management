using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nha_Tro_Demo
{
    public partial class DashBoad : Form
    {
        public DashBoad()
        {
            InitializeComponent();
        }

        private void DashBoad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienPage nvPage = new NhanVienPage();
            nvPage.ShowDialog();
        }

        private void QLPhongPage_Click(object sender, EventArgs e)
        {
            PhongPage phongPage = new PhongPage();
            phongPage.ShowDialog();
        }

        private void QLKHPage_Click(object sender, EventArgs e)
        {
            KhachHangPage khPage = new KhachHangPage();
            khPage.ShowDialog();
        }

        private void QLDVPage_Click(object sender, EventArgs e)
        {
           DichVuPage dvPage = new DichVuPage();
           dvPage.ShowDialog();
        }

        private void CNThuePhongPage_Click(object sender, EventArgs e)
        {
            ThuePhongPage tpPage = new ThuePhongPage();
            tpPage.ShowDialog();
        }

        private void CNTraPhongPage_Click(object sender, EventArgs e)
        {
            TraPhongPage traPPage = new TraPhongPage();
            traPPage.ShowDialog();
        }

        private void CNSuDungDVPage_Click(object sender, EventArgs e)
        {
            SDDichVuPage sddvPage = new SDDichVuPage();
            sddvPage.ShowDialog();
        }

        private void TKKhachHangPage_Click(object sender, EventArgs e)
        {
            TimKiemKHPage tkKHPage = new TimKiemKHPage();
            tkKHPage.ShowDialog();
        }

        private void TKPhongPage_Click(object sender, EventArgs e)
        {
            TimKiemPhongPage tkPhongPage = new TimKiemPhongPage();
            tkPhongPage.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn thoát khỏi hệ thống?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn đăng xuất khỏi hệ thống?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    Close();

                    login login = new login();
                    login.Show();
                }
            }
            else
            {
                Close();
            }
                    
        
        }
    }
}
