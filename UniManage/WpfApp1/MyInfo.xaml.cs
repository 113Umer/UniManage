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
    public partial class MyInfo : Window
    {
        private int studentId;
        public MyInfo(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void StudentInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var studentInfoForm = new StudentInfoForm(studentId);
            studentInfoForm.Show();
        }

        private void SubjectsButton_Click(object sender, RoutedEventArgs e)
        {
            var subjectsForm = new SubjectsForm(studentId);
            subjectsForm.Show();
        }

        private void AssignmentsButton_Click(object sender, RoutedEventArgs e)
        {
            var assignmentsForm = new AssignmentsForm(studentId);
            assignmentsForm.Show();
        }
    }
}
