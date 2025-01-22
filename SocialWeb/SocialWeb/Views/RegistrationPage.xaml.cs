using SocialWeb.Models;
using SocialWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }


        private async void BtSave_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(TBName.Text))
            {
                NameErrorText.Visibility = Visibility.Visible;
                NameErrorText.Text = "Имя не может быть пустым!";
                isValid = false;
            }
            else if (!Regex.IsMatch(TBName.Text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                NameErrorText.Visibility = Visibility.Visible;
                NameErrorText.Text = "Имя может содержать только буквы.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(TBSurname.Text))
            {
                SurnameErrorText.Visibility = Visibility.Visible;
                SurnameErrorText.Text = "Фамилия не может быть пустой!";
                isValid = false;
            }
            else if (!Regex.IsMatch(TBSurname.Text, @"^[a-zA-Zа-яА-Я]+$"))
            {
                SurnameErrorText.Visibility = Visibility.Visible;
                SurnameErrorText.Text = "Фамилия может содержать только буквы.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(TbLastName.Text))
            {
                LastNameErrorText.Visibility = Visibility.Visible;
                LastNameErrorText.Text = "Отчество не может быть пустым!";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(TbPhoneNumber.Text))
            {
                PhoneNumberErrorText.Visibility = Visibility.Visible;
                PhoneNumberErrorText.Text = "Номер телефона не может быть пустым!";
                isValid = false;
            }
            else if (!Regex.IsMatch(TbPhoneNumber.Text, @"^\+7[0-9]{10}$"))
            {
                PhoneNumberErrorText.Visibility = Visibility.Visible;
                PhoneNumberErrorText.Text = "Пожалуйста, введите номер в формате: +7XXXXXXXXXX.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(PBPassword.Text))
            {
                PasswordErrorText.Visibility = Visibility.Visible;
                PasswordErrorText.Text = "Пожалуйста, введите пароль!";
                isValid = false;
            }
            else if (!Regex.IsMatch(PBPassword.Text, @"^[a-zA-Z0-9]+$"))
            {
                PasswordErrorText.Visibility = Visibility.Visible;
                PasswordErrorText.Text = "Пароль может содержать только цифры и латинские буквы.";
                isValid = false;
            }

            if (DpBirthDay.SelectedDate == null)
            {
                DateBirthDayErrorText.Visibility = Visibility.Visible;
                DateBirthDayErrorText.Text = "Выберите дату рождения!";
                isValid = false;
            }

            if (isValid)
            {
                var loginData = new AuthenticatedUser
                {
                    Name = TBName.Text,
                    Surname = TBSurname.Text,
                    LastName = TbLastName.Text,
                    PhoneNumber = TbPhoneNumber.Text,
                    Password = TbPhoneNumber.Text,
                    DataBirthDay = (DateTime)DpBirthDay.SelectedDate
                    
                };

                var logedUser = await NetManager.Post<AuthenticatedUser>("Users/Registration", loginData);
                MessageBox.Show("Вы успешно зарегистрировались!");
            }
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
