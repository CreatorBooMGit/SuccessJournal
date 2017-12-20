using Logic.Managments;
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

namespace SuccessJournal.StudentsUI
{
    /// <summary>
    /// Логика взаимодействия для StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        public static StudentsPage instance;
        public StudentsManagment studentsManagment;

        public StudentsPage()
        {
            InitializeComponent();
            instance = this;

            studentsManagment = new StudentsManagment();
            studentsManagment.Load();
        }

        private void UpdateStudents()
        {
            studentsManagment.Load();
            lstStudents.Items.Refresh();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            lstStudents.ItemsSource = studentsManagment.GetList();
            UpdateStudents();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFindStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFindSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lstSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddMark_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemoveMark_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
