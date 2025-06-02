using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Project
{
    public partial class Login_Window : Form
    {
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;
        public Login_Window()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*'; 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string mobile = txt_mobile.Text.Trim();
            string pass = txt_pass.Text.Trim();

            try
            {

               
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    string enc_pass = EC_DE.Encrypt(pass);

                    using (SqlCommand cmd = new SqlCommand("sp_admin_login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@pass", enc_pass);

                        con.Open();

                        SqlDataReader read = cmd.ExecuteReader();

                        if (read.HasRows)
                        {

                            MessageBox.Show("Login Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Book_Store Bs = new Book_Store();
                            Bs.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Mobile or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = show_pass.Checked ? '\0' : '*';
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Cleartwo();
        }

        public void Cleartwo()
        {
            txt_pass.Clear();
            txt_mobile.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Signup_Window sp = new Signup_Window();
            this.Hide();
            sp.Show();
        }
    }
}
