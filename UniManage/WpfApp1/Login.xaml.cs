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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Students.SingleOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    int ID = user.StudentID;
                    MessageBox.Show("Logged In Successfully!");
                    MyInfo info = new MyInfo(ID);
                    info.Show();
                    this.Close();           
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password!");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }

        // Remove placeholder text when the user focuses on the TextBox
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Email Address" || textBox.Text == "Password")
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
                    textBox.Text = "Email Address";
                }
                else if (textBox == PasswordTextBox)
                {
                    textBox.Text = "Password";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }
    }
}
