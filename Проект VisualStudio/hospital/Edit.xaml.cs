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
using System.Data;

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit(DataRowView row)
        {
            InitializeComponent();
            labelID.Content = row.Row.ItemArray[0].ToString();
            textBoxSurname.Text = row.Row.ItemArray[1].ToString();
            textBoxName.Text = row.Row.ItemArray[2].ToString();
            textBoxPassport.Text = row.Row.ItemArray[3].ToString();
            textBoxOMS.Text = row.Row.ItemArray[4].ToString();
            textBoxJob.Text = row.Row.ItemArray[5].ToString();
        }

        string connectionString = database.getConnection();

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = $"UPDATE clients SET Surname = '{textBoxSurname.Text}', Name = '{textBoxName.Text}', Passport = '{textBoxPassport.Text}', OMS = '{textBoxOMS.Text}', Job = '{textBoxJob.Text}' WHERE clientID = {labelID.Content}";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Изменение успешно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
