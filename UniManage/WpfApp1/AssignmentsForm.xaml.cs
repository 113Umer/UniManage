using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class AssignmentsForm : Window
    {
        private AppDbContext db = new AppDbContext();
        private int studentId; // Assume you pass the student ID when opening this form.

        public AssignmentsForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadAssignments();
        }

        private void LoadAssignments()
        {
            var assignments = db.Assignments
                .Where(a => a.StudentID == studentId) // Filter by student ID
                .ToList();

            // Check if any assignments were found
            if (assignments != null && assignments.Count > 0)
            {
                AssignmentsListView.ItemsSource = assignments;
            }
            else
            {
                MessageBox.Show("No assignments found for the specified student.");
            }
        }

        private void AssignmentsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
