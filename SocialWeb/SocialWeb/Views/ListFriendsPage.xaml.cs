using SocialWeb.Models;
using SocialWeb.Services;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SocialWeb.Views
{
    public partial class ListFriendsPage : Page
    {
        public ListFriendsPage()
        {
            InitializeComponent();
            LoadFriends();
        }

        private async void LoadFriends()
        {
            var userId = App.LogedToUser.idUser;
            var friendList = await NetManager.Get<List<Friend>>($"Friend/GetFriends/{userId}");
            
            if (friendList != null)
            {
                LVFriends.ItemsSource = friendList;
                return;
            }
            TbFriendText.Visibility = Visibility.Visible; 
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtAddFriend_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddFriendPage());
        }
    }
}
