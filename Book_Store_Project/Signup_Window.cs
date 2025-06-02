using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Book_Store_Project
{
    public partial class Signup_Window : Form
    {
         private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;
        public Signup_Window()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string name = txt_name.Text.Trim();
            string mobile = txt_mobile.Text.Trim();
            string email = txt_email.Text.Trim();
            string pass = txt_pass.Text.Trim();

            string mobile_pattern = @"^\d{10}$";
            string email_pattern = @"^[a-zA-Z0-9._%+-]+@[a-z]+\.[a-z]{2,}$";
            string pass_pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{4,}";

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name)
             || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(email)
             || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("All feilds are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!Regex.IsMatch(mobile, mobile_pattern))
            {
                MessageBox.Show("Invalid mobile number! , Must be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!Regex.IsMatch(email, email_pattern))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(pass, pass_pattern))
            {
                MessageBox.Show("Password must be Atleast 6 Characters ,  include 1 letter , 1 number , and 1 special character.",
                    "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string enc_pass = EC_DE.Encrypt(pass);


            try
            {

                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    if (Is_admin_close(id, mobile, email, enc_pass))
                    {
                        MessageBox.Show("ID, Mobile, Email , or Password already exist!",
                            "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ok", "Sign_up", MessageBoxButtons.OK);


                        using (SqlCommand cmd = new SqlCommand("sp_admin_insert", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@mobile", mobile);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@pass", enc_pass);

                            int res = cmd.ExecuteNonQuery();

                            if (res >= 0)
                            {
                                MessageBox.Show("Data added successfully", "Sign_up", MessageBoxButtons.OK);

                            }
                            else
                            {
                                MessageBox.Show("Data not added", "Sign_up failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                con.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public bool Is_admin_close(string id, string mobile, string email, string pass)
        {
            using (SqlConnection con = new SqlConnection(con_string))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_admin_unique", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return count > 0;
                }

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login_Window lw = new Login_Window();
            lw.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        public void Clearall()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_mobile.Clear();
            txt_email.Clear();
            txt_pass.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
