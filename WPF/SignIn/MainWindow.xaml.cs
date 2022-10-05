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
using System.Xml.Linq;

namespace SignIn
{
    static class DB
    {
        //public static string TestDB = "Admin";
        public static Dictionary<string, string> TestDB = new Dictionary<string, string>()
            {
                { "user1@ukr.net", "user1"},
                { "user2@gmail.com", "user2"},
                { "user3@knute.edu.ua", "user3"}
            };
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email.Text) && !string.IsNullOrWhiteSpace(Password.Password))
            { 
                if (Email.Text == "admin@admin" && Password.Password == "admin") { 
                    MessageBox.Show("You've autorised as an admin. Welcome!");
                } 
                else if (DB.TestDB.ContainsKey(Email.Text) && DB.TestDB.ContainsValue(Password.Password))
                {
                    MessageBox.Show("You've autorised as a user. Welcome!");
                }
                else {
                    MessageBox.Show("Invalid credentials!");
                }
                Email.Clear();
                Password.Clear();
            }
            else {
                MessageBox.Show("Заповніть обидва поля");
            }
        }
    }
}
