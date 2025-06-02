using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Excel = Microsoft.Office.Interop.Excel; 

using DrawingFont = System.Drawing.Font;

namespace Book_Store_Project
{
    public partial class Book_Bill : Form
    {
        string book_id;
        string total;
        private string con_string = ConfigurationManager.ConnectionStrings["book_store_db_con"].ConnectionString;
        public Book_Bill()
        {
            InitializeComponent();
            bill_datetime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Book_Load();
            HeadingData();
        }


        public void HeadingData()
        {
            show_book_data.Columns.Clear();

            show_book_data.Columns.Add("BooK ID", "Book ID");
            show_book_data.Columns.Add("Book Title", "Book Title");
            show_book_data.Columns.Add("Price", "Price");
            show_book_data.Columns.Add("Quantity", "Quantity");
            show_book_data.Columns.Add("Total", "Total");
        }

        public void Book_Load()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_book_get_all", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader read = cmd.ExecuteReader();

                        while (read.Read())
                        {
                            cmb_bk.Items.Add(read["bk_id"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Con error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_bk_quanity_Leave(object sender, EventArgs e)
        {
            int bk_quantity = int.Parse(txt_bk_quanity.Text);
            int bk_stock = int.Parse(txt_bk_stock.Text);

            if (bk_quantity > bk_stock)
            {
                MessageBox.Show("Out of Stock");
                return;
            }

            double bk_price = double.Parse(txt_bk_price.Text);
            double bk_total = bk_price * bk_quantity;

            txt_bk_total.Text = bk_total.ToString();

            show_book_data.Rows.Add(
                txt_bk_id.Text,
                txt_bk_title.Text,
                txt_bk_price.Text,
                txt_bk_quanity.Text,
                bk_total.ToString()
            );

            Calculate_Total();
            Calculate_Totall();
           
        }

        private void Calculate_Total()
        {
            double total = 0;

            foreach (DataGridViewRow row in show_book_data.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["Total"].Value;
                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double value))
                    {
                        total += value;
                    }
                }
            }

            txt_grand_tot.Text = total.ToString();
            txt_grand_tot.ReadOnly = true;
        }

        private void Clear_Feild()
        {
            txt_bill_id.Clear();
            txt_bk_id.Clear();
            txt_bk_price.Clear();
            txt_bk_quanity.Clear();
            txt_bk_stock.Clear();
            txt_bk_total.Clear();
            txt_bk_title.Clear();
            txt_grand_tot.Clear();
            txt_cust_name.Clear();
            cmb_bk.SelectedIndex = 0;
            show_book_data.Rows.Clear();
            show_book_data.Columns.Clear();
        }

        

        private void bt_Click(object sender, EventArgs e)
        {
            Clear_Feild();
        }


        private void cmb_bk_SelectedIndexChanged(object sender, EventArgs e)
        {

            string bid1 = cmb_bk.SelectedItem.ToString();

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
                            bid1 = reader["bk_id"].ToString();
                            txt_bk_id.Text = bid1;
                            txt_bk_id.ReadOnly = true;
                            txt_bk_title.Text = reader["bk_title"].ToString();
                            txt_bk_stock.Text = reader["bk_quantity"].ToString();
                            txt_bk_price.Text = reader["bk_price"].ToString();
                            txt_bk_price.ReadOnly = true;
                            txt_bk_stock.ReadOnly = true;
                            txt_bk_title.ReadOnly = true;
                        }
                        if (cmb_bk.SelectedIndex == 0)
                        {
                            txt_bk_price.Clear();
                            txt_bk_stock.Clear();
                            txt_bk_title.Clear();
                            txt_bk_id.Clear();
                            txt_bk_quanity.Clear();
                            txt_bk_total.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Con error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Book_Store bs = new Book_Store();
            bs.Show();
            this.Hide();
        }

        private void btn_get_bill_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_bill_id.Text) || 
                string.IsNullOrEmpty(txt_cust_name.Text) || 
                string.IsNullOrEmpty(txt_grand_tot.Text))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string bill_id = txt_bill_id.Text.Trim();
            string cust_name = txt_cust_name.Text.Trim();
            string grand_tot = txt_grand_tot.Text.Trim();
            string bill_date = bill_datetime.Text.Trim();

            using (SqlConnection con = new SqlConnection(con_string))
            {
              con.Open();


                if(Is_id_exsit(bill_id))
                {
                    MessageBox.Show("Bill ID already exist", "Duplicate Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Ok" , "Billing" , MessageBoxButtons.OK);

                    SqlCommand bill_cmd = new SqlCommand("sp_bill_insert", con);
                    bill_cmd.CommandType = CommandType.StoredProcedure;


                    bill_cmd.Parameters.AddWithValue("@bill_id", bill_id);
                    bill_cmd.Parameters.AddWithValue("@customer_name", cust_name);
                    bill_cmd.Parameters.AddWithValue("@total_amt", grand_tot);
                    bill_cmd.Parameters.AddWithValue("@bill_datetime", bill_date);
                    bill_cmd.ExecuteNonQuery();


                    foreach(DataGridViewRow row in show_book_data.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string bk_id = row.Cells[0].Value.ToString();
                        string bk_quantity = row.Cells[3].Value.ToString();
                        string bk_price = row.Cells[2].Value.ToString();
                        string bk_total = row.Cells[4].Value.ToString();

                        string bill_details_id = Guid.NewGuid().ToString();


                        SqlCommand details_cmd = new SqlCommand("sp_bill_details_insert", con);
                        details_cmd.CommandType = CommandType.StoredProcedure;

                        details_cmd.Parameters.AddWithValue("@bill_details_id", bill_details_id);
                        details_cmd.Parameters.AddWithValue("@bill_id", bill_id);
                        details_cmd.Parameters.AddWithValue("@bk_id", bk_id);
                        details_cmd.Parameters.AddWithValue("@bill_price", bk_price);
                        details_cmd.Parameters.AddWithValue("@bill_quantity", bk_quantity);
                        details_cmd.Parameters.AddWithValue("@bill_total", bk_total);
                        details_cmd.ExecuteNonQuery();


                        SqlCommand stock_cmd = new SqlCommand("sp_book_stock", con);
                        stock_cmd.CommandType = CommandType.StoredProcedure;

                        stock_cmd.Parameters.AddWithValue("@bk_id", bk_id);
                        stock_cmd.Parameters.AddWithValue("@bk_quantity", bk_quantity);
                        stock_cmd.ExecuteNonQuery();
                    }

                        MessageBox.Show("Bill Saved Successfully");
                     //Clear_Feild();
                }
            }
        }
        public bool Is_id_exsit(string bill_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_bill_unique", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bill_id", bill_id);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Con error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_fetch_data_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con_string);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_bill_fecth", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            show_bill_data.DataSource = ds.Tables[0];
            conn.Close();


            Calculate_Totall();
            Total_amt();
        }


        private void btn_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_file = new SaveFileDialog();
            save_file.Filter = "PDF Files (*.pdf)|*.pdf";
            save_file.Title = "Save Bill as PDF";
            save_file.FileName = "Bill_" + book_id + ".pdf";

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4 , 10f ,10f , 10f , 10f);
                PdfWriter.GetInstance(doc, new FileStream(save_file.FileName, FileMode.Create));
                doc.Open();

                var boldfont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD,14);
                var normalfont = FontFactory.GetFont(FontFactory.HELVETICA, 11);


                Paragraph heading  =  new Paragraph("BOOK STORE BILL" , boldfont);


                heading.Alignment = Element.ALIGN_CENTER;

                doc.Add(heading);
                doc.Add(new Paragraph("\n"));

                string bookId = show_bill_data.CurrentRow.Cells[0].Value.ToString();
                string cus_name = show_bill_data.CurrentRow.Cells[1].Value.ToString();
                total = show_bill_data.CurrentRow.Cells[2].Value.ToString();


                doc.Add(new Paragraph("Bill ID :" + bookId, normalfont));  
                doc.Add(new Paragraph("Date  :" + bill_datetime.Text, normalfont));
                doc.Add(new Paragraph("Customer Name :" + cus_name, normalfont));
                
                doc.Add(new Paragraph("\n"));

                PdfPTable tbl = new PdfPTable(show_bill_data.Columns.Count);
                tbl.WidthPercentage = 100;

                foreach(DataGridViewColumn clm  in show_bill_data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(clm.HeaderText,boldfont));
                    tbl.AddCell(cell);
                }

                foreach (DataGridViewRow row in show_bill_data.Rows)
                {
                    if(!row.IsNewRow)
                    {
                        foreach(DataGridViewCell cell in row.Cells)
                        {
                            string value =  cell.Value?.ToString() ?? "";
                            tbl.AddCell(new Phrase(value,normalfont));
                        }
                    }
                }

                doc.Add(tbl);
                Calculate_Totall();
                doc.Add(new Paragraph("\n Total Amount : Rs." + total,boldfont));
                doc.Close();

                MessageBox.Show("PDF Exported Successfully");
            }
        }

        private void txt_bk_quanity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Totall()
        {
            double totall = 0;

            foreach (DataGridViewRow row in show_bill_data.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["total_amt"].Value;
                    if (cellValue != null)
                    {
                        string cellString = cellValue.ToString().Replace(",", "").Replace("₹", "").Trim();

                        if (double.TryParse(cellString, out double value))
                        {
                            totall += value;
                        }
                    }
                }
            }

            total = totall.ToString("0.00");  
            
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook  |*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "Bill_" + txt_bill_id.Text + ".xlsx";

            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel_app = new Excel.Application();
                Excel.Workbook work_bk = excel_app.Workbooks.Add();
                Excel.Workbook work_bk1 = work_bk;
                Excel._Worksheet work_sheet = (Excel._Worksheet)work_bk1.Sheets[1];
                work_sheet.Name = "Bill";



                string bookId = show_bill_data.CurrentRow.Cells[0].Value.ToString();
                string cus_name = show_bill_data.CurrentRow.Cells[1].Value.ToString();
                string date = show_bill_data.CurrentRow.Cells[3].Value.ToString();  
                total = show_bill_data.CurrentRow.Cells[2].Value.ToString();


                work_sheet.Cells[1, 3] = "BOOK STORE BILL";
                work_sheet.Cells[2, 1] = "Bill ID :";
                work_sheet.Cells[2, 2] = bookId;
                work_sheet.Cells[3, 1] = "Date :";
                work_sheet.Cells[3, 2] = date;
                work_sheet.Cells[4, 1]  = "Customer :";
                work_sheet.Cells[4,2] = cus_name; 


                for(int i = 0; i < show_bill_data.Rows.Count; i++)
                {
                    for(int j = 0; j < show_bill_data.Columns.Count; j++)
                    {
                        work_sheet.Cells[i + 7, j +1] = show_bill_data.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                Total_amt();
                work_sheet.Cells[show_bill_data.Rows.Count + 8, 1] = "Total Amount : ";
                work_sheet.Cells[show_bill_data.Rows.Count + 8, 2] = total;
                work_sheet.SaveAs(saveFileDialog.FileName);
                excel_app.Quit();


                MessageBox.Show("Excel exported Successfully");
            }
        }
        private void Total_amt()
        {
            double total_amt = 0;

            foreach (DataGridViewRow row in show_bill_data.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["total_amt"].Value;
                    if (cellValue != null)
                    {
                        string cellString = cellValue.ToString().Replace(",", "").Replace("₹", "").Trim();

                        if (double.TryParse(cellString, out double value))
                        {
                            total_amt += value;
                        }
                    }
                }
            }

            total = total_amt.ToString("0.00");

        }
    }

}
