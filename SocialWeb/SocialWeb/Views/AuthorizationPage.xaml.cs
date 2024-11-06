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
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BtEnter_Click(object sender, RoutedEventArgs e)
        {
            var login = TbPhoneNumber.Text;
            var password = PbPassword.Password;

            var logedUser = App.Db.Users.FirstOrDefault(x => x.PhoneNumber == login && x.Password == password);
            
            if(string.IsNullOrWhiteSpace(TbPhoneNumber.Text) == true)
            {
                LoginTextError.Visibility = Visibility.Visible;
                LoginTextError.Text = "Введите номер телефона!";
            }
            else if (!Regex.IsMatch(TbPhoneNumber.Text, @"^\+7[0-9]{10}$"))
            {
                LoginTextError.Visibility = Visibility.Visible;
                LoginTextError.Text = "Пожалуйста, введите номер в формате: +7XXXXXXXXXX.";
            }
            if (string.IsNullOrWhiteSpace(PbPassword.Password) == true)
            {
                PasswordTextError.Visibility = Visibility.Visible;
                PasswordTextError.Text = "Введите пароль!";
            }
            else if (!Regex.IsMatch(PbPassword.Password, @"^[a-zA-Z0-9]+$"))
            {
                PasswordTextError.Visibility = Visibility.Visible;
                PasswordTextError.Text = "Пароль может содержать только цифры и латинские буквы!";
            }
            if (logedUser == null)
            {
                MessageBox.Show("Логин или пароль не существует!");
                return;
            }
            App.LogedToUser = logedUser;
            NavigationService.Navigate(new MainPage());
        }

        private void BtRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
