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
    public partial class ListFriendsPage : Page
    {
        public ListFriendsPage()
        {
            InitializeComponent();
            LoadFriends();
        }

        private void LoadFriends()
        {
            var userId = App.LogedToUser.idUser;
            var friends = App.Db.Friends
                .Where(f => (f.idUser == userId || f.idFried == userId))
                .Select(f => new 
                {
                    UserId = f.idUser == userId ? f.idFried : f.idUser,
                    Name = f.Users.Name,
                    Surname = f.Users.Surname,
                    ImageUser = f.Users.ImageUser,
                    IsFriend = true
                }).ToList();

            LVFriends.ItemsSource = friends;
            
            if (friends != null)
            {
                TbFriendText.Visibility = Visibility.Visible;
            }
            else
            {
                TbFriendText.Visibility= Visibility.Collapsed;
            }
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            LVFriends.ItemsSource =  App.Db.Users.Where(x => x.Name.Contains(TBSearch.Text)).ToList();
        }
    }
}
