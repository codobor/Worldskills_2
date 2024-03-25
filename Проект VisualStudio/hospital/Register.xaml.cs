using MySql.Data.MySqlClient;
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

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        string connectionString = database.getConnection();

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string pass = passwordBoxPass.Password;

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                string hashPass = hash.hashPassword(pass);
                connection.Open();
                string query = $"INSERT INTO users VALUES('{login}', '{hashPass}')"; 
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void textBlockLogin_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
