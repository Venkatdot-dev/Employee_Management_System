namespace Book_Store_Project
{
    partial class Book_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Store));
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_admin = new System.Windows.Forms.LinkLabel();
            this.lnk_logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add_bk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_bill_page = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(442, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "VM BOOK  STORE";
            // 
            // lnk_admin
            // 
            this.lnk_admin.AutoSize = true;
            this.lnk_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_admin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F);
            this.lnk_admin.Location = new System.Drawing.Point(881, 100);
            this.lnk_admin.Name = "lnk_admin";
            this.lnk_admin.Size = new System.Drawing.Size(88, 36);
            this.lnk_admin.TabIndex = 8;
            this.lnk_admin.TabStop = true;
            this.lnk_admin.Text = "ADMIN";
            this.lnk_admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_admin_LinkClicked);
            // 
            // lnk_logout
            // 
            this.lnk_logout.AutoSize = true;
            this.lnk_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_logout.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F);
            this.lnk_logout.Location = new System.Drawing.Point(122, 100);
            this.lnk_logout.Name = "lnk_logout";
            this.lnk_logout.Size = new System.Drawing.Size(100, 36);
            this.lnk_logout.TabIndex = 7;
            this.lnk_logout.TabStop = true;
            this.lnk_logout.Text = "LOGOUT";
            this.lnk_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_logout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.btn_add_bk.Location = new System.Drawing.Point(362, 507);
            this.btn_add_bk.Name = "btn_add_bk";
            this.btn_add_bk.Size = new System.Drawing.Size(159, 45);
            this.btn_add_bk.TabIndex = 41;
            this.btn_add_bk.Text = "ADD BOOK";
            this.btn_add_bk.Click += new System.EventHandler(this.btn_add_bk_Click);
            // 
            // btn_bill_page
            // 
            this.btn_bill_page.Animated = true;
            this.btn_bill_page.BorderRadius = 19;
            this.btn_bill_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bill_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bill_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bill_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bill_page.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_bill_page.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_bill_page.ForeColor = System.Drawing.Color.White;
            this.btn_bill_page.Location = new System.Drawing.Point(600, 507);
            this.btn_bill_page.Name = "btn_bill_page";
            this.btn_bill_page.Size = new System.Drawing.Size(170, 45);
            this.btn_bill_page.TabIndex = 42;
            this.btn_bill_page.Text = "BILLING PAGE";
            this.btn_bill_page.Click += new System.EventHandler(this.btn_bill_page_Click);
            // 
            // Book_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 588);
            this.Controls.Add(this.btn_bill_page);
            this.Controls.Add(this.btn_add_bk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnk_admin);
            this.Controls.Add(this.lnk_logout);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Store";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_admin;
        private System.Windows.Forms.LinkLabel lnk_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_add_bk;
        private Guna.UI2.WinForms.Guna2Button btn_bill_page;
    }
}