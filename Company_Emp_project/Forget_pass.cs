using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Emp_project
{
    public partial class Forget_pass : Form
    {
        string random_code;
        public Forget_pass()
        {
            InitializeComponent();
        }

        private void btn_sent_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody, to;
            Random rm = new Random();
            random_code = (rm.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (txt_regismail.Text).ToUpper();
            from = "vvenkatroj@gmail.com";
            pass = "fzwc rzig kduc bzbf";
            messageBody = "Your OTP Verification Code : " + random_code;
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = messageBody;
            msg.Subject = "Employee Management Verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);


            try
            {
                smtp.Send(msg);
                MessageBox.Show("OTP Sended Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_otp_Click(object sender, EventArgs e)
        {

            if (random_code == (txt_otp.Text).ToString())
            {
                MessageBox.Show("OTP Verified Successfully");

                Update_Password UP = new Update_Password();
                UP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you sure, want to goto Login Page?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Successfully goto login page", "Login Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_window lw = new Login_window();
                lw.Show();
                this.Hide();
            }
        }
    }
}
