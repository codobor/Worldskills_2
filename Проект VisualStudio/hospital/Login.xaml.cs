using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        string connectionString = database.getConnection();

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string pass = passwordBoxPass.Password;

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                string hashPass = hash.hashPassword(pass);
                connection.Open();
                string query = $"SELECT login FROM users WHERE login = '{login}' AND pass = '{hashPass}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                if (command.ExecuteScalar() == null)
                {
                    MessageBox.Show("Неправильный пароль");
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            

        }

        private void textBlockRegister_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}
