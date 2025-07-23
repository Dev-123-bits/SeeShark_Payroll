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
using Microsoft.Office.Interop.Excel;

namespace Payroll
{
    public partial class frm_payroll : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GACI10UM\\SQLEXPRESS;Initial Catalog=db_payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public frm_payroll()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            string query = "SELECT * FROM tbl_addemp";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee info");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee info";
            dataGridView1.DataSource = dataGridView1.DataSource;
        }

        public void computation()
        {
            try
            {
                //number of work days
                string a = txt_noWorkingDay.Text;
                int noOfWorkDays = int.Parse(a);
                string b = txt_salaryPerDay.Text;
                int salaryPerDay = int.Parse(b);
                int totalSalayPerDay = noOfWorkDays * salaryPerDay;
                txt_totalSalayPD.Text = totalSalayPerDay.ToString();

                //Overtime
                string c = txt_regularOT.Text;
                int regOT = int.Parse(c);
                int totalOT = regOT * 50;
                txt_totalOT.Text = totalOT.ToString();

                //deduction
                string d = txt_late.Text;
                int late = int.Parse(d);
                int totalLate = late * 20;
                txt_totalAmountOfLate.Text = totalLate.ToString();

                string f = txt_absent.Text;
                int absent = int.Parse(f);
                int totalAbsent = absent * salaryPerDay;
                int totalDeduc = totalLate + totalAbsent;
                txt_totalDeduction.Text = totalDeduc.ToString();

                //total salary
                int totalSalary = (totalSalayPerDay + totalOT) - totalDeduc;
                txt_totalSalary.Text = totalSalary.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Number Of Work Days?");
            }
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            if(txt_regularOT.Text == "" && txt_late.Text == "" && txt_absent.Text == "")
            {
                txt_regularOT.Text = "0";
                txt_late.Text = "0";
                txt_absent.Text = "0";
            }
            if (txt_regularOT.Text == "")
            {
                txt_regularOT.Text = "0";
            }
            if (txt_late.Text == "")
            {
                txt_late.Text = "0";
            }
            if (txt_absent.Text == "")
            {
                txt_absent.Text = "0";
            }

            computation();//invoke the constructor
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_noWorkingDay.Text = "";
            txt_salaryPerDay.Text = "";
            txt_totalSalayPD.Text = "0";
            txt_regularOT.Text = "";
            txt_totalOT.Text = "0";
            txt_late.Text = "";
            txt_totalAmountOfLate.Text = "0";
            txt_totalDeduction.Text = "0";
            txt_totalSalary.Text = "0";
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xls.ActiveSheet;

            //show excel
            ws.Columns.ColumnWidth = 20;
            xls.Visible = true;

            //cells 
            ws.Cells[1, 1] = "Number of work days : ";
            ws.Cells[2, 1] = "Salary per day : ";
            ws.Cells[4, 1] = "Total salaary per day : ";
            ws.Cells[6, 1] = "Regular OT(hr/s) : ";
            ws.Cells[7, 1] = "Total amount of OT : ";
            ws.Cells[9, 1] = "Late : ";
            ws.Cells[10, 1] = "Total amount of late : ";
            ws.Cells[11, 1] = "Absent : ";
            ws.Cells[12, 1] = "Total Deduction : ";
            ws.Cells[14, 1] = "Total Salary : ";

            //values
            ws.Cells[1, 2] = txt_noWorkingDay.Text;
            ws.Cells[2, 2] = txt_salaryPerDay.Text;
            ws.Cells[4, 2] = txt_totalSalayPD.Text;
            ws.Cells[6, 2] = txt_regularOT.Text;
            ws.Cells[7, 2] = txt_totalOT.Text;
            ws.Cells[9, 2] = txt_late.Text;
            ws.Cells[10, 2] = txt_totalAmountOfLate.Text;
            ws.Cells[11, 2] = txt_absent.Text;
            ws.Cells[12, 2] = txt_totalDeduction.Text;
            ws.Cells[14, 2] = txt_totalSalary.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            con.Open();
            string update = "SELECT ID, Firstname, Lastname, Basic_rate FROM tbl_addemp;";
            SqlDataAdapter da = new SqlDataAdapter(update, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee info");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee info";
            dataGridView1.DataSource = dataGridView1.DataSource;
            refresh();
            con.Close();
            

            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellClick
            lbl_firstname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbl_lastname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_salaryPerDay.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
