using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SocialWeb.Models;

namespace SocialWeb
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SocialWebEntities Db = new SocialWebEntities();
        public static Users LogedToUser;
    }
}
