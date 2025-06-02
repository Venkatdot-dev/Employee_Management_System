namespace Book_Store_Project
{
    partial class Book_add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_add));
            this.bk_date_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lnk_back = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.bk_image_photo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_bk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_show_user = new Guna.UI2.WinForms.Guna2Button();
            this.txt_bk_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bk_image = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_author = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bk_quanity = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bk_image_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // bk_date_time
            // 
            this.bk_date_time.AutoSize = true;
            this.bk_date_time.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.bk_date_time.Location = new System.Drawing.Point(727, 154);
            this.bk_date_time.Name = "bk_date_time";
            this.bk_date_time.Size = new System.Drawing.Size(164, 22);
            this.bk_date_time.TabIndex = 45;
            this.bk_date_time.Text = "**************";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 22);
            this.label10.TabIndex = 44;
            this.label10.Text = "***************";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(616, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "TIME     :";
            // 
            // lnk_back
            // 
            this.lnk_back.AutoSize = true;
            this.lnk_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_back.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lnk_back.Location = new System.Drawing.Point(890, 44);
            this.lnk_back.Name = "lnk_back";
            this.lnk_back.Size = new System.Drawing.Size(65, 27);
            this.lnk_back.TabIndex = 39;
            this.lnk_back.TabStop = true;
            this.lnk_back.Text = "Back";
            this.lnk_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_back_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(458, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 34);
            this.label8.TabIndex = 42;
            this.label8.Text = "BOOK ADD";
            // 
            // bk_image_photo
            // 
            this.bk_image_photo.BackColor = System.Drawing.Color.Gainsboro;
            this.bk_image_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bk_image_photo.Location = new System.Drawing.Point(621, 255);
            this.bk_image_photo.Name = "bk_image_photo";
            this.bk_image_photo.Size = new System.Drawing.Size(334, 311);
            this.bk_image_photo.TabIndex = 41;
            this.bk_image_photo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(727, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "BOOK IMAGE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(89, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "BOOK TITLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(88, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "BOOK AUTHOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(89, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "BOOK PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "BOOK QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "BOOK DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "BOOK ID";
            // 
            // btn_add_bk
            // 
            this.btn_add_bk.Animated = true;
            this.btn_add_bk.BorderRadius = 19;
            this.btn_add_bk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_bk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_bk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_bk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_bk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_bk.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_add_bk.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_add_bk.ForeColor = System.Drawing.Color.White;
            this.btn_add_bk.Location = new System.Drawing.Point(86, 596);
            this.btn_add_bk.Name = "btn_add_bk";
            this.btn_add_bk.Size = new System.Drawing.Size(119, 45);
            this.btn_add_bk.TabIndex = 64;
            this.btn_add_bk.Text = "ADD";
            this.btn_add_bk.Click += new System.EventHandler(this.btn_add_bk_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.BorderRadius = 19;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(232, 596);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 45);
            this.btn_clear.TabIndex = 65;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_show_user
            // 
            this.btn_show_user.Animated = true;
            this.btn_show_user.BorderRadius = 19;
            this.btn_show_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show_user.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_show_user.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_show_user.ForeColor = System.Drawing.Color.White;
            this.btn_show_user.Location = new System.Drawing.Point(379, 596);
            this.btn_show_user.Name = "btn_show_user";
            this.btn_show_user.Size = new System.Drawing.Size(155, 45);
            this.btn_show_user.TabIndex = 66;
            this.btn_show_user.Text = "SHOW USER";
            this.btn_show_user.Click += new System.EventHandler(this.btn_show_user_Click);
            // 
            // txt_bk_date
            // 
            this.txt_bk_date.BorderRadius = 19;
            this.txt_bk_date.Checked = true;
            this.txt_bk_date.FillColor = System.Drawing.Color.Black;
            this.txt_bk_date.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_bk_date.ForeColor = System.Drawing.Color.White;
            this.txt_bk_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_bk_date.Location = new System.Drawing.Point(276, 521);
            this.txt_bk_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_bk_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_bk_date.Name = "txt_bk_date";
            this.txt_bk_date.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_date.TabIndex = 77;
            this.txt_bk_date.Value = new System.DateTime(2025, 4, 26, 16, 18, 22, 16);
            // 
            // bk_image
            // 
            this.bk_image.BorderColor = System.Drawing.Color.DarkGray;
            this.bk_image.BorderRadius = 19;
            this.bk_image.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bk_image.DefaultText = "";
            this.bk_image.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bk_image.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bk_image.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bk_image.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bk_image.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bk_image.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_image.ForeColor = System.Drawing.Color.Black;
            this.bk_image.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bk_image.Location = new System.Drawing.Point(665, 596);
            this.bk_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bk_image.Name = "bk_image";
            this.bk_image.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bk_image.PlaceholderText = "";
            this.bk_image.SelectedText = "";
            this.bk_image.Size = new System.Drawing.Size(258, 45);
            this.bk_image.TabIndex = 79;
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
            this.txt_bk_id.Location = new System.Drawing.Point(276, 131);
            this.txt_bk_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_id.Name = "txt_bk_id";
            this.txt_bk_id.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_id.PlaceholderText = "";
            this.txt_bk_id.SelectedText = "";
            this.txt_bk_id.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_id.TabIndex = 80;
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
            this.txt_bk_title.Location = new System.Drawing.Point(276, 213);
            this.txt_bk_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_title.Name = "txt_bk_title";
            this.txt_bk_title.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_title.PlaceholderText = "";
            this.txt_bk_title.SelectedText = "";
            this.txt_bk_title.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_title.TabIndex = 81;
            // 
            // txt_bk_author
            // 
            this.txt_bk_author.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_bk_author.BorderRadius = 19;
            this.txt_bk_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bk_author.DefaultText = "";
            this.txt_bk_author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bk_author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bk_author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bk_author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_author.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bk_author.ForeColor = System.Drawing.Color.Black;
            this.txt_bk_author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bk_author.Location = new System.Drawing.Point(276, 281);
            this.txt_bk_author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_author.Name = "txt_bk_author";
            this.txt_bk_author.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_author.PlaceholderText = "";
            this.txt_bk_author.SelectedText = "";
            this.txt_bk_author.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_author.TabIndex = 82;
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
            this.txt_bk_price.Location = new System.Drawing.Point(276, 361);
            this.txt_bk_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_price.Name = "txt_bk_price";
            this.txt_bk_price.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_price.PlaceholderText = "";
            this.txt_bk_price.SelectedText = "";
            this.txt_bk_price.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_price.TabIndex = 83;
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
            this.txt_bk_quanity.Location = new System.Drawing.Point(276, 443);
            this.txt_bk_quanity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bk_quanity.Name = "txt_bk_quanity";
            this.txt_bk_quanity.PlaceholderForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bk_quanity.PlaceholderText = "";
            this.txt_bk_quanity.SelectedText = "";
            this.txt_bk_quanity.Size = new System.Drawing.Size(258, 45);
            this.txt_bk_quanity.TabIndex = 84;
            // 
            // Book_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 670);
            this.Controls.Add(this.txt_bk_quanity);
            this.Controls.Add(this.txt_bk_price);
            this.Controls.Add(this.txt_bk_author);
            this.Controls.Add(this.txt_bk_title);
            this.Controls.Add(this.txt_bk_id);
            this.Controls.Add(this.bk_image);
            this.Controls.Add(this.txt_bk_date);
            this.Controls.Add(this.btn_show_user);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_bk);
            this.Controls.Add(this.bk_date_time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lnk_back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bk_image_photo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_add";
            ((System.ComponentModel.ISupportInitialize)(this.bk_image_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bk_date_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lnk_back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox bk_image_photo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_add_bk;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_show_user;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_bk_date;
        private Guna.UI2.WinForms.Guna2TextBox bk_image;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_title;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_author;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_bk_quanity;
    }
}