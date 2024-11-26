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
    public partial class Others_Cost_Details : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Others_Cost_Details()
        {
            InitializeComponent();
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            var newform = new Calculator();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newform = new Cost_Details();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Others(object sender, EventArgs e)
        {
            table.Columns.Add("Date", Type.GetType("System.String"));
            table.Columns.Add("Intro", Type.GetType("System.String"));
            table.Columns.Add("Anythings", Type.GetType("System.String"));
            table.Columns.Add("Price", Type.GetType("System.String"));
            table.Columns.Add("Total Cost", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtdate.Text,txtintro.Text,txtshopingitem.Text, txtprice.Text, txttotalcost.Text);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtdate.Text = String.Empty;
            txtintro.Text = String.Empty;
            txtshopingitem.Text = String.Empty;//new infromation;
            txtprice.Text = String.Empty;
            txttotalcost.Text = String.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtdate.Text;
            newdata.Cells[1].Value = txtintro.Text;
            newdata.Cells[2].Value = txtshopingitem.Text;
            newdata.Cells[3].Value = txtprice.Text;
            newdata.Cells[4].Value = txttotalcost.Text;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
