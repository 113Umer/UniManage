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
    /// Interaction logic for SubjectsForm.xaml
    /// </summary>
    public partial class SubjectsForm : Window
    {
        private AppDbContext db = new AppDbContext();
        private int studentId;
        public SubjectsForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            var subjects = db.Subjects
                .Where(s => s.StudentID == studentId) 
                .ToList();

            // Check if any subjects were found
            if (subjects != null && subjects.Count > 0)
            {
                SubjectsListView.ItemsSource = subjects;
            }
            else
            {
                MessageBox.Show("No subjects found for the specified student.");
            }
        }

        private void SubjectsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
