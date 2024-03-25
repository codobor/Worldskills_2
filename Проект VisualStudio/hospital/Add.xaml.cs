using System;
using System.Collections.Generic;
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
using MySql.Data.MySqlClient;

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        string connectionString = database.getConnection();

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = $"INSERT INTO clients(Surname, Name, Passport, OMS, Job) VALUES ('{textBoxSurname.Text}','{textBoxName.Text}','{textBoxPassport.Text}','{textBoxOMS.Text}','{textBoxJob.Text}')";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Добавление успешно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
