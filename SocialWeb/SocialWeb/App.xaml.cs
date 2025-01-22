using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SocialWeb.Models;
using SocialWeb.Services;

namespace SocialWeb
{
    public partial class App : Application
    {
        public static SocialWebEntities Db = new SocialWebEntities();
        public static AuthenticatedUser LogedToUser;
    }
}
