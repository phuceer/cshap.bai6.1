using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshap.bai6._1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnxkq_Click(object sender, EventArgs e)
        {
            double hk1, hk2, dtb;
            hk1 = Convert.ToDouble(txtdiemhk1.Text);
            hk2 = Convert.ToDouble(txtdiemhk2.Text);
            dtb = (hk1 + hk2) / 2;
            txtdtb.Text = Convert.ToString(dtb);
            if (dtb >= 5)
            {
                txtkq.Text = "được lên lớp";
            }
            else
                if (dtb <= 5)
            {
                txtkq.Text = "ở lại lớp";
            }
            if (dtb < 5)
            {
                txtxlhl.Text = "Yếu";
            }
            else if (dtb <= 6)
            {
                txtxlhl.Text = "Trung Bình";
            }
            else if (dtb < 8)
            {
                txtxlhl.Text = "Khá";
            }
            else
            {
                txtxlhl.Text = "Giỏi";

            }
        }
    }
}

