using Company_Emp_project;
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

namespace Emp_Manag_Project
{
    public partial class Employee_Salary : Form
    {
        public Employee_Salary()
        {
            InitializeComponent();
        }
 

        private void btn_slry_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_salary_insert", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@sly_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = cmb_name.SelectedItem.ToString();

                SqlParameter p2 = new SqlParameter("@sly_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = txt_salary.Text.Trim();

                SqlParameter p3 = new SqlParameter("@sly_bonus", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = txt_bonus.Text.Trim();

                SqlParameter p4 = new SqlParameter("@sly_total", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = txt_total.Text.Trim();



                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Salary Added successfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Salary added Failed!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_salary_fetch", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        

        private void rdo_manager_CheckedChanged(object sender, EventArgs e)
        {
            rdo_manager.ForeColor = Color.Green;
            rdo_emp.ForeColor = Color.Red;

            txt_salary.Clear();
            txt_bonus.Clear();
            txt_total.Clear();
            cmb_name.Items.Clear();
            cmb_name.Items.Add("Venkat");
            cmb_name.Items.Add("Vicky");
        }

        private void rdo_emp_CheckedChanged(object sender, EventArgs e)
        {
            rdo_manager.ForeColor = Color.Red;
            rdo_emp.ForeColor = Color.Green;

            txt_salary.Clear();
            txt_bonus.Clear();
            txt_total.Clear();
            cmb_name.Items.Clear();
            cmb_name.Items.Add("Kalai");
            cmb_name.Items.Add("Iyappan");
        }

        private void btn_slry_add_Click_1(object sender, EventArgs e)
        {
            if (cmb_name.Text.Trim() == "" || txt_salary.Text.Trim() == ""
                || txt_bonus.Text.Trim() == "" || txt_total.Text.Trim() == "")
            {
                MessageBox.Show("Fill are the data's");
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_salary_insert", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@sly_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = cmb_name.SelectedItem.ToString();

                    SqlParameter p2 = new SqlParameter("@sly_salary", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_salary.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@sly_bonus", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txt_bonus.Text.Trim();

                    SqlParameter p4 = new SqlParameter("@sly_total", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txt_total.Text.Trim();



                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Salary Added successfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Salary added Failed!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btn_slry_fetch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_salary_fetch", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_name.SelectedItem.ToString() == "Venkat")
            {
                cmb_name.Text = "Venkat";
                txt_salary.Text = "50000";
            }
            else if (cmb_name.Text == "Vicky")
            {
                cmb_name.Text = "Vicky";
                txt_salary.Text = "60000";
            }
            else if (cmb_name.Text == "Kalai")
            {
                cmb_name.Text = "Kalai";
                txt_salary.Text = "40000";
            }
            else if (cmb_name.Text == "Iyappan")
            {
                cmb_name.Text = "Iyappan";
                txt_salary.Text = "30000";
            }
            else
            {
                txt_salary.Text = "0";
            }
        }

        private void txt_bonus_TextChanged(object sender, EventArgs e)
        {
            if (txt_bonus.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt64(txt_salary.Text) + Convert.ToInt64(txt_bonus.Text)).ToString();
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

        private void slry_slip_Click(object sender, EventArgs e)
        {
            Salary_Payslip sp = new Salary_Payslip();
            sp.Show();
            this.Hide();
        }
    }
}
