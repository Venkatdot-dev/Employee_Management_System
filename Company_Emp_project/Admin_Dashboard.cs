using Emp_Manag_Project;
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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_admin_search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = srch_emp.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            Clear_data();
        }

        public void Clear_data()
        {
            txt_empid.Clear();
            txt_empname.Clear();
            txt_empsalry.Clear();
            dept_emp.SelectedIndex = -1;
            role_emp.SelectedIndex = -1;
            srch_emp.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_admin_insert", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_empid.Text.Trim();

                SqlParameter p2 = new SqlParameter("@Emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = txt_empname.Text.Trim();

                SqlParameter p3 = new SqlParameter("@Emp_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = txt_empsalry.Text.Trim();

                SqlParameter p4 = new SqlParameter("@Emp_dept", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = dept_emp.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@Emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = role_emp.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Employee Data Added successfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee Data added Failed!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand cmd = new SqlCommand("sp_admin_fetch", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_admin_update", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txt_empid.Text.Trim();

                SqlParameter p2 = new SqlParameter("@Emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = txt_empname.Text.Trim();

                SqlParameter p3 = new SqlParameter("@Emp_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = txt_empsalry.Text.Trim();

                SqlParameter p4 = new SqlParameter("@Emp_dept", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = dept_emp.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@Emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = role_emp.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Updated successfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure, want to Delete Data?", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NM1SBH8;Initial Catalog=EMP_MANAGMENT_SYSTEM;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_admin_delete", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = srch_emp.Text;

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Employee Data Deleted Successfully", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
        }
        
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bm, 120, 120);
        }
       
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_empid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_empname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_empsalry.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dept_emp.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                role_emp.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
          Employee_Salary es=  new  Employee_Salary();
          es.Show();
          this.Hide();
        }
    }
}
