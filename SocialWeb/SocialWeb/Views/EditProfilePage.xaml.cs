using Microsoft.Win32;
using SocialWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class EditProfilePage : Page
    {
        public EditProfilePage()
        {
            InitializeComponent();
            DataContext = App.LogedToUser;
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TBAddImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var user = App.LogedToUser;
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }

            var imageUser = App.Db.Users.FirstOrDefault(x => x.idUser == user.idUser);
            if (imageUser == null)
            {
                MessageBox.Show("Пользователь не найден в базе данных.");
                return;
            }

            var selectImage = new OpenFileDialog();
            selectImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (selectImage.ShowDialog().GetValueOrDefault())
            {
                try
                {
                    imageUser.ImageUser = File.ReadAllBytes(selectImage.FileName);
                    App.Db.SaveChanges();
                    MessageBox.Show("Изображение успешно обновлено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изображения: {ex.Message}");
                }
            }
        }

        private void BTSave_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(TbName.Text) == true)
            {
                NameErrorText.Visibility = Visibility.Visible;
                NameErrorText.Text = "Имя не может быть пустым!";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TbSurname.Text) == true)
            {
                SurnameErrorText.Visibility = Visibility.Visible;
                SurnameErrorText.Text = "Фамилия не может быть пустым!";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TbLastName.Text) == true)
            {
                LastNameErrorText.Visibility = Visibility.Visible;
                LastNameErrorText.Text = "Фамилия не может быть пустым!";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(TbPhoneNumber.Text) == true)
            {
                PhoneNumberErrorText.Visibility = Visibility.Visible;
                PhoneNumberErrorText.Text = "Номер телефона не может быть пустым!";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(DpBirthday.Text) == true)
            {
                DpBirhDayErrorText.Visibility = Visibility.Visible;
                DpBirhDayErrorText.Text = "Дата рождения не может быть пустым!";
                isValid= false;
            }
            if (isValid)
            {
                App.Db.SaveChanges();
                MessageBox.Show("Данные успешно изменены!");
                NavigationService.GoBack();
            }
        }
    }
}
