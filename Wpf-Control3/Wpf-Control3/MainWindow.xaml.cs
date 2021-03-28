using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Wpf_Control3.DataSet1TableAdapters;
using System.Data.Common;
using System.Collections.ObjectModel;
using Wpf_Control3.Models;
using System.Data.Entity;
using System.Configuration;
using static Wpf_Control3.DataSet1;
using System.ComponentModel;

namespace Wpf_Control3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();     
        }
        protected static OleDbConnection GetConnection()
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=SQLNCLI11;Data Source=DENIS-COMP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PraktikaDB");
            cn.Open();
            return cn;
        }
        string connection2 = @"Provider=SQLNCLI11;Data Source=DENIS-COMP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PraktikaDB";
        OleDbConnection connection = new OleDbConnection();
        public DataSet1.OurTableDataTable users;
        DataSet1 TableDataset1 = new DataSet1();
        DataSet1TableAdapters.OurTableTableAdapter PraktikaTableAdapter1 = new DataSet1TableAdapters.OurTableTableAdapter();

        //проверка подключения
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connection2;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
        //подсчитать текущее количество строк
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var tt = GetConnection())
            {
                string cmd = "SELECT COUNT(*) FROM OurTable";
                OleDbCommand command = new OleDbCommand(cmd, tt);
                int number = (int)command.ExecuteScalar();
                label1.Content = number.ToString();
            }
        }
        //вывести колонку в листбокс
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var tt = GetConnection())
            {
                string cmd = "SELECT * FROM OurTable";
                OleDbCommand command = new OleDbCommand(cmd, tt);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["nCanonId"].ToString());
                }
            }
        }
        //заполнить базой
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PraktikaTableAdapter1.Fill(TableDataset1.OurTable);
            DataGrid1.ItemsSource = TableDataset1.OurTable.DefaultView;
            #region
            // using (var tt = GetConnection())
            //{
            //    string cmd = "SELECT * FROM OurTable ";
            //    OleDbCommand command1 = new OleDbCommand(cmd, tt);
            //    OleDbDataAdapter dataAdp = new OleDbDataAdapter(command1);
            //    dataAdp.Fill(dt);
            //    DataGrid1.ItemsSource = dt.DefaultView;
            //    dataAdp.Update(dt);
            //}
            #endregion
        }
        //добавить строку
        private void addstring_Click(object sender, RoutedEventArgs e)
        {
            DataRow NRow = TableDataset1.OurTable.NewRow();
            TableDataset1.OurTable.Rows.Add(NRow);
        }
        //удалить строку
        private void deletestring_Click(object sender, RoutedEventArgs e)
        {
            IEditableCollectionView iecv = CollectionViewSource.GetDefaultView(DataGrid1.ItemsSource) as IEditableCollectionView;

            while (DataGrid1.SelectedIndex >= 0)
            {
                int selectedIndex = DataGrid1.SelectedIndex;
                
                DataGridRow dgr = DataGrid1.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as DataGridRow;
                dgr.IsSelected = false;

                if (iecv.IsEditingItem)
                {
                    iecv.CommitEdit();
                    iecv.RemoveAt(selectedIndex);
                }
                else
                {
                   iecv.RemoveAt(selectedIndex);
                }
            }
            #region
            //DataRowView rowView = DataGrid1.SelectedItems[0] as DataRowView;


            // DataRowView row = (DataRowView)DataGrid1.SelectedCells.;
            //ObservableCollection<DataRow> data = (ObservableCollection<DataRow>)DataGrid1.ItemsSource;
            //data.Remove(row);

            //DataGrid1.Items.Remove(selectedRow);
            // List.Remove(SelectedDataGrid1Item);


            //  DataSet1.OurTableRow GetSelectedRow()
            //  {
            //      String SelectedPraktikaID = DataGrid1.CurrentRow.Cells["PropId"].value.toString;
            //      DataSet1.OurTableRow SelectedRow =
            //OurTableDataTable.FindByPropID(SelectedPraktikaID);
            //      return SelectedRow;
            //  }

            //  GetSelectedRow().Delete();

        }
        #endregion
        //закрыть представление
        private void SwitchOff_Click(object sender, RoutedEventArgs e)
        {
            connection.Close();
            Application.Current.Shutdown();
        }
        //сохранить
        private void save_Click(object sender, RoutedEventArgs e)
        {
            _ = PraktikaTableAdapter1.Update(TableDataset1.OurTable);
        }
        //посмотреть какая строка выбрана и выбрана ли вообще
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           if (DataGrid1.SelectedIndex >= 0) 
            { 
            int selectedIndex = DataGrid1.SelectedIndex+1;

            
            update1.Content = "Вы выбрали строку " + selectedIndex;
            }
           else
            {
                update1.Content = "Вы ещё не выбрали строку";
            }
        }
    }
}
