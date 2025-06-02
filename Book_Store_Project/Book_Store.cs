using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Project
{
    public partial class Book_Store : Form
    {
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;

        public Book_Store()
        {
            InitializeComponent();
        }

        private void lnk_admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Show_Details sd = new Show_Details();
            sd.Show();
            this.Hide();
        }

        private void lnk_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        
        private void btn_add_bk_Click(object sender, EventArgs e)
        {
            Book_add bd = new Book_add();
            bd.Show();
            this.Hide();
        }

        private void btn_bill_page_Click(object sender, EventArgs e)
        {

            Book_Bill bl = new Book_Bill();
            bl.Show();
            this.Hide();
        }
    }
}
