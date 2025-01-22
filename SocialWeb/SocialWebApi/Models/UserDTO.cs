using System;
using System.Web;

namespace SocialWebApi.Models
{
    public class UserDTO
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public DateTime DataBirthDay { get; set; }
        public string Email { get; set; }
        public byte[] ImageUser { get; set; }

        public int idRole = 2;
    }
}