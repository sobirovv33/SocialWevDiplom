using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SocialWeb.Services
{
    public class FriendAdd
    {
        //[JsonProperty("id_user")]
        //"id_user"
        //"IdUser"
        public int idFriendship { get; set; }
        public int idUser { get; set; }
        public int idFriend { get; set; }
        public int idAppStatus { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
