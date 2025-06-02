namespace Calculator_Window_Project
{
    partial class Calculator_Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator_Win));
            this.cal_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_minus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_divide = new Guna.UI2.WinForms.Guna2Button();
            this.btn_del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sqrt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_8 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_plus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_10 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dott = new Guna.UI2.WinForms.Guna2Button();
            this.btn_equal = new Guna.UI2.WinForms.Guna2Button();
            this.btn_1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_overall = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cal_txt
            // 
            this.cal_txt.Animated = true;
            this.cal_txt.BorderColor = System.Drawing.Color.Black;
            this.cal_txt.BorderRadius = 14;
            this.cal_txt.BorderThickness = 2;
            this.cal_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cal_txt.DefaultText = "";
            this.cal_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cal_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cal_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cal_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cal_txt.FillColor = System.Drawing.Color.Silver;
            this.cal_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cal_txt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_txt.ForeColor = System.Drawing.Color.Black;
            this.cal_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cal_txt.Location = new System.Drawing.Point(36, 88);
            this.cal_txt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cal_txt.Name = "cal_txt";
            this.cal_txt.PlaceholderText = "";
            this.cal_txt.SelectedText = "";
            this.cal_txt.Size = new System.Drawing.Size(417, 77);
            this.cal_txt.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.BorderColor = System.Drawing.Color.LightGray;
            this.btn_clear.BorderRadius = 14;
            this.btn_clear.BorderThickness = 3;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.Crimson;
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(36, 193);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 56);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "CE";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Animated = true;
            this.btn_minus.BorderColor = System.Drawing.Color.LightGray;
            this.btn_minus.BorderRadius = 14;
            this.btn_minus.BorderThickness = 3;
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minus.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_minus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.Black;
            this.btn_minus.Location = new System.Drawing.Point(378, 353);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 56);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_6
            // 
            this.btn_6.Animated = true;
            this.btn_6.BorderColor = System.Drawing.Color.LightGray;
            this.btn_6.BorderRadius = 14;
            this.btn_6.BorderThickness = 2;
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_6.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_6.ForeColor = System.Drawing.Color.Black;
            this.btn_6.Location = new System.Drawing.Point(266, 353);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 56);
            this.btn_6.TabIndex = 3;
            this.btn_6.Text = "6";
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Animated = true;
            this.btn_5.BorderColor = System.Drawing.Color.LightGray;
            this.btn_5.BorderRadius = 14;
            this.btn_5.BorderThickness = 2;
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_5.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.Black;
            this.btn_5.Location = new System.Drawing.Point(153, 353);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 56);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Animated = true;
            this.btn_4.BorderColor = System.Drawing.Color.LightGray;
            this.btn_4.BorderRadius = 14;
            this.btn_4.BorderThickness = 2;
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_4.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.Black;
            this.btn_4.Location = new System.Drawing.Point(36, 353);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 56);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Animated = true;
            this.btn_divide.BorderColor = System.Drawing.Color.LightGray;
            this.btn_divide.BorderRadius = 14;
            this.btn_divide.BorderThickness = 3;
            this.btn_divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_divide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_divide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_divide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_divide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_divide.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_divide.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.ForeColor = System.Drawing.Color.Black;
            this.btn_divide.Location = new System.Drawing.Point(378, 193);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 56);
            this.btn_divide.TabIndex = 6;
            this.btn_divide.Text = "/";
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_del
            // 
            this.btn_del.Animated = true;
            this.btn_del.BorderColor = System.Drawing.Color.LightGray;
            this.btn_del.BorderRadius = 14;
            this.btn_del.BorderThickness = 3;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_del.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_del.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.Black;
            this.btn_del.Location = new System.Drawing.Point(266, 193);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 56);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "DEL";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Animated = true;
            this.btn_sqrt.BorderColor = System.Drawing.Color.LightGray;
            this.btn_sqrt.BorderRadius = 14;
            this.btn_sqrt.BorderThickness = 3;
            this.btn_sqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sqrt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sqrt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sqrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sqrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sqrt.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_sqrt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqrt.ForeColor = System.Drawing.Color.Black;
            this.btn_sqrt.Location = new System.Drawing.Point(153, 193);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(75, 56);
            this.btn_sqrt.TabIndex = 8;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_7
            // 
            this.btn_7.Animated = true;
            this.btn_7.BorderColor = System.Drawing.Color.LightGray;
            this.btn_7.BorderRadius = 14;
            this.btn_7.BorderThickness = 2;
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_7.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.Black;
            this.btn_7.Location = new System.Drawing.Point(36, 273);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 56);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Animated = true;
            this.btn_8.BorderColor = System.Drawing.Color.LightGray;
            this.btn_8.BorderRadius = 14;
            this.btn_8.BorderThickness = 2;
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_8.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.Black;
            this.btn_8.Location = new System.Drawing.Point(153, 273);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 56);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Animated = true;
            this.btn_9.BorderColor = System.Drawing.Color.LightGray;
            this.btn_9.BorderRadius = 14;
            this.btn_9.BorderThickness = 2;
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_9.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.Black;
            this.btn_9.Location = new System.Drawing.Point(266, 273);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 56);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Animated = true;
            this.btn_plus.BorderColor = System.Drawing.Color.LightGray;
            this.btn_plus.BorderRadius = 14;
            this.btn_plus.BorderThickness = 3;
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_plus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_plus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_plus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_plus.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_plus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(378, 432);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 56);
            this.btn_plus.TabIndex = 9;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_10
            // 
            this.btn_10.Animated = true;
            this.btn_10.BorderColor = System.Drawing.Color.LightGray;
            this.btn_10.BorderRadius = 14;
            this.btn_10.BorderThickness = 2;
            this.btn_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_10.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10.ForeColor = System.Drawing.Color.Black;
            this.btn_10.Location = new System.Drawing.Point(36, 512);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(192, 56);
            this.btn_10.TabIndex = 15;
            this.btn_10.Text = "0";
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_dott
            // 
            this.btn_dott.Animated = true;
            this.btn_dott.BorderColor = System.Drawing.Color.LightGray;
            this.btn_dott.BorderRadius = 14;
            this.btn_dott.BorderThickness = 2;
            this.btn_dott.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dott.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dott.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dott.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dott.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dott.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_dott.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dott.ForeColor = System.Drawing.Color.Black;
            this.btn_dott.Location = new System.Drawing.Point(266, 512);
            this.btn_dott.Name = "btn_dott";
            this.btn_dott.Size = new System.Drawing.Size(75, 56);
            this.btn_dott.TabIndex = 14;
            this.btn_dott.Text = ".";
            this.btn_dott.Click += new System.EventHandler(this.btn_dott_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Animated = true;
            this.btn_equal.BorderColor = System.Drawing.Color.LightGray;
            this.btn_equal.BorderRadius = 14;
            this.btn_equal.BorderThickness = 3;
            this.btn_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_equal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_equal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_equal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_equal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_equal.FillColor = System.Drawing.Color.Green;
            this.btn_equal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.Color.Black;
            this.btn_equal.Location = new System.Drawing.Point(378, 512);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 56);
            this.btn_equal.TabIndex = 13;
            this.btn_equal.Text = "=";
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_1
            // 
            this.btn_1.Animated = true;
            this.btn_1.BorderColor = System.Drawing.Color.LightGray;
            this.btn_1.BorderRadius = 14;
            this.btn_1.BorderThickness = 2;
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(36, 432);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 56);
            this.btn_1.TabIndex = 20;
            this.btn_1.Text = "1";
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Animated = true;
            this.btn_2.BorderColor = System.Drawing.Color.LightGray;
            this.btn_2.BorderRadius = 14;
            this.btn_2.BorderThickness = 2;
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_2.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.Black;
            this.btn_2.Location = new System.Drawing.Point(153, 432);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 56);
            this.btn_2.TabIndex = 19;
            this.btn_2.Text = "2";
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Animated = true;
            this.btn_3.BorderColor = System.Drawing.Color.LightGray;
            this.btn_3.BorderRadius = 14;
            this.btn_3.BorderThickness = 2;
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_3.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.Black;
            this.btn_3.Location = new System.Drawing.Point(266, 432);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 56);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "3";
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_overall
            // 
            this.btn_overall.Animated = true;
            this.btn_overall.BorderColor = System.Drawing.Color.LightGray;
            this.btn_overall.BorderRadius = 14;
            this.btn_overall.BorderThickness = 3;
            this.btn_overall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_overall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_overall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_overall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_overall.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_overall.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overall.ForeColor = System.Drawing.Color.Black;
            this.btn_overall.Location = new System.Drawing.Point(378, 273);
            this.btn_overall.Name = "btn_overall";
            this.btn_overall.Size = new System.Drawing.Size(75, 56);
            this.btn_overall.TabIndex = 21;
            this.btn_overall.Text = "*";
            this.btn_overall.Click += new System.EventHandler(this.btn_overall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Calculator_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_overall);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_dott);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cal_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator_Win";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox cal_txt;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_minus;
        private Guna.UI2.WinForms.Guna2Button btn_6;
        private Guna.UI2.WinForms.Guna2Button btn_5;
        private Guna.UI2.WinForms.Guna2Button btn_4;
        private Guna.UI2.WinForms.Guna2Button btn_divide;
        private Guna.UI2.WinForms.Guna2Button btn_del;
        private Guna.UI2.WinForms.Guna2Button btn_sqrt;
        private Guna.UI2.WinForms.Guna2Button btn_7;
        private Guna.UI2.WinForms.Guna2Button btn_8;
        private Guna.UI2.WinForms.Guna2Button btn_9;
        private Guna.UI2.WinForms.Guna2Button btn_plus;
        private Guna.UI2.WinForms.Guna2Button btn_10;
        private Guna.UI2.WinForms.Guna2Button btn_dott;
        private Guna.UI2.WinForms.Guna2Button btn_equal;
        private Guna.UI2.WinForms.Guna2Button btn_1;
        private Guna.UI2.WinForms.Guna2Button btn_2;
        private Guna.UI2.WinForms.Guna2Button btn_3;
        private Guna.UI2.WinForms.Guna2Button btn_overall;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}