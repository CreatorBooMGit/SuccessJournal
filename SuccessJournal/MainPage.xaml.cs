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

namespace SuccessJournal
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void lstMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentsUI.IsEnabled = false;
            StudentsUI.Visibility = Visibility.Hidden;

            SubjectsUI.IsEnabled = false;
            SubjectsUI.Visibility = Visibility.Hidden;

            TeachersUI.IsEnabled = false;
            TeachersUI.Visibility = Visibility.Hidden;

            //MembersUI.IsEnabled = false;
            //MembersUI.Visibility = Visibility.Hidden;

            //PostsDirectoryUI.IsEnabled = false;
            //PostsDirectoryUI.Visibility = Visibility.Hidden;

            switch (lstMenu.SelectedIndex)
            {
                case 0:
                    {
                        //TasksUI.IsEnabled = true;
                        //TasksUI.Visibility = Visibility.Visible;

                        break;
                    }

                case 1:
                    {
                        StudentsUI.IsEnabled = true;
                        StudentsUI.Visibility = Visibility.Visible;

                        break;
                    }

                case 2:
                    {
                        SubjectsUI.IsEnabled = true;
                        SubjectsUI.Visibility = Visibility.Visible;
                        break;
                    }

                case 3:
                    {
                        TeachersUI.IsEnabled = true;
                        TeachersUI.Visibility = Visibility.Visible;

                        break;
                    }

            }

            MenuToggleButton.IsChecked = false;
        }
    }
}
