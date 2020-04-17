
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBasesKursach
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

        private void Button_Click(object sender, RoutedEventArgs e)                     //login to db method
        {
            string connString = "Server=localhost;Database=logindb;port=3306;User Id=" + userBox.Text + ";password=" + pasBox.Password;
            MySqlConnection connection = new MySqlConnection(connString);
            try 
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                                                //TODO text change user/password
                userBox.Text = "asda";          //TODO wrong password animation
            }
            finally 
            {
                this.Close();
                connection.Close();
            }
        }
    }
}
