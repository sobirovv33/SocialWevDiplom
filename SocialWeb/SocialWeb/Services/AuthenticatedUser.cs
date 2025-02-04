﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWeb.Services
{
        public class AuthenticatedUser
        {
            public int idUser { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string LastName {  get; set; }
            public DateTime DataBirthDay { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public byte[] ImageUser { get; set; }
        }
}
