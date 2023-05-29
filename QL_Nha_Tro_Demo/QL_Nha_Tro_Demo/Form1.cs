using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_Nha_Tro_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        int startPoint = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar.Value = startPoint;
            if (startPoint == 100)
            {
                timer.Stop();
                progressBar.Value = 0;
                login login = new login();
                this.Hide();
                login.Show();
            }
        }
    }
}
