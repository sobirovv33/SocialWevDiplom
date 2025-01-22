using SocialWeb.Services;
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
    public partial class AddFriendPage : Page
    {
        public AddFriendPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private async void LoadUsers()
        {
            var users = await NetManager.Get<List<AuthenticatedUser>>("Users/GetUsers");
            LVFriends.ItemsSource = users;
        }

        private async void BTAddFriend_Click(object sender, RoutedEventArgs e)
        {
            var friend = new FriendAdd();
            var selectedUser = LVFriends.SelectedItem as FriendAdd;

            if (selectedUser != null)
            {
                var addUser = await NetManager.Post<FriendAdd>("Friends/AddFriend", friend);
            }
        }
    }
}
