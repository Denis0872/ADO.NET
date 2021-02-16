using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=denis;Initial Catalog=Praktikadb;Data Source=DENIS-COMP\SQLEXPRESS";
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.StateChange += new
                StateChangeEventHandler(
                connection_StateChange);

        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string testConnect = GetConnectionStringByName("PraktikaDB");
        private void опцияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
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
            label1.Text = number.ToString();
            
            //connection.Close();
           // MessageBox.Show("Соединение с базой данных закрыто");

        }
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            включеноToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Open);
            выключеноToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
        }

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                    MessageBox.Show("configuration = " + cs.CurrentConfiguration);
                }
            }

        }

        private void выключитьбазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных   закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных не открыто");
               //Application.Exit();
        }

        private void включитьбазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }

            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, se.SQLState +
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void статусБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { 
            if (connection.State == ConnectionState.Open)
            {

                MessageBox.Show("Соединение с базой установлено");
            }
            else
                MessageBox.Show("Соединение с базой данных отсутствует");


            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT nCanonId FROM OurTable";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                {
                listView1.Items.Add(reader["nCanonId"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}



