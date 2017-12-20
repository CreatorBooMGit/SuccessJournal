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

namespace SuccessJournal.SubjectsUI
{
    /// <summary>
    /// Логика взаимодействия для SubjectsPage.xaml
    /// </summary>
    public partial class SubjectsPage : Page
    {
        public static SubjectsPage instance;
        public SubjectsManagment subjectsManagment;

        public SubjectsPage()
        {
            InitializeComponent();
            instance = this;

            subjectsManagment = new SubjectsManagment();
            subjectsManagment.Load();
        }

        private void UpdateSubjects()
        {
            subjectsManagment.Load();
            grdSubjects.Items.Refresh();
        }

        private void btnCreateSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemoveSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_EditSubject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSubjects.ItemsSource = subjectsManagment.GetList();
            UpdateSubjects();
        }
    }
}
