namespace Payroll
{
    partial class frm_update
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
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.cbx_position = new System.Windows.Forms.ComboBox();
            this.cbx_gender = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_TEL = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_sss = new System.Windows.Forms.TextBox();
            this.cbx_basicrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_status
            // 
            this.cbx_status.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cbx_status.Location = new System.Drawing.Point(261, 340);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(182, 23);
            this.cbx_status.TabIndex = 48;
            // 
            // cbx_position
            // 
            this.cbx_position.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_position.FormattingEnabled = true;
            this.cbx_position.Items.AddRange(new object[] {
            "Software Engineer",
            "Web Developer",
            "System Analyst",
            "Database Administrator",
            "Network Engineer",
            "Data Science"});
            this.cbx_position.Location = new System.Drawing.Point(33, 230);
            this.cbx_position.Name = "cbx_position";
            this.cbx_position.Size = new System.Drawing.Size(188, 23);
            this.cbx_position.TabIndex = 49;
            // 
            // cbx_gender
            // 
            this.cbx_gender.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_gender.ForeColor = System.Drawing.Color.Black;
            this.cbx_gender.FormattingEnabled = true;
            this.cbx_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbx_gender.Location = new System.Drawing.Point(49, 340);
            this.cbx_gender.Name = "cbx_gender";
            this.cbx_gender.Size = new System.Drawing.Size(184, 23);
            this.cbx_gender.TabIndex = 47;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(345, 374);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 34);
            this.btn_update.TabIndex = 46;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Honeydew;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(566, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 16);
            this.label21.TabIndex = 44;
            this.label21.Text = "* Position:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Honeydew;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(566, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "SSS:";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.BackColor = System.Drawing.Color.Honeydew;
            this.txt_phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phonenumber.Location = new System.Drawing.Point(566, 145);
            this.txt_phonenumber.Multiline = true;
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(188, 23);
            this.txt_phonenumber.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Honeydew;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(566, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "Phone number:";
            // 
            // txt_TEL
            // 
            this.txt_TEL.BackColor = System.Drawing.Color.Honeydew;
            this.txt_TEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TEL.Location = new System.Drawing.Point(566, 78);
            this.txt_TEL.Multiline = true;
            this.txt_TEL.Name = "txt_TEL";
            this.txt_TEL.Size = new System.Drawing.Size(188, 23);
            this.txt_TEL.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Honeydew;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(566, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tel Number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Honeydew;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(262, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "* Status:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Honeydew;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(49, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "* Gender:";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.Honeydew;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Location = new System.Drawing.Point(49, 215);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(394, 87);
            this.txt_address.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(17, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "* Address:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.Color.Honeydew;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Location = new System.Drawing.Point(262, 145);
            this.txt_lastname.Multiline = true;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(181, 23);
            this.txt_lastname.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Honeydew;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(262, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "* Lastname: ";
            // 
            // txt_firstname
            // 
            this.txt_firstname.BackColor = System.Drawing.Color.Honeydew;
            this.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstname.Location = new System.Drawing.Point(49, 145);
            this.txt_firstname.Multiline = true;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(183, 23);
            this.txt_firstname.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Honeydew;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(49, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "* Firstname:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Honeydew;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(17, 32);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(183, 23);
            this.txt_id.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "* ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Location = new System.Drawing.Point(31, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 337);
            this.panel1.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(230, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 3);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(17, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 3);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(18, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 3);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.txt_sss);
            this.panel2.Controls.Add(this.cbx_basicrate);
            this.panel2.Controls.Add(this.cbx_position);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(531, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 337);
            this.panel2.TabIndex = 54;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaGreen;
            this.panel9.Location = new System.Drawing.Point(34, 185);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(188, 3);
            this.panel9.TabIndex = 59;
            // 
            // txt_sss
            // 
            this.txt_sss.BackColor = System.Drawing.Color.Honeydew;
            this.txt_sss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sss.Location = new System.Drawing.Point(33, 167);
            this.txt_sss.Multiline = true;
            this.txt_sss.Name = "txt_sss";
            this.txt_sss.Size = new System.Drawing.Size(188, 23);
            this.txt_sss.TabIndex = 58;
            // 
            // cbx_basicrate
            // 
            this.cbx_basicrate.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_basicrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_basicrate.FormattingEnabled = true;
            this.cbx_basicrate.Items.AddRange(new object[] {
            "1900",
            "1600",
            "1300",
            "1000"});
            this.cbx_basicrate.Location = new System.Drawing.Point(33, 291);
            this.cbx_basicrate.Name = "cbx_basicrate";
            this.cbx_basicrate.Size = new System.Drawing.Size(189, 25);
            this.cbx_basicrate.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "* Basic rate:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SeaGreen;
            this.panel11.Location = new System.Drawing.Point(33, 121);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(188, 3);
            this.panel11.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaGreen;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(31, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 3);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaGreen;
            this.panel8.Location = new System.Drawing.Point(1, -2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 3);
            this.panel8.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Location = new System.Drawing.Point(22, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 423);
            this.panel4.TabIndex = 55;
            // 
            // btn_close
            // 
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_close.BackgroundImage = global::Payroll.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(795, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 28);
            this.btn_close.TabIndex = 56;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Update";
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(822, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.cbx_gender);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_TEL);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_update;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel11;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Panel panel4;
        private Button btn_close;
        private Label label2;
        public TextBox txt_id;
        public ComboBox cbx_status;
        public ComboBox cbx_position;
        public ComboBox cbx_gender;
        public TextBox txt_phonenumber;
        public TextBox txt_TEL;
        public TextBox txt_address;
        public TextBox txt_lastname;
        public TextBox txt_firstname;
        public ComboBox cbx_basicrate;
        public TextBox txt_sss;
        private Panel panel9;
    }
}