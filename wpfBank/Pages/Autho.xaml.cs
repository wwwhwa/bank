using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfBank.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLogin.Text) && !String.IsNullOrEmpty(tbPassword.Text))
            {
                LoginUser();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
            }
        }
        String server_name = "HWAYA\\HWAYA";
        String data_base = "21.101_10_bank";
        String table_name = "Users";

        private void LoginUser()
        {

            var db = new SqlConnection($"Data Source={server_name};Initial Catalog={data_base};Integrated Security=True");

            var user = new User();
            user.Login = tbLogin.Text;
            user.Password = tbPassword.Text;

            if (!db.State.Equals(ConnectionState.Open))
            {
                db.Open();
            }

            string query = $"SELECT Name, Surname, Patronymic FROM {table_name} WHERE Login = '{user.Login}' AND Password = '{user.Password}'";
            SqlCommand cmd = new SqlCommand(query, db);
            cmd.Parameters.AddWithValue("Login", user.Login);
            cmd.Parameters.AddWithValue("Password", user.Password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                NavigationService.Navigate(new Log(user));
                tbLogin.Text = "";
                tbPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

            db.Close();
        }
    }
}
