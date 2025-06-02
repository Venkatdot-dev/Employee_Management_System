using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Project
{
    public partial class Book_Search : Form
    {
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;
        public Book_Search()
        {
            InitializeComponent();
            Load_Data();
            load_sys_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        public void Load_Data()
        {
            string target_folder = @"C:\Users\DELL\OneDrive\Desktop\Book_Folder";

            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_book_get_all", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            DataTable new_tbl = new DataTable();
                            new_tbl.Columns.Add("BOOK ID");
                            new_tbl.Columns.Add("Title");
                            new_tbl.Columns.Add("Author");
                            new_tbl.Columns.Add("Price");
                            new_tbl.Columns.Add("Quantity");
                            new_tbl.Columns.Add("Date");
                            new_tbl.Columns.Add("Insert Date Time");
                            new_tbl.Columns.Add("Image Name");
                            new_tbl.Columns.Add("Image", typeof(Image));


                            foreach (DataRow row in dt.Rows)
                            {
                                string file_name = row["bk_image"].ToString();
                                string image_file_path = Path.Combine(target_folder, file_name);

                                Image img = null;

                                if (File.Exists(image_file_path))
                                {
                                    using (var file_img = new FileStream(image_file_path, FileMode.Open, FileAccess.Read))
                                    {
                                        img = Image.FromStream(file_img);
                                    }
                                }

                                new_tbl.Rows.Add(
                                    row["bk_id"].ToString(),
                                    row["bk_title"].ToString(),
                                    row["bk_author"].ToString(),
                                    row["bk_price"].ToString(),
                                    row["bk_quantity"].ToString(),
                                    row["bk_date"].ToString(),
                                    row["bk_datetime"].ToString(),
                                    row["bk_image"].ToString(),
                                    img
                                );
                            }
                            show_data.DataSource = new_tbl;

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Book_add ba = new Book_add();
            ba.Show();
            this.Hide();
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

     


        private void btn_search_Click(object sender, EventArgs e)
        {
            string bid1 = txt_bk_id.Text.Trim();

            if (string.IsNullOrWhiteSpace(bid1))
            {
                MessageBox.Show("ID required!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_book_get_by_id", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bk_id", bid1);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txt_bk_id.Text = reader["bk_id"].ToString();
                            txt_bk_title.Text = reader["bk_title"].ToString();
                            txt_bk_author.Text = reader["bk_author"].ToString();
                            txt_bk_price.Text = reader["bk_price"].ToString();
                            txt_bk_quanity.Text = reader["bk_quantity"].ToString();
                            bk_image.Text = reader["bk_image"].ToString();

                            string DB_date = reader["bk_date"].ToString();

                            if (DateTime.TryParse(DB_date, out DateTime paresedDte))
                            {
                                txt_bk_date.Value = paresedDte;
                            }

                            load_sys_time.Text = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt");

                            string target_folder = @"C:\Users\DELL\OneDrive\Desktop\Book_Folder";

                            string file_name = reader["bk_image"].ToString();
                            string image_file_path = Path.Combine(target_folder, file_name);

                            Image img = null;

                            if (File.Exists(image_file_path))
                            {
                                using (var file_img = new FileStream(image_file_path
                                    , FileMode.Open, FileAccess.Read))
                                {
                                    bk_image_photo.Image = Image.FromStream(file_img);
                                    bk_image_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                bk_image_photo.Image = null;
                            }
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

        private void btn_edit_Click(object sender, EventArgs e)
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
            string bdatetime = load_sys_time.Text.Trim();
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
                    using (SqlCommand cmd = new SqlCommand("sp_book_update", con))
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
                        MessageBox.Show(rows > 0 ? "Book Updated successfully."
                            : "Book Updation failed.!");
                        Load_Data();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_bk_id.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var confirm_msg = MessageBox.Show("Are you sure , want to delete this user?", "Confirm Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_msg != DialogResult.Yes) return;
                using (SqlConnection con = new SqlConnection(con_string))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_book_delete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bk_id", id);

                        int rows = cmd.ExecuteNonQuery();
                        clear();
                        Load_Data();
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

     
    }
}
