namespace Emp_Manag_Project
{
    partial class Employee_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Salary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_slry_fetch = new Guna.UI2.WinForms.Guna2Button();
            this.btn_slry_add = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_manager = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_emp = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_name = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slry_slip = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 731);
            this.panel1.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(401, 223);
            this.dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee - Management";
            // 
            // btn_slry_fetch
            // 
            this.btn_slry_fetch.Animated = true;
            this.btn_slry_fetch.BorderRadius = 15;
            this.btn_slry_fetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_slry_fetch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_slry_fetch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_slry_fetch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_slry_fetch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_slry_fetch.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_slry_fetch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_slry_fetch.ForeColor = System.Drawing.Color.White;
            this.btn_slry_fetch.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_slry_fetch.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_slry_fetch.HoverState.FillColor = System.Drawing.Color.Navy;
            this.btn_slry_fetch.Location = new System.Drawing.Point(679, 589);
            this.btn_slry_fetch.Name = "btn_slry_fetch";
            this.btn_slry_fetch.Size = new System.Drawing.Size(122, 41);
            this.btn_slry_fetch.TabIndex = 75;
            this.btn_slry_fetch.Text = "FETCH";
            this.btn_slry_fetch.Click += new System.EventHandler(this.btn_slry_fetch_Click);
            // 
            // btn_slry_add
            // 
            this.btn_slry_add.Animated = true;
            this.btn_slry_add.BorderRadius = 15;
            this.btn_slry_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_slry_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_slry_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_slry_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_slry_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_slry_add.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_slry_add.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_slry_add.ForeColor = System.Drawing.Color.White;
            this.btn_slry_add.HoverState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_slry_add.HoverState.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_slry_add.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_slry_add.Location = new System.Drawing.Point(489, 589);
            this.btn_slry_add.Name = "btn_slry_add";
            this.btn_slry_add.Size = new System.Drawing.Size(122, 41);
            this.btn_slry_add.TabIndex = 74;
            this.btn_slry_add.Text = "ADD";
            this.btn_slry_add.Click += new System.EventHandler(this.btn_slry_add_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(593, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 76;
            this.label4.Text = "Salary";
            // 
            // rdo_manager
            // 
            this.rdo_manager.AutoSize = true;
            this.rdo_manager.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_manager.CheckedState.BorderThickness = 0;
            this.rdo_manager.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_manager.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_manager.CheckedState.InnerOffset = -4;
            this.rdo_manager.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_manager.Location = new System.Drawing.Point(467, 69);
            this.rdo_manager.Name = "rdo_manager";
            this.rdo_manager.Size = new System.Drawing.Size(115, 26);
            this.rdo_manager.TabIndex = 77;
            this.rdo_manager.Text = "Manager";
            this.rdo_manager.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_manager.UncheckedState.BorderThickness = 2;
            this.rdo_manager.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_manager.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo_manager.CheckedChanged += new System.EventHandler(this.rdo_manager_CheckedChanged);
            // 
            // rdo_emp
            // 
            this.rdo_emp.AutoSize = true;
            this.rdo_emp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_emp.CheckedState.BorderThickness = 0;
            this.rdo_emp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_emp.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_emp.CheckedState.InnerOffset = -4;
            this.rdo_emp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rdo_emp.Location = new System.Drawing.Point(702, 69);
            this.rdo_emp.Name = "rdo_emp";
            this.rdo_emp.Size = new System.Drawing.Size(122, 26);
            this.rdo_emp.TabIndex = 78;
            this.rdo_emp.Text = "Employee";
            this.rdo_emp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_emp.UncheckedState.BorderThickness = 2;
            this.rdo_emp.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_emp.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo_emp.CheckedChanged += new System.EventHandler(this.rdo_emp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(498, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(498, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "Salary";
            // 
            // txt_salary
            // 
            this.txt_salary.BorderColor = System.Drawing.Color.Gray;
            this.txt_salary.BorderRadius = 13;
            this.txt_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_salary.DefaultText = "";
            this.txt_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_salary.ForeColor = System.Drawing.Color.Black;
            this.txt_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Location = new System.Drawing.Point(504, 291);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_salary.PlaceholderText = "";
            this.txt_salary.SelectedText = "";
            this.txt_salary.Size = new System.Drawing.Size(282, 42);
            this.txt_salary.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 84;
            this.label5.Text = "Bonus";
            // 
            // txt_bonus
            // 
            this.txt_bonus.BorderColor = System.Drawing.Color.Gray;
            this.txt_bonus.BorderRadius = 13;
            this.txt_bonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bonus.DefaultText = "";
            this.txt_bonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bonus.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_bonus.ForeColor = System.Drawing.Color.Black;
            this.txt_bonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bonus.Location = new System.Drawing.Point(504, 399);
            this.txt_bonus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_bonus.PlaceholderText = "";
            this.txt_bonus.SelectedText = "";
            this.txt_bonus.Size = new System.Drawing.Size(282, 42);
            this.txt_bonus.TabIndex = 83;
            this.txt_bonus.TextChanged += new System.EventHandler(this.txt_bonus_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(498, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 86;
            this.label6.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.AutoRoundedCorners = true;
            this.txt_total.BorderColor = System.Drawing.Color.Gray;
            this.txt_total.BorderRadius = 20;
            this.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total.DefaultText = "";
            this.txt_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_total.ForeColor = System.Drawing.Color.Black;
            this.txt_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total.Location = new System.Drawing.Point(504, 509);
            this.txt_total.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_total.PlaceholderText = "";
            this.txt_total.SelectedText = "";
            this.txt_total.Size = new System.Drawing.Size(282, 42);
            this.txt_total.TabIndex = 85;
            // 
            // cmb_name
            // 
            this.cmb_name.BackColor = System.Drawing.Color.Transparent;
            this.cmb_name.BorderColor = System.Drawing.Color.Gray;
            this.cmb_name.BorderRadius = 13;
            this.cmb_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_name.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_name.ForeColor = System.Drawing.Color.Black;
            this.cmb_name.ItemHeight = 35;
            this.cmb_name.Items.AddRange(new object[] {
            "Senior Level",
            "Junior Level"});
            this.cmb_name.Location = new System.Drawing.Point(504, 183);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(282, 41);
            this.cmb_name.TabIndex = 87;
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(880, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // slry_slip
            // 
            this.slry_slip.Animated = true;
            this.slry_slip.BorderRadius = 15;
            this.slry_slip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slry_slip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.slry_slip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.slry_slip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.slry_slip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.slry_slip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(185)))));
            this.slry_slip.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.slry_slip.ForeColor = System.Drawing.Color.White;
            this.slry_slip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(126)))));
            this.slry_slip.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(126)))));
            this.slry_slip.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(126)))));
            this.slry_slip.Location = new System.Drawing.Point(763, 665);
            this.slry_slip.Name = "slry_slip";
            this.slry_slip.Size = new System.Drawing.Size(153, 41);
            this.slry_slip.TabIndex = 89;
            this.slry_slip.Text = "Salary_slip";
            this.slry_slip.Click += new System.EventHandler(this.slry_slip_Click);
            // 
            // Employee_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 720);
            this.Controls.Add(this.slry_slip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_emp);
            this.Controls.Add(this.rdo_manager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_slry_fetch);
            this.Controls.Add(this.btn_slry_add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emp_Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btn_slry_fetch;
        private Guna.UI2.WinForms.Guna2Button btn_slry_add;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_manager;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_salary;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_bonus;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_total;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button slry_slip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}