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
    public partial class Transportation_Cost_Details : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Transportation_Cost_Details()
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

        private void btninsert_Click(object sender, EventArgs e)
        {

            table.Rows.Add(txtdate.Text,txttitle.Text,txtsource.Text,txtdestination.Text,txtprice.Text,txttotalcost.Text);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtdate.Text = String.Empty;
            txttitle.Text = String.Empty;
            txtsource.Text = String.Empty;//new infromation;
            txtdestination.Text = String.Empty;
            txtprice.Text = String.Empty;
            txttotalcost.Text = String.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtdate.Text;
            newdata.Cells[1].Value = txttitle.Text;
            newdata.Cells[2].Value = txtsource.Text;
            newdata.Cells[3].Value = txtdestination.Text;
            newdata.Cells[4].Value = txtprice.Text;
            newdata.Cells[5].Value = txttotalcost.Text;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void Transportation_Cost_Details_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", Type.GetType("System.String"));
            table.Columns.Add("Title", Type.GetType("System.String"));
            table.Columns.Add("Source", Type.GetType("System.String"));
            table.Columns.Add("Destination", Type.GetType("System.String"));
            table.Columns.Add("Price", Type.GetType("System.String"));
            table.Columns.Add("Total Price", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }
    }
}
