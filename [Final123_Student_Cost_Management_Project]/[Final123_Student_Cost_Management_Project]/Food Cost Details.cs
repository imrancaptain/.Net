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
    public partial class Food_Cost_Details : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Food_Cost_Details()
        {
            InitializeComponent();
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            var newform = new Calculator();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newform = new Cost_Details();
            newform.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
        }

        private void Food_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", Type.GetType("System.String"));
            table.Columns.Add("Title", Type.GetType("System.String"));
            table.Columns.Add("Food Item", Type.GetType("System.String"));
            table.Columns.Add("Price", Type.GetType("System.String"));
            table.Columns.Add("Total Cost", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdate.Text = String.Empty;
            txttitle.Text = String.Empty;
            txtfooditem.Text = String.Empty;//new infromation;
            txtprice.Text = String.Empty;
            txttotalcost.Text = String.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];

            newdata.Cells[0].Value = txtdate.Text;
            newdata.Cells[1].Value = txttitle.Text;
            newdata.Cells[2].Value = txtfooditem.Text;
            newdata.Cells[3].Value = txtprice.Text;
            newdata.Cells[4].Value = txttotalcost.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            
            txtdate.Text = row.Cells[0].Value.ToString();
            txttitle.Text = row.Cells[0].Value.ToString();
            txtfooditem.Text = row.Cells[0].Value.ToString();
            txtprice.Text = row.Cells[1].Value.ToString();
            txttotalcost.Text = row.Cells[2].Value.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            table.Rows.Add( txtdate.Text,txttitle.Text,txtfooditem.Text, txtprice.Text, txttotalcost.Text);
        }
    }
}
