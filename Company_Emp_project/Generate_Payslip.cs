using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Emp_project
{
    public partial class Generate_Payslip : Form
    {
        public string Date, Name , Department ,Salary, Bonus, Total , Gender;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle page_area = e.PageBounds;
            int centerX = (page_area.Width / 30) - (this.back_panel.Width / -20);
            int centerY = (page_area.Height / 20) - (this.back_panel.Height / 20);
            e.Graphics.DrawImage(bm, centerX, centerY);
        }


        private void print_image_Click(object sender, EventArgs e)
        {
            Print(this.back_panel);
        }

        public Image  img = null;
        public Generate_Payslip()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Salary_Payslip sp = new Salary_Payslip();
            sp.Show();
            this.Hide();
        }

        private void Print(Panel v)
        {
            PrinterSettings ps = new PrinterSettings();
            back_panel = v;

            bm = new Bitmap(v.Width, v.Height);
            v.DrawToBitmap(bm, new Rectangle(0, 0, v.Width, v.Height));
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap bm;
        private void Generate_Payslip_Load(object sender, EventArgs e)
        {
            Date_time.Text = Date;
            photo_box.Image = img;
            Lbl_name.Text = Name;
            Lbl_dept.Text = Department;
            Lbl_salary.Text = Salary;
            Lbl_bonus.Text = Bonus;
            Lbl_total.Text = Total;
            Lbl_gender.Text = Gender;

        }
    }
}
