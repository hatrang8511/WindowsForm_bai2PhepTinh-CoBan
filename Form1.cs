using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_bai2PhepTinh_CoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so1 = Convert.ToDouble(txtso1.Text);
            
            double kd = so1 + so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double kd = so1 - so2;
            txtKq.Text = txtKq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double kd = so1 * so2;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);

            if (so2 == 0)
            {
                txtKq.Text = "khong the chia het cho 0";
            }
            else
            {
                double kd = so1 / so2;
                txtKq.Text = kd.ToString();
            }



            }
    }
}
