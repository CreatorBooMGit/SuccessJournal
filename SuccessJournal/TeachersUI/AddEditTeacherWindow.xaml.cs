using Domain;
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

namespace SuccessJournal.TeachersUI
{
    /// <summary>
    /// Логика взаимодействия для AddEditTeacherWindow.xaml
    /// </summary>
    public partial class AddEditTeacherWindow : Window
    {
        public static AddEditTeacherWindow instance;
        private Teacher teacher;

        public AddEditTeacherWindow(Teacher p_teacher = null)
        {
            InitializeComponent();
            instance = this;

            teacher = p_teacher;

            if (teacher != null)
            {
                btnAddTeacher.Content = "Edit teacher";
                txtName.Text = teacher.Fullname;
            }
        }

        public Teacher GetTeacher() => teacher;

        private void btnAddTeacher_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length == 0)
                return;

            if (teacher == null)
                teacher = new Teacher();

            teacher.Fullname = txtName.Text;

            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            teacher = null;

            Close();
        }
    }
}
