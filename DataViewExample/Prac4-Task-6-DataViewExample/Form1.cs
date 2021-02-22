using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac4_Task_6_DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView customersDataView;
        DataView ordersDataView;
        
       

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWNDDataSet.Orders);
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nORTHWNDDataSet.Customers);
            ordersDataView = new DataView(nORTHWNDDataSet.Orders);
            customersDataView = new DataView(nORTHWNDDataSet.Customers);
            customersDataView.Sort = "CustomerID";
           CustomersGrid.DataSource = customersDataView;
        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customersDataView.AddNew();
            newCustomRow["CustomerID"] = "WIN11";
            newCustomRow["CompanyName"] = "Wing Tip Toys1";
            newCustomRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID =
            (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow =
   customersDataView[customersDataView.Find(selectedCustomerID)];
            ordersDataView =
                    selectedRow.CreateChildView(nORTHWNDDataSet.Relations
                                                      ["FK_Orders_Customers"]);
            OrdersGrid.DataSource = ordersDataView;
        }
    }
}
