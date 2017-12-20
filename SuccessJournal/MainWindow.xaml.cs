using System;
using System.Windows;
using MahApps.Metro.Controls;
using System.Windows.Input;

namespace SuccessJournal
{
    public partial class MainWindow : MetroWindow
    {
        public static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
        }

        //private void MetroWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    if (e.Key == Key.Escape)
        //    {
        //        int currentMenuItem = MainPage.instance.lstMenu.SelectedIndex;
        //        switch (currentMenuItem)
        //        {
        //            case 0: TasksPage.instance.Restore(); break;
        //            case 1: ProjectsPage.instance.Restore(); break;
        //            case 2: TeamsPage.instance.Restore(); break;
        //            case 3: MembersPage.instance.Restore(); break;
        //            case 4: PostsDirectoryPage.instance.Restore(); break;
        //            default: break;
        //        }
        //    }
        //}
    }
}
