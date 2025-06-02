using Emp_Manag_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Emp_project
{
    public partial class Salary_Payslip : Form
    {
        public string Gender = "";
        public Salary_Payslip()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee_Salary emp = new Employee_Salary();
            emp.Show();
            this.Hide();
        }

        private void btn_payslip_Click(object sender, EventArgs e)
        {

            if(rdo_male.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            Generate_Payslip gp = new Generate_Payslip();
            gp.img = photo_box.Image;
            gp.Name = txt_slip_uname.Text.Trim();

            if(dept_emp.SelectedIndex == -1)
            {
                gp.Department = "";
            }
            else
            {
                gp.Department = dept_emp.SelectedItem.ToString();
            }
            gp.Salary = txt_slip_salary.Text.Trim();
            gp.Bonus =txt_slip_bonus.Text.Trim();
            gp.Total = txt_slip_total.Text.Trim();
            gp.Gender = Gender;

            gp.Show();
            this.Hide();
        }

        private void btn_image_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            ofg.Title = "Select an Employee Image";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                string file_path = ofg.FileName;
                photo_box.Image = Image.FromFile(ofg.FileName);
            }
        }

        private void photo_box_Click(object sender, EventArgs e)
        {
            photo_box.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txt_slip_bonus_TextChanged(object sender, EventArgs e)
        {
            if (txt_slip_bonus.Text.Length > 0)
            {
                txt_slip_total.Text = (Convert.ToInt64(txt_slip_salary.Text) +
                Convert.ToInt64(txt_slip_bonus.Text)).ToString();
            }
        }
    }
}
