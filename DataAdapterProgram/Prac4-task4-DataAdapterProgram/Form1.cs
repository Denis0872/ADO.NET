using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prac4_task4_DataAdapterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OleDbConnection NorthwindConnection = new OleDbConnection();
        private OleDbDataAdapter OledbDataAdapter1;
        private DataSet NorthwindDataset = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NorthwindDataset.Tables;
            OledbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM Customers", NorthwindConnection);
            NorthwindDataset.Tables.Add(CustomersTable);
            OledbDataAdapter1.Fill(NorthwindDataset.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];
            OleDbCommandBuilder commands = new OleDbCommandBuilder(OledbDataAdapter1);
      
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            OledbDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);

        }
    }
}
