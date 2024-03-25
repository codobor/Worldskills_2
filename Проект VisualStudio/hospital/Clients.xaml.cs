using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для Patients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
            fillDataGridClients();
        }

        public void fillDataGridClients()
        {
            try
            {
                string query = "SELECT * FROM clients";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                conn.Open();
                adapter.Fill(table);
                dataGridClients.ItemsSource = table.DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string connectionString = database.getConnection();

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = dataGridClients.SelectedItem as DataRowView;
                if (row != null)
                {
                    string query = $"DELETE FROM clients WHERE clientID = {row.Row.ItemArray[0].ToString()}";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(query, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Удаление успешно");
                    fillDataGridClients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dataGridClients.SelectedItem as DataRowView;
            if (row != null)
            {
                Edit edit = new Edit(row);
                edit.Show();
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            fillDataGridClients();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

    }
}
