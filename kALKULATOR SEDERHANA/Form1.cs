namespace Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "1";
            }
            else
            {
                txtDisplay1.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "2";
            }
            else
            {
                txtDisplay1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "3";
            }
            else
            {
                txtDisplay1.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "4";
            }
            else
            {
                txtDisplay1.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "6";
            }
            else
            {
                txtDisplay1.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "7";
            }
            else
            {
                txtDisplay1.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "8";
            }
            else
            {
                txtDisplay1.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "9";
            }
            else
            {
                txtDisplay1.Text = "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text != "0")
            {
                txtDisplay1.Text += "0";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay2.Text = " ";
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "*";
            txtDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "/";
            txtDisplay1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "-";
            txtDisplay1.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "+";
            txtDisplay1.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay1.Text);

            {
                switch (opr)
                {
                    case 1:
                        txtDisplay1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        txtDisplay1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        txtDisplay1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        txtDisplay1.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}
// Copyright by 23.82.1723