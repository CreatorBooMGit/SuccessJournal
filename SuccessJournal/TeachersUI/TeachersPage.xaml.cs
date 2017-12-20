using Domain;
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

namespace SuccessJournal.TeachersUI
{
    /// <summary>
    /// Логика взаимодействия для TeachersPage.xaml
    /// </summary>
    public partial class TeachersPage : Page
    {
        public static TeachersPage instance;
        public TeachersManagment teachersManagment;

        public TeachersPage()
        {
            InitializeComponent();
            instance = this;

            teachersManagment = new TeachersManagment();
            teachersManagment.Load();
        }

        private void UpdateTeachers()
        {
            teachersManagment.Load();
            grdTeachers.Items.Refresh();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdTeachers.ItemsSource = teachersManagment.GetList();
            UpdateTeachers();
        }

        private void btnCreateTeacher_Click(object sender, RoutedEventArgs e)
        {
            AddEditTeacherWindow addEditTeacherWindow = new AddEditTeacherWindow();
            addEditTeacherWindow.ShowDialog();

            if(addEditTeacherWindow.GetTeacher() != null)
            {
                teachersManagment.Insert(addEditTeacherWindow.GetTeacher());
                teachersManagment.SaveChanges();

                UpdateTeachers();
            }
        }

        private void btnRemoveTeacher_Click(object sender, RoutedEventArgs e)
        {
            if (grdTeachers.SelectedItem == null)
                return;

            teachersManagment.Delete((Teacher)grdTeachers.SelectedItem);
            teachersManagment.SaveChanges();

            UpdateTeachers();
        }

        private void MenuItem_EditTeacher_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
