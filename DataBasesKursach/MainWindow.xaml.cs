
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
            string connString = "Server=127.0.0.1;Database=kusrchsheme;port=3306;User Id=" + userBox.Text + ";password=" + pasBox.Password;
            MySqlConnection connection = new MySqlConnection(connString);
            try 
            {
                //Window1 window1 = new Window1();
                //window1.Show();
                connection.Open();
            }
            catch (Exception ex)
            {
                                                //TODO text change user/password
                userBox.Text = "asda";          //TODO wrong password animation
            }
            finally 
            {
                if(connection.State == System.Data.ConnectionState.Open) 
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();
                    
                }
            }

            

            
        }

        private void userBox_GotFocus(object sender, RoutedEventArgs e)
        {
            userBox.Clear();
        }

        private void pasBox_GotFocus(object sender, RoutedEventArgs e)
        {
            pasBox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
