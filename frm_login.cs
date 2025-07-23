using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Payroll
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "admin123")
            {
                frm_main home = new frm_main();
                home.ShowDialog();
                clear();
            }
            else if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Please fill out the data");
                clear();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                clear();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
        public void clear()
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

    }
}