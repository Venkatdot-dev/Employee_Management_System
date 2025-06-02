namespace Book_Store_Project
{
    partial class Book_Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Bill));
            this.show_bill_data = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.bill_datetime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.show_book_data = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_bk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_bk_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_quanity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_pdf = new Guna.UI2.WinForms.Guna2Button();
            this.bt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_get_bill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_fetch_data = new Guna.UI2.WinForms.Guna2Button();
            this.txt_grand_tot = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bill_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_cust_name = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_bill_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_book_data)).BeginInit();
            this.SuspendLayout();
            // 
            // show_bill_data
            // 
            this.show_bill_data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.show_bill_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_bill_data.Location = new System.Drawing.Point(31, 516);
            this.show_bill_data.Name = "show_bill_data";
            this.show_bill_data.RowHeadersWidth = 62;
            this.show_bill_data.RowTemplate.Height = 28;
            this.show_bill_data.Size = new System.Drawing.Size(732, 213);
            this.show_bill_data.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(846, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 76;
            this.label9.Text = "GRAND TOTAL";
            // 
            // bill_datetime
            // 
            this.bill_datetime.AutoSize = true;
            this.bill_datetime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.bill_datetime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bill_datetime.Location = new System.Drawing.Point(1041, 272);
            this.bill_datetime.Name = "bill_datetime";
            this.bill_datetime.Size = new System.Drawing.Size(230, 22);
            this.bill_datetime.TabIndex = 70;
            this.bill_datetime.Text = "********************";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(846, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 22);
            this.label8.TabIndex = 69;
            this.label8.Text = "DATE TIME      :";
            // 
            // show_book_data
            // 
            this.show_book_data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.show_book_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_book_data.Location = new System.Drawing.Point(546, 27);
            this.show_book_data.Name = "show_book_data";
            this.show_book_data.RowHeadersWidth = 62;
            this.show_book_data.RowTemplate.Height = 28;
            this.show_book_data.Size = new System.Drawing.Size(720, 213);
            this.show_book_data.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(27, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 67;
            this.label7.Text = "BOOK TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(27, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "BOOK STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(27, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "BOOK TITLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(27, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "BOOK PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "BOOK QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "BOOK ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "BOOKS";
            // 
            // cmb_bk
            // 
            this.cmb_bk.BackColor = System.Drawing.Color.Transparent;
            this.cmb_bk.BorderColor = System.Drawing.Color.Gray;
            this.cmb_bk.BorderRadius = 19;
            this.cmb_bk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_bk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_bk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_bk.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_bk.ForeColor = System.Drawing.Color.Black;
            this.cmb_bk.ItemHeight = 42;
            this.cmb_bk.Items.AddRange(new object[] {
            "--SELECT BOOKS----"});
            this.cmb_bk.Location = new System.Drawing.Point(208, 12);
            this.cmb_bk.Name = "cmb_bk";
            this.cmb_bk.Size = new System.Drawing.Size(258, 48);
            this.cmb_bk.TabIndex = 86;
            this.cmb_bk.SelectedIndexChanged += new System.EventHandler(this.cmb_bk_SelectedIndexChanged);
            // 
            // txt_bk_id
            // 
            this.txt_bk_id.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_id.BorderRadius = 19;
            this.txt_bk_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_id.DefaultText = "";
            this.txt_bk_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_id.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_id.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_id.Location = new System.Drawing.Point(208, 86);
            this.txt_bk_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_id.Name = "txt_bk_id";
            this.txt_bk_id.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_id.PlaceholderText = "";
            this.txt_bk_id.SelectedText = "";
            this.txt_bk_id.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_id.TabIndex = 87;
            // 
            // txt_bk_title
            // 
            this.txt_bk_title.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_title.BorderRadius = 19;
            this.txt_bk_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_title.DefaultText = "";
            this.txt_bk_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_title.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_title.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_title.Location = new System.Drawing.Point(208, 154);
            this.txt_bk_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_title.Name = "txt_bk_title";
            this.txt_bk_title.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_title.PlaceholderText = "";
            this.txt_bk_title.SelectedText = "";
            this.txt_bk_title.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_title.TabIndex = 88;
            // 
            // txt_bk_price
            // 
            this.txt_bk_price.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_price.BorderRadius = 19;
            this.txt_bk_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_price.DefaultText = "";
            this.txt_bk_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_price.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_price.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_price.Location = new System.Drawing.Point(208, 227);
            this.txt_bk_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_price.Name = "txt_bk_price";
            this.txt_bk_price.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_price.PlaceholderText = "";
            this.txt_bk_price.SelectedText = "";
            this.txt_bk_price.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_price.TabIndex = 89;
            // 
            // txt_bk_stock
            // 
            this.txt_bk_stock.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_stock.BorderRadius = 19;
            this.txt_bk_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_stock.DefaultText = "";
            this.txt_bk_stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_stock.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_stock.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_stock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_stock.Location = new System.Drawing.Point(208, 292);
            this.txt_bk_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_stock.Name = "txt_bk_stock";
            this.txt_bk_stock.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_stock.PlaceholderText = "";
            this.txt_bk_stock.SelectedText = "";
            this.txt_bk_stock.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_stock.TabIndex = 90;
            // 
            // txt_bk_total
            // 
            this.txt_bk_total.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_total.BorderRadius = 19;
            this.txt_bk_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_total.DefaultText = "";
            this.txt_bk_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_total.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_total.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_total.Location = new System.Drawing.Point(208, 436);
            this.txt_bk_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_total.Name = "txt_bk_total";
            this.txt_bk_total.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_total.PlaceholderText = "";
            this.txt_bk_total.SelectedText = "";
            this.txt_bk_total.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_total.TabIndex = 91;
            // 
            // txt_bk_quanity
            // 
            this.txt_bk_quanity.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_quanity.BorderRadius = 19;
            this.txt_bk_quanity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_quanity.DefaultText = "";
            this.txt_bk_quanity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_quanity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_quanity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_quanity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_quanity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_quanity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_quanity.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_quanity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_quanity.Location = new System.Drawing.Point(208, 363);
            this.txt_bk_quanity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_quanity.Name = "txt_bk_quanity";
            this.txt_bk_quanity.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_quanity.PlaceholderText = "";
            this.txt_bk_quanity.SelectedText = "";
            this.txt_bk_quanity.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_quanity.TabIndex = 92;
            this.txt_bk_quanity.TextChanged += new System.EventHandler(this.txt_bk_quanity_TextChanged);
            this.txt_bk_quanity.Leave += new System.EventHandler(this.txt_bk_quanity_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(906, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 94;
            this.label12.Text = "BILL ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(824, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 22);
            this.label11.TabIndex = 96;
            this.label11.Text = "CUSTOMER NAME";
            // 
            // btn_pdf
            // 
            this.btn_pdf.Animated = true;
            this.btn_pdf.BorderRadius = 19;
            this.btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pdf.FillColor = System.Drawing.Color.Red;
            this.btn_pdf.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Location = new System.Drawing.Point(797, 649);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(128, 45);
            this.btn_pdf.TabIndex = 100;
            this.btn_pdf.Text = "PDF";
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // bt
            // 
            this.bt.Animated = true;
            this.bt.BorderRadius = 19;
            this.bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bt.ForeColor = System.Drawing.Color.White;
            this.bt.Location = new System.Drawing.Point(1132, 548);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(128, 45);
            this.bt.TabIndex = 99;
            this.bt.Text = "CLEAR";
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Animated = true;
            this.btn_excel.BorderRadius = 19;
            this.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_excel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_excel.FillColor = System.Drawing.Color.Green;
            this.btn_excel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_excel.ForeColor = System.Drawing.Color.White;
            this.btn_excel.Location = new System.Drawing.Point(970, 649);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(128, 45);
            this.btn_excel.TabIndex = 98;
            this.btn_excel.Text = "EXCEL";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_get_bill
            // 
            this.btn_get_bill.Animated = true;
            this.btn_get_bill.BorderRadius = 19;
            this.btn_get_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_get_bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_get_bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_get_bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_get_bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_get_bill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_get_bill.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_get_bill.ForeColor = System.Drawing.Color.White;
            this.btn_get_bill.Location = new System.Drawing.Point(970, 548);
            this.btn_get_bill.Name = "btn_get_bill";
            this.btn_get_bill.Size = new System.Drawing.Size(128, 45);
            this.btn_get_bill.TabIndex = 102;
            this.btn_get_bill.Text = "GET BILL";
            this.btn_get_bill.Click += new System.EventHandler(this.btn_get_bill_Click);
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.BorderRadius = 19;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(1132, 649);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 45);
            this.btn_back.TabIndex = 105;
            this.btn_back.Text = "BACK";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_fetch_data
            // 
            this.btn_fetch_data.Animated = true;
            this.btn_fetch_data.BorderRadius = 19;
            this.btn_fetch_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fetch_data.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fetch_data.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fetch_data.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fetch_data.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fetch_data.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_fetch_data.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_fetch_data.ForeColor = System.Drawing.Color.White;
            this.btn_fetch_data.Location = new System.Drawing.Point(797, 548);
            this.btn_fetch_data.Name = "btn_fetch_data";
            this.btn_fetch_data.Size = new System.Drawing.Size(143, 45);
            this.btn_fetch_data.TabIndex = 106;
            this.btn_fetch_data.Text = "FETCH DATA";
            this.btn_fetch_data.Click += new System.EventHandler(this.btn_fetch_data_Click);
            // 
            // txt_grand_tot
            // 
            this.txt_grand_tot.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_grand_tot.BorderRadius = 19;
            this.txt_grand_tot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_grand_tot.DefaultText = "";
            this.txt_grand_tot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_grand_tot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_grand_tot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_grand_tot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_grand_tot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_grand_tot.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grand_tot.ForeColor = System.Drawing.Color.Black;
            this.txt_grand_tot.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_grand_tot.Location = new System.Drawing.Point(1035, 315);
            this.txt_grand_tot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_grand_tot.Name = "txt_grand_tot";
            this.txt_grand_tot.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_grand_tot.PlaceholderText = "";
            this.txt_grand_tot.ReadOnly = true;
            this.txt_grand_tot.SelectedText = "";
            this.txt_grand_tot.Size = new System.Drawing.Size(236, 45);
            this.txt_grand_tot.TabIndex = 110;
            // 
            // txt_bill_id
            // 
            this.txt_bill_id.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bill_id.BorderRadius = 19;
            this.txt_bill_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bill_id.DefaultText = "";
            this.txt_bill_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bill_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bill_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bill_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bill_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bill_id.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_id.ForeColor = System.Drawing.Color.Black;
            this.txt_bill_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bill_id.Location = new System.Drawing.Point(1035, 373);
            this.txt_bill_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bill_id.Name = "txt_bill_id";
            this.txt_bill_id.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bill_id.PlaceholderText = "";
            this.txt_bill_id.SelectedText = "";
            this.txt_bill_id.Size = new System.Drawing.Size(236, 45);
            this.txt_bill_id.TabIndex = 111;
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_cust_name.BorderRadius = 19;
            this.txt_cust_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cust_name.DefaultText = "";
            this.txt_cust_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cust_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cust_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cust_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cust_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cust_name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_name.ForeColor = System.Drawing.Color.Black;
            this.txt_cust_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cust_name.Location = new System.Drawing.Point(1035, 436);
            this.txt_cust_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cust_name.PlaceholderText = "";
            this.txt_cust_name.SelectedText = "";
            this.txt_cust_name.Size = new System.Drawing.Size(236, 45);
            this.txt_cust_name.TabIndex = 112;
            // 
            // Book_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 756);
            this.Controls.Add(this.txt_cust_name);
            this.Controls.Add(this.txt_bill_id);
            this.Controls.Add(this.txt_grand_tot);
            this.Controls.Add(this.btn_fetch_data);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_get_bill);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_bk_quanity);
            this.Controls.Add(this.txt_bk_total);
            this.Controls.Add(this.txt_bk_stock);
            this.Controls.Add(this.txt_bk_price);
            this.Controls.Add(this.txt_bk_title);
            this.Controls.Add(this.txt_bk_id);
            this.Controls.Add(this.cmb_bk);
            this.Controls.Add(this.show_bill_data);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bill_datetime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.show_book_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Bill";
            ((System.ComponentModel.ISupportInitialize)(this.show_bill_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_book_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView show_bill_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bill_datetime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView show_book_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_bk;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_title;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_stock;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_total;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_quanity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btn_pdf;
        private Guna.UI2.WinForms.Guna2Button bt;
        private Guna.UI2.WinForms.Guna2Button btn_excel;
        private Guna.UI2.WinForms.Guna2Button btn_get_bill;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_fetch_data;
        private Guna.UI2.WinForms.Guna2TextBox txt_grand_tot;
        private Guna.UI2.WinForms.Guna2TextBox txt_bill_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_cust_name;
    }
}