namespace Payroll
{
    partial class frm_addemp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbx_position = new System.Windows.Forms.ComboBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.cbx_gender = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_sss = new System.Windows.Forms.TextBox();
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbx_basicrate = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbx_search = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frmaddempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmaddempBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmaddempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmaddempBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.cbx_position);
            this.tabPage1.Controls.Add(this.cbx_status);
            this.tabPage1.Controls.Add(this.cbx_gender);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txt_sss);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txt_phonenumber);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txt_TEL);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txt_lastname);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txt_firstname);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EMPLOYEE INFO";
            // 
            // cbx_position
            // 
            this.cbx_position.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_position.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_position.FormattingEnabled = true;
            this.cbx_position.Items.AddRange(new object[] {
            "Software Engineer",
            "Web Developer",
            "System Analyst",
            "Database Administrator",
            "Network Engineer",
            "Data Science"});
            this.cbx_position.Location = new System.Drawing.Point(545, 260);
            this.cbx_position.Name = "cbx_position";
            this.cbx_position.Size = new System.Drawing.Size(195, 25);
            this.cbx_position.TabIndex = 23;
            // 
            // cbx_status
            // 
            this.cbx_status.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cbx_status.Location = new System.Drawing.Point(240, 321);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(182, 25);
            this.cbx_status.TabIndex = 22;
            // 
            // cbx_gender
            // 
            this.cbx_gender.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_gender.ForeColor = System.Drawing.Color.Black;
            this.cbx_gender.FormattingEnabled = true;
            this.cbx_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbx_gender.Location = new System.Drawing.Point(28, 321);
            this.cbx_gender.Name = "cbx_gender";
            this.cbx_gender.Size = new System.Drawing.Size(184, 25);
            this.cbx_gender.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(357, 380);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 34);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(545, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 16);
            this.label21.TabIndex = 16;
            this.label21.Text = "* Position:";
            // 
            // txt_sss
            // 
            this.txt_sss.BackColor = System.Drawing.Color.Honeydew;
            this.txt_sss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sss.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sss.Location = new System.Drawing.Point(545, 196);
            this.txt_sss.Multiline = true;
            this.txt_sss.Name = "txt_sss";
            this.txt_sss.Size = new System.Drawing.Size(188, 23);
            this.txt_sss.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(545, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 14;
            this.label20.Text = "SSS:";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.BackColor = System.Drawing.Color.Honeydew;
            this.txt_phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phonenumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phonenumber.Location = new System.Drawing.Point(545, 126);
            this.txt_phonenumber.Multiline = true;
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(188, 23);
            this.txt_phonenumber.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(545, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Phone number:";
            // 
            // txt_TEL
            // 
            this.txt_TEL.BackColor = System.Drawing.Color.Honeydew;
            this.txt_TEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TEL.Location = new System.Drawing.Point(545, 59);
            this.txt_TEL.Multiline = true;
            this.txt_TEL.Name = "txt_TEL";
            this.txt_TEL.Size = new System.Drawing.Size(188, 23);
            this.txt_TEL.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(545, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tel Number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(241, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "* Status:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(28, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "* Gender:";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.Honeydew;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.Location = new System.Drawing.Point(28, 196);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(394, 87);
            this.txt_address.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(28, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "* Address:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.Color.Honeydew;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lastname.Location = new System.Drawing.Point(241, 126);
            this.txt_lastname.Multiline = true;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(181, 23);
            this.txt_lastname.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(241, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "* Lastname: ";
            // 
            // txt_firstname
            // 
            this.txt_firstname.BackColor = System.Drawing.Color.Honeydew;
            this.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_firstname.Location = new System.Drawing.Point(28, 126);
            this.txt_firstname.Multiline = true;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(183, 23);
            this.txt_firstname.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(28, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "* Firstname:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Honeydew;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(28, 59);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(183, 23);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(28, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "* ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 337);
            this.panel1.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(230, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 3);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(17, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 3);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(18, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 3);
            this.panel3.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.Location = new System.Drawing.Point(18, 56);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(40, 16);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            this.lbl_status.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.cbx_basicrate);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(514, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 337);
            this.panel2.TabIndex = 26;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SeaGreen;
            this.panel12.Location = new System.Drawing.Point(31, 189);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(188, 3);
            this.panel12.TabIndex = 27;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SeaGreen;
            this.panel11.Location = new System.Drawing.Point(31, 121);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(188, 3);
            this.panel11.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaGreen;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(31, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(188, 3);
            this.panel9.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SeaGreen;
            this.panel10.Location = new System.Drawing.Point(1, -3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(188, 3);
            this.panel10.TabIndex = 26;
            // 
            // cbx_basicrate
            // 
            this.cbx_basicrate.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_basicrate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_basicrate.FormattingEnabled = true;
            this.cbx_basicrate.Items.AddRange(new object[] {
            "1900",
            "1600",
            "1300",
            "1000"});
            this.cbx_basicrate.Location = new System.Drawing.Point(31, 293);
            this.cbx_basicrate.Name = "cbx_basicrate";
            this.cbx_basicrate.Size = new System.Drawing.Size(193, 25);
            this.cbx_basicrate.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(36, 274);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 16);
            this.label22.TabIndex = 18;
            this.label22.Text = "* Basic rate:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.txt_search);
            this.tabPage2.Controls.Add(this.cbx_search);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.btn_refresh);
            this.tabPage2.Controls.Add(this.btn_edit);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EMPLOYEE DATA";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Honeydew;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(185, 7);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(151, 24);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cbx_search
            // 
            this.cbx_search.BackColor = System.Drawing.Color.Honeydew;
            this.cbx_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_search.ForeColor = System.Drawing.Color.Silver;
            this.cbx_search.FormattingEnabled = true;
            this.cbx_search.Items.AddRange(new object[] {
            "ID",
            "Firstname",
            "Lastname"});
            this.cbx_search.Location = new System.Drawing.Point(37, 7);
            this.cbx_search.Name = "cbx_search";
            this.cbx_search.Size = new System.Drawing.Size(142, 25);
            this.cbx_search.TabIndex = 5;
            this.cbx_search.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 25);
            this.panel4.TabIndex = 4;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_refresh.Location = new System.Drawing.Point(6, 403);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(63, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(642, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 26);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(711, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 26);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(768, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmaddempBindingSource
            // 
            this.frmaddempBindingSource.DataSource = typeof(Payroll.frm_addemp);
            // 
            // frmaddempBindingSource1
            // 
            this.frmaddempBindingSource1.DataSource = typeof(Payroll.frm_addemp);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button2.BackgroundImage = global::Payroll.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(791, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 28);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frm_addemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_addemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.frm_addemp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmaddempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmaddempBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label22;
        private Label label21;
        private TextBox txt_sss;
        private Label label20;
        private TextBox txt_phonenumber;
        private Label label19;
        private TextBox txt_TEL;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox txt_address;
        private Label label15;
        private TextBox txt_lastname;
        private Label label14;
        private TextBox txt_firstname;
        private Label label13;
        private TextBox txt_id;
        private Label label12;
        private Button btn_save;
        private ComboBox cbx_basicrate;
        private ComboBox cbx_position;
        private ComboBox cbx_status;
        private ComboBox cbx_gender;
        private Panel panel1;
        private Panel panel2;
        private BindingSource frmaddempBindingSource;
        private BindingSource frmaddempBindingSource1;
        private DataGridView dataGridView1;
        private Button btn_delete;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Panel panel12;
        private Panel panel11;
        private Panel panel9;
        private Panel panel10;
        private Button button2;
        private Button btn_edit;
        private Button btn_refresh;
        private Label lbl_status;
        private TextBox txt_search;
        private ComboBox cbx_search;
        private Panel panel4;
    }
}