using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data.SqlClient;
using Wpf_Control3.DataSet1TableAdapters;

namespace Wpf_Control3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection();
        string connection2 = @"Provider=SQLNCLI11;Data Source=DENIS-COMP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PraktikaDB";

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
                //connection.Close();
                MessageBox.Show("Соединение с базой данных открыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }
            OleDbCommand command = new OleDbCommand();
           command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM OurTable";
            int number = (int)command.ExecuteScalar();
            label1.Content = number.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM OurTable";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListBox1.Items.Add(reader["nCanonId"].ToString());
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string cmd = "SELECT * FROM OurTable";
            OleDbCommand command1 = new OleDbCommand(cmd, connection);
            //OleDbDataReader reader = command1.ExecuteReader();
            OleDbDataAdapter dataAdp = new OleDbDataAdapter(command1);
            DataTable dt = new DataTable("OurTable");
            dataAdp.Fill(dt);
            DataGrid1.ItemsSource = dt.DefaultView;
        }

        private void addstring_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deletestring_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RollBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SwitchOff_Click(object sender, RoutedEventArgs e)
        {
            connection.Close();
            Application.Current.Shutdown();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
