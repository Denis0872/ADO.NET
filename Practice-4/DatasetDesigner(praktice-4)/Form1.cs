using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetDesigner_praktice_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            ApressDataSet1 NorthwindDataset1 = new ApressDataSet1();
            ApressDataSet1TableAdapters.CustomersTableAdapter
            CustomersTableAdapter1 = new ApressDataSet1TableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);
            foreach (ApressDataSet1.CustomersRow NWCustomer in
                             NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }

        }
    }
}
