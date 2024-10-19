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

namespace WpfApp1
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
        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if(username == "admin" && password == "admin")
            {
                MessageBox.Show("Admin Logged In!");
                Close();
            }

            else
            {
                MessageBox.Show("Incorrect Username/Password!");
            }
        }

        // Remove placeholder text when the user focuses on the TextBox
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Username" || textBox.Text == "Password")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        // Add placeholder text when the user leaves the TextBox empty
        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == UsernameTextBox)
                {
                    textBox.Text = "Username";
                }
                else if (textBox == PasswordTextBox)
                {
                    textBox.Text = "Password";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
