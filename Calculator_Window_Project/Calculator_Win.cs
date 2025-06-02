using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator_Window_Project
{
    public partial class Calculator_Win : Form
    {



        public Calculator_Win()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove default border
            this.BackColor = Color.White; // Optional: Set background color
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: Center the form
            SetRoundedRegion(30);
        }



        private void SetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion(30); // Reapply the rounded region on resize
        }


        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;


        private void btn_1_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
                cal_txt.Text = cal_txt.Text + btn_6.Text;

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_8.Text;

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_9.Text;
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_10.Text;
        }

        private void btn_dott_Click(object sender, EventArgs e)
        {
            cal_txt.Text = cal_txt.Text + btn_dott.Text;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(cal_txt.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            cal_txt.Text = result + "";

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(cal_txt.Text);
            cal_txt.Clear();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(cal_txt.Text);
            cal_txt.Clear();
        }

        private void btn_overall_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(cal_txt.Text);
            cal_txt.Clear();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(cal_txt.Text);
            cal_txt.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cal_txt.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cal_txt.Text))
            {
                cal_txt.Text = cal_txt.Text.Substring(0, cal_txt.Text.Length - 1);
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cal_txt.Text))
            {
                double value = Convert.ToDouble(
                    cal_txt.Text);

                if (value >= 0)
                {
                    double result = Math.Sqrt(value);
                    cal_txt.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input: cannot take square root of a negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
