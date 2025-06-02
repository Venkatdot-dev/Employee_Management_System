namespace Company_Emp_project
{
    partial class Register_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_win));
            this.txt_regmobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_regis = new Guna.UI2.WinForms.Guna2Button();
            this.txt_regemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regconpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regcpass = new System.Windows.Forms.Label();
            this.rst_all = new System.Windows.Forms.LinkLabel();
            this.txt_regunme = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_regmobile
            // 
            this.txt_regmobile.BorderColor = System.Drawing.Color.Gray;
            this.txt_regmobile.BorderRadius = 13;
            this.txt_regmobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regmobile.DefaultText = "";
            this.txt_regmobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regmobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regmobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regmobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regmobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regmobile.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regmobile.ForeColor = System.Drawing.Color.Black;
            this.txt_regmobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regmobile.Location = new System.Drawing.Point(630, 536);
            this.txt_regmobile.Margin = new System.Windows.Forms.Padding(5);
            this.txt_regmobile.Name = "txt_regmobile";
            this.txt_regmobile.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_regmobile.PlaceholderText = "Enter your mobile-no";
            this.txt_regmobile.SelectedText = "";
            this.txt_regmobile.Size = new System.Drawing.Size(292, 39);
            this.txt_regmobile.TabIndex = 37;
            // 
            // btn_regis
            // 
            this.btn_regis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regis.Animated = true;
            this.btn_regis.BorderColor = System.Drawing.Color.Transparent;
            this.btn_regis.BorderRadius = 15;
            this.btn_regis.BorderThickness = 1;
            this.btn_regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_regis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_regis.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_regis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_regis.ForeColor = System.Drawing.Color.White;
            this.btn_regis.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_regis.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_regis.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_regis.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_regis.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_regis.Location = new System.Drawing.Point(710, 604);
            this.btn_regis.Name = "btn_regis";
            this.btn_regis.Size = new System.Drawing.Size(149, 41);
            this.btn_regis.TabIndex = 38;
            this.btn_regis.Text = "Register";
            this.btn_regis.Click += new System.EventHandler(this.btn_regis_Click);
            // 
            // txt_regemail
            // 
            this.txt_regemail.BorderColor = System.Drawing.Color.Gray;
            this.txt_regemail.BorderRadius = 13;
            this.txt_regemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regemail.DefaultText = "";
            this.txt_regemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regemail.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regemail.ForeColor = System.Drawing.Color.Black;
            this.txt_regemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regemail.Location = new System.Drawing.Point(630, 432);
            this.txt_regemail.Margin = new System.Windows.Forms.Padding(5);
            this.txt_regemail.Name = "txt_regemail";
            this.txt_regemail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_regemail.PlaceholderText = "Enter your email";
            this.txt_regemail.SelectedText = "";
            this.txt_regemail.Size = new System.Drawing.Size(292, 39);
            this.txt_regemail.TabIndex = 36;
            // 
            // txt_regconpass
            // 
            this.txt_regconpass.BorderColor = System.Drawing.Color.Gray;
            this.txt_regconpass.BorderRadius = 13;
            this.txt_regconpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regconpass.DefaultText = "";
            this.txt_regconpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regconpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regconpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regconpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regconpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regconpass.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regconpass.ForeColor = System.Drawing.Color.Black;
            this.txt_regconpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regconpass.Location = new System.Drawing.Point(630, 330);
            this.txt_regconpass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_regconpass.Name = "txt_regconpass";
            this.txt_regconpass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_regconpass.PlaceholderText = "Enter your c-pass";
            this.txt_regconpass.SelectedText = "";
            this.txt_regconpass.Size = new System.Drawing.Size(292, 39);
            this.txt_regconpass.TabIndex = 35;
            // 
            // txt_regpass
            // 
            this.txt_regpass.BorderColor = System.Drawing.Color.Gray;
            this.txt_regpass.BorderRadius = 13;
            this.txt_regpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regpass.DefaultText = "";
            this.txt_regpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpass.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regpass.ForeColor = System.Drawing.Color.Black;
            this.txt_regpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpass.Location = new System.Drawing.Point(630, 230);
            this.txt_regpass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_regpass.Name = "txt_regpass";
            this.txt_regpass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_regpass.PlaceholderText = "Enter your pass";
            this.txt_regpass.SelectedText = "";
            this.txt_regpass.Size = new System.Drawing.Size(292, 42);
            this.txt_regpass.TabIndex = 34;
            // 
            // txt_regcpass
            // 
            this.txt_regcpass.AutoSize = true;
            this.txt_regcpass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txt_regcpass.Location = new System.Drawing.Point(625, 288);
            this.txt_regcpass.Name = "txt_regcpass";
            this.txt_regcpass.Size = new System.Drawing.Size(139, 24);
            this.txt_regcpass.TabIndex = 49;
            this.txt_regcpass.Text = "CPassword  :";
            // 
            // rst_all
            // 
            this.rst_all.AutoSize = true;
            this.rst_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rst_all.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.rst_all.Location = new System.Drawing.Point(754, 665);
            this.rst_all.Name = "rst_all";
            this.rst_all.Size = new System.Drawing.Size(65, 26);
            this.rst_all.TabIndex = 39;
            this.rst_all.TabStop = true;
            this.rst_all.Text = "RESET";
            this.rst_all.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rst_all_LinkClicked);
            // 
            // txt_regunme
            // 
            this.txt_regunme.BorderColor = System.Drawing.Color.Gray;
            this.txt_regunme.BorderRadius = 13;
            this.txt_regunme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regunme.DefaultText = "";
            this.txt_regunme.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regunme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regunme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regunme.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regunme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regunme.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regunme.ForeColor = System.Drawing.Color.Black;
            this.txt_regunme.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regunme.Location = new System.Drawing.Point(630, 130);
            this.txt_regunme.Margin = new System.Windows.Forms.Padding(5);
            this.txt_regunme.Name = "txt_regunme";
            this.txt_regunme.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_regunme.PlaceholderText = "Enter your name";
            this.txt_regunme.SelectedText = "";
            this.txt_regunme.Size = new System.Drawing.Size(292, 42);
            this.txt_regunme.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(625, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Mobile-No  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(629, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email  :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1072, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(937, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Already Have an Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(629, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Admin Name  :";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.linkLabel2.Location = new System.Drawing.Point(1017, 690);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 26);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign_In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(625, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Set Password  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(741, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Register  Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 724);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // Register_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_regmobile);
            this.Controls.Add(this.btn_regis);
            this.Controls.Add(this.txt_regemail);
            this.Controls.Add(this.txt_regconpass);
            this.Controls.Add(this.txt_regpass);
            this.Controls.Add(this.txt_regcpass);
            this.Controls.Add(this.rst_all);
            this.Controls.Add(this.txt_regunme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_win";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_regmobile;
        private Guna.UI2.WinForms.Guna2Button btn_regis;
        private Guna.UI2.WinForms.Guna2TextBox txt_regemail;
        private Guna.UI2.WinForms.Guna2TextBox txt_regconpass;
        private Guna.UI2.WinForms.Guna2TextBox txt_regpass;
        private System.Windows.Forms.Label txt_regcpass;
        private System.Windows.Forms.LinkLabel rst_all;
        private Guna.UI2.WinForms.Guna2TextBox txt_regunme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}