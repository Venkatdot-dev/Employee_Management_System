using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Emp_project
{
    public partial class Register_win : Form
    {
        public Register_win()
        {
            InitializeComponent();
        }
        public bool IsemailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex rgx = new Regex(pattern);
            return rgx.IsMatch(email);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_window lw = new Login_window();
            lw.Show();
            this.Hide();
        }
        private void rst_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_regunme.Clear();
            txt_regpass.Clear();
            txt_regconpass.Clear();
            txt_regemail.Clear();
            txt_regmobile.Clear();
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_regunme.Text.Trim() != "" &&
               txt_regpass.Text.Trim() != "" &&
               txt_regconpass.Text.Trim() != "" &&
               txt_regemail.Text.Trim() != "" &&
               txt_regmobile.Text.Trim() != "")
                {
                    string email_add = txt_regemail.Text;
                    bool isValid = IsemailValid(email_add);
                    if (isValid)
                    {
                        if (txt_regpass.Text.Trim().Length >= 8)
                        {
                            if (txt_regpass.Text.Trim() == txt_regconpass.Text.Trim())
                            {
                                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("sp_register_insert", conn);

                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@Admin_name", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = txt_regunme.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@Admin_pass", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = txt_regpass.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@Admin_cpass", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = txt_regconpass.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@Admin_email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = txt_regemail.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@Admin_mobile", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = txt_regmobile.Text.Trim();

                                int a = cmd.ExecuteNonQuery();
                                if (a > 0)
                                {
                                    MessageBox.Show("Registered Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Registered Error");
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
                    else
                    {
                        MessageBox.Show("Enter email in Correct format!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill all are feilds");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_window lw = new Login_window();
            lw.Show();
            this.Hide();
        }
    }
    
}
