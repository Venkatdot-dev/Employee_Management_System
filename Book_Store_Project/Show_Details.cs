using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Project
{
    public partial class Show_Details : Form
    {
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;

        public Show_Details()
        {
            InitializeComponent();
            Show_data();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear_all();
        }
        public void Clear_all()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_pass.Clear();
            txt_mobile.Clear();
            txt_email.Clear();
        }
      
        private void Show_Details_Load(object sender, EventArgs e)
        {
            Show_data();
        }

        public void Show_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_admin_get_all", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                dr["pass"] = EC_DE.Decrypt(dr["pass"].ToString());
                            }
                            dataGridView1.DataSource = dt;
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Con error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_id.Text = row.Cells["id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                txt_mobile.Text = row.Cells["mobile"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_pass.Text = row.Cells["pass"].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var confirm_msg = MessageBox.Show("Are you sure , want to delete this user?", "Confirm Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_msg != DialogResult.Yes) return;
                using (SqlConnection con = new SqlConnection(con_string))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_admin_delete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();
                        Clear_all();
                        Show_data();
                        MessageBox.Show(rows > 0 ? "User deleted." : "Delete Failed!.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string name = txt_name.Text.Trim();
            string mobile = txt_mobile.Text.Trim();
            string email = txt_email.Text.Trim();
            string pass = txt_pass.Text.Trim();


            string enc_pass = EC_DE.Encrypt(pass);

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

            try
            {

                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_admin_update", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", enc_pass);

                        int rows = cmd.ExecuteNonQuery();
                        Show_data();
                        MessageBox.Show(rows > 0 ? "User updated successfully." : "Update failed.");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure, want to goto Login Page?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Successfully goto login page", "Login Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_Window lw = new Login_Window();
                lw.Show();
                this.Hide();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Book_Store bs = new Book_Store();
            bs.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            string id = txt_id.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_admin_get_by_id", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader read = cmd.ExecuteReader();

                        if (read.Read())
                        {
                            txt_name.Text = read["name"].ToString();
                            txt_mobile.Text = read["mobile"].ToString();
                            txt_email.Text = read["email"].ToString();


                            string decrypted_pass = EC_DE.Decrypt(read["pass"].ToString());
                            txt_pass.Text = decrypted_pass;

                            MessageBox.Show("Record found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
