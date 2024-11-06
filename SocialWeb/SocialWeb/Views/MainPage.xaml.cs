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

namespace SocialWeb.Views
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private bool isSidebarOpen = false;
        private void BTToggleSidebar_Click(object sender, RoutedEventArgs e)
        {
            if (!isSidebarOpen)
            {
                SidebarColumn.Width = new GridLength(200);
                BTToggleSidebar.SetValue(Grid.ColumnProperty, 0);
                BTToggleSidebar.Width = 200;
            }
            else
            {
                SidebarColumn.Width = new GridLength(0);
                BTToggleSidebar.SetValue(Grid.ColumnProperty, 1);
                BTToggleSidebar.Width = 40;
            }
            isSidebarOpen = !isSidebarOpen;
        }

        private void BTProfile_Click(object sender, RoutedEventArgs e)
        {
            EnterFrame.Navigate(new ProfilePage());
        }

        private void BTListFriends_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
