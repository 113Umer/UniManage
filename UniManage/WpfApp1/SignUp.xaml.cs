using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class SignUp : Window
    {   
        private AppDbContext db = new AppDbContext();

        public SignUp()
        {
            InitializeComponent();
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Email Address" || textBox.Text == "Password" || textBox.Text == "Full Name")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == EmailTextBox)
                {
                    textBox.Text = "Email Address";
                }
                else if (textBox == PasswordTextBox)
                {
                    textBox.Text = "Password";
                }
                else if (textBox == FullNameTextBox)
                {
                    textBox.Text = "Full Name";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Collect data from the text boxes
            string fullName = FullNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            // Validate input data
            if (fullName == "Full Name" || email == "Email Address" || password == "Password")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if the email already exists in the database
            var existingStudent = db.Students.FirstOrDefault(s => s.Email == email);

            if (existingStudent != null)
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            // Create a new Student object
            Student newStudent = new Student
            {
                FullName = fullName,
                Email = email,
                Password = password
            };

            // Insert new student into the database
            db.Students.Add(newStudent);
            db.SaveChanges();

            MessageBox.Show("Sign up successful!");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void FullNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
