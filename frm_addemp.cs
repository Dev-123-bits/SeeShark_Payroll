using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Payroll
{
    public partial class frm_addemp : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GACI10UM\\SQLEXPRESS;Initial Catalog=db_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public frm_addemp()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            string query = "SELECT * FROM tbl_addemp ORDER BY ID";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee info");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee info";
            dataGridView1.DataSource = dataGridView1.DataSource;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "" || txt_address.Text == "" || cbx_gender.Text == "" || cbx_status.Text == "" || cbx_basicrate.Text == "" || cbx_position.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else 
                { 
                con.Open();
                cmd = new SqlCommand("INSERT INTO tbl_addemp(ID, Firstname, Lastname, Address, Gender, Status, Tel_number, Phone_number, SSS, Position, Basic_rate) VALUES ('" + txt_id.Text + "','" + txt_firstname.Text + "','" + txt_lastname.Text + "','" + txt_address.Text + "','" + cbx_gender.Text + "','" + cbx_status.Text + "','" + txt_TEL.Text + "','" + txt_phonenumber.Text + "','" + txt_sss.Text + "','" + cbx_position.Text + "','" + cbx_basicrate.Text + "' )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                refresh();
                    con.Close();
                }
            } 
            catch(Exception)
            {
                MessageBox.Show("Invalid data try again");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
                    {
                        MessageBox.Show("No more data");
                    }
                    else
                    {
                        if (MessageBox.Show("Want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            con.Open();
                            cmd = new SqlCommand("DELETE FROM tbl_addemp WHERE ID = '" + del + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Deleted");
                            refresh();
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_addemp_Load(object sender, EventArgs e)
        {
            refresh();//update the datagridview 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();//close the tab of employee add
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Payroll.frm_update frm = new frm_update(); 
            frm.txt_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();//in form update the textbox and combo box should public modifier to invoke in other class/form
            frm.txt_firstname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txt_lastname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txt_address.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cbx_gender.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.cbx_status.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txt_TEL.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txt_phonenumber.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.txt_sss.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.cbx_position.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.cbx_basicrate.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();

            frm.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_addemp WHERE ID=@Name",con);
                cmd.Parameters.AddWithValue("@Name",txt_id.Text);
                SqlDataReader dr = cmd.ExecuteReader();//find the same id in database
                if (dr.HasRows)
                {
                    lbl_status.Visible = true;
                    lbl_status.Text = "ID is already taken.";
                    lbl_status.ForeColor = Color.Crimson;

                }
                else
                {
                    lbl_status.Visible = true;
                    lbl_status.Text = "This ID is available";
                    lbl_status.ForeColor = Color.SeaGreen;
                }
                con.Close();
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cbx_search.Text == "ID")
            {
                if (txt_search.Text == "")
                {
                    refresh();
                }
                else
                {
                    string query = "SELECT * FROM tbl_addemp WHERE ID LIKE '" + txt_search.Text + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee info");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Employee info";
                    dataGridView1.DataSource = dataGridView1.DataSource;
                }
            }
            if (cbx_search.Text == "Firstname")
            {
                if (txt_search.Text == "")
                {
                    refresh();
                }
                else
                {
                    string query = "SELECT * FROM tbl_addemp WHERE Firstname LIKE '" + txt_search.Text + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee info");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Employee info";
                    dataGridView1.DataSource = dataGridView1.DataSource;
                }
            }
            if (cbx_search.Text == "Lastname")
            {
                if (txt_search.Text == "")
                {
                    refresh();
                }
                else
                {
                    string query = "SELECT * FROM tbl_addemp WHERE Lastname LIKE '" + txt_search.Text + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee info");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Employee info";
                    dataGridView1.DataSource = dataGridView1.DataSource;
                }
            }
        }

    }
}

