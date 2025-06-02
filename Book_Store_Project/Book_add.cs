using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Project
{
    public partial class Book_add : Form
    {
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;
        public Book_add()
        {
            InitializeComponent();
            timer1.Start();
            bk_date_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void lnk_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Book_Store bs = new Book_Store();
            bs.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt");
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txt_bk_id.Clear();
            txt_bk_title.Clear();
            txt_bk_author.Clear();
            txt_bk_price.Clear();
            txt_bk_quanity.Clear();
            txt_bk_date.Value = DateTime.Now;
            bk_image.Clear();
            bk_image_photo.Image = null;
        }

    

        public bool Is_id_exist(string bid)
        {

            using (SqlConnection con = new SqlConnection(con_string))
            {
                using (SqlCommand cmd = new SqlCommand("sp_book_unique", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bk_id", bid);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void btn_show_user_Click(object sender, EventArgs e)
        {
            Book_Search bs = new Book_Search();
            bs.Show();
            this.Hide();
        }

        private void btn_add_bk_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (op.ShowDialog() == DialogResult.OK)
            {
                string image_file_path = op.FileName;
                string target_folder = @"C:\Users\DELL\OneDrive\Desktop\Book_Folder";
                string image_file_name = Path.GetFileName(image_file_path);

                if (!Directory.Exists(target_folder))
                {
                    Directory.CreateDirectory(target_folder);
                }

                string Final_path = Path.Combine(target_folder, image_file_name);

                if (!File.Exists(Final_path))
                {
                    File.Copy(image_file_path, Final_path);
                }

                bk_image_photo.Image = Image.FromFile(Final_path);
                bk_image_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                bk_image.Text = image_file_name;
            }


            string bid = txt_bk_id.Text.Trim();
            string btitle = txt_bk_title.Text.Trim();
            string bauthor = txt_bk_author.Text.Trim();
            string bprice = txt_bk_price.Text.Trim();
            string bquantity = txt_bk_quanity.Text.Trim();
            string bdate = txt_bk_date.Text.Trim();
            string bdatetime = label10.Text.Trim();
            string bimage = bk_image.Text.Trim();

            if (string.IsNullOrWhiteSpace(bid) || string.IsNullOrWhiteSpace(btitle) ||
                string.IsNullOrWhiteSpace(bauthor) || string.IsNullOrWhiteSpace(bprice) ||
                string.IsNullOrWhiteSpace(bquantity) || string.IsNullOrWhiteSpace(bdate) ||
                string.IsNullOrWhiteSpace(bimage))
            {
                MessageBox.Show("All feilds are required!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    if (Is_id_exist(bid))
                    {
                        MessageBox.Show("Book ID is already exists!", "Duplicate Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    else
                    {
                        MessageBox.Show("Ok", "Successfull Message", MessageBoxButtons.OK);

                        using (SqlCommand cmd = new SqlCommand("sp_book_insert", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@bk_id", bid);
                            cmd.Parameters.AddWithValue("@bk_title", btitle);
                            cmd.Parameters.AddWithValue("@bk_author", bauthor);
                            cmd.Parameters.AddWithValue("@bk_price", bprice);
                            cmd.Parameters.AddWithValue("@bk_quantity", bquantity);
                            cmd.Parameters.AddWithValue("@bk_date", bdate);
                            cmd.Parameters.AddWithValue("@bk_datetime", bdatetime);
                            cmd.Parameters.AddWithValue("@bk_image", bimage);

                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows > 0 ? "Book inserted successfully."
                                : "Book insert failed.!");
                        }
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
    }
}
