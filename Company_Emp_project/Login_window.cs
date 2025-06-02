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
    public partial class Login_window : Form
    {
        public Login_window()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
        }

        private void rst_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_adm_uname.Clear();
            txt_pass.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure, want to Exit Application?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Exit Successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_adm_uname.Text.Trim() == "" || txt_pass.Text.Trim() == "")
                {
                    MessageBox.Show("Fill are the data's");
                }
                else if (txt_adm_uname.Text.Trim() == "Admin" || txt_pass.Text.Trim() == "2501")
                {
                    MessageBox.Show("Welcome Back Admin", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Dashboard Ad = new Admin_Dashboard();
                    Ad.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_register_login", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@Admin_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_adm_uname.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@Admin_pass", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_pass.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);

                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back " + txt_adm_uname.Text ,"Login Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin_Dashboard ad = new Admin_Dashboard();
                        ad.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Login Failed, Invalid user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = show_pass.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_pass f = new Forget_pass();
            f.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_win rw = new Register_win();
            rw.Show();
            this.Hide();
        }
    }
}
