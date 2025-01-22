using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialWebApi.Models
{
    public class FriendAdd
    {
        public int idFriendship {  get; set; }
        public int idUser { get; set; }
        public int idFriend { get; set; }
        public int idAppStatus { get; set; }
        public bool isFriend { get; set; }
        public DateTime RequestDate { get; set; }
    }
}