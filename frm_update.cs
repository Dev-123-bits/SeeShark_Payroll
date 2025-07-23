using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class frm_update : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GACI10UM\\SQLEXPRESS;Initial Catalog=db_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public frm_update()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "" || txt_address.Text == "" || cbx_gender.Text == "" || cbx_status.Text == "" || cbx_basicrate.Text == "" || cbx_position.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE tbl_addemp SET Firstname = '"+ txt_firstname.Text+"', Lastname = '" + txt_lastname.Text + "', Address = '"+txt_address.Text+"', Gender = '"+cbx_gender.Text+"', Status = '"+cbx_status.Text+"', Tel_number = '"+txt_TEL.Text+"', Phone_number = '"+txt_phonenumber.Text+"', SSS = '"+txt_sss.Text+"', Position = '"+cbx_position.Text+"', Basic_rate = '"+cbx_basicrate.Text+"' WHERE ID = '"+txt_id.Text+"' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                con.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
