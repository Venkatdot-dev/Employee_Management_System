using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Emp_project
{
    public partial class Update_Password : Form
    {
        public Update_Password()
        {
            InitializeComponent();
        }

        private void Update_Password_Load(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure, want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_window lw = new Login_window();
                lw.Show();
                this.Hide();
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_setpass.Text.Trim().Length >= 8)
            {
                if (txt_setpass.Text.Trim() == txt_repass.Text.Trim())
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_change_pass", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@Admin_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_uname.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@Admin_pass", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_setpass.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@Admin_cpass", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_repass.Text.Trim();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Password Updated Successfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login_window lw = new Login_window();
                        lw.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Updation Failed!", "Password Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_uname.Clear();
                        txt_setpass.Clear();
                        txt_repass.Clear();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Miss Macthing Password Should not accepted!");
                }
            }
            else
            {
                MessageBox.Show("Password must be 8 Digits");
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
