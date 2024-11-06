using SocialWeb.Models;
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
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            DataContext = App.LogedToUser;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.LogedToUser.ImageUser == null)
            {
                UserImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Icoms/userIcon.png"));
            }
        }

        private void BTEditProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProfilePage());
        }

        private void BTAddPost_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
