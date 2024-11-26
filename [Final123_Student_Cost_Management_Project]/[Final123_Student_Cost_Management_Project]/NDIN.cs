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
    public partial class NDIN : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public NDIN()
        {
            InitializeComponent();
        }

        private void NPID_LOAD(object sender, EventArgs e)
        {
            table.Columns.Add("Fund", Type.GetType("System.String"));
            table.Columns.Add("Next DAY Items Name", Type.GetType("System.String"));
             table.Columns.Add("Price", Type.GetType("System.Int32"));
            table.Columns.Add("Budget", Type.GetType("System.String"));
            table.Columns.Add("Remaining Total", Type.GetType("System.Double"));
            dataGridView1.DataSource = table;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            table.Rows.Add(txtfund.Text,txtitemsname.Text,txtprice.Text,txtbudget.Text, txtremainingtotal.Text);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtfund.Text = String.Empty;
            txtitemsname.Text = String.Empty;//new infromation;
            txtprice.Text = String.Empty;
            txtbudget.Text = String.Empty;
            txtremainingtotal.Text = String.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtfund.Text;
            newdata.Cells[1].Value = txtitemsname.Text;
            newdata.Cells[2].Value = txtprice.Text;
            newdata.Cells[3].Value = txtbudget.Text;
            newdata.Cells[4].Value = txtremainingtotal.Text;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txttotalcost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
