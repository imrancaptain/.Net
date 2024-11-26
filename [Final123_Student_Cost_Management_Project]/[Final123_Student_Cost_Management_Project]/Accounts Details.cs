using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Final123_Student_Cost_Management_Project_
{
    public partial class Accounts_Details : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Accounts_Details()
        {
            InitializeComponent();
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            var newform = new Calculator();
            newform.Show();
        }

        private void btncalculator_Click_1(object sender, EventArgs e)
        {
            var newform = new Calculator();
            newform.Show();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", Type.GetType("System.String"));
            table.Columns.Add("Title", Type.GetType("System.String"));
            table.Columns.Add("Fund", Type.GetType("System.String"));
            table.Columns.Add("Transportation Cost", Type.GetType("System.String"));
            table.Columns.Add("Food Cost", Type.GetType("System.String"));
            table.Columns.Add("Others Cost", Type.GetType("System.String"));
            table.Columns.Add("Total cost", Type.GetType("System.String"));
            table.Columns.Add("Current Amount", Type.GetType("System.String"));
            table.Columns.Add("Previous Amount", Type.GetType("System.String"));
            table.Columns.Add("Total Balance", Type.GetType("System.String"));
            table.Columns.Add("Loan Amount", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtdate.Text, txttitle.Text, txtfund.Text,txttransportation.Text,txtfoodcost.Text,txtotherscost.Text,txttotalcost.Text, txtcurrentamount.Text, txtpreviousamount.Text, txtbalance.Text, txtloanamount.Text);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtdate.Text = String.Empty;
            txttitle.Text = String.Empty;//new infromation;
            txtfund.Text = String.Empty;
            txttransportation.Text = String.Empty;
            txtfoodcost.Text = String.Empty;
            txtotherscost.Text = String.Empty;
            txttotalcost.Text = String.Empty;
            txtcurrentamount.Text = String.Empty;
            txtpreviousamount.Text = String.Empty;
            txtbalance.Text = String.Empty;
            txtloanamount.Text = String.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtdate.Text;
            newdata.Cells[1].Value = txttitle.Text;
            newdata.Cells[2].Value = txtfund.Text;
            newdata.Cells[3].Value = txttransportation.Text;
            newdata.Cells[4].Value = txtfoodcost.Text;
            newdata.Cells[5].Value = txtotherscost.Text;
            newdata.Cells[6].Value = txttotalcost.Text;
            newdata.Cells[7].Value = txtcurrentamount.Text;
            newdata.Cells[8].Value = txtpreviousamount.Text;
            newdata.Cells[9].Value = txtbalance.Text;
            newdata.Cells[10].Value = txtloanamount;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newform = new Cost_Details();
            newform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
