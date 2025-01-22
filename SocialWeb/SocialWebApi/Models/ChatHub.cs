using Microsoft.AspNetCore.SignalR;

namespace SocialWebApi.Models
{
    public class ChatHub : Hub
    {
        public SocialWebEntities db = new SocialWebEntities();

        //public void SendMessage(int dialogId, string message, string userName)
        //{
        //    Clients.Group(dialogId.ToString()).ReceiveMessage(dialogId, message, userName);
        //}

        //public void JoinChat(int dialogId)
        //{
        //    Groups.Add(Context.ConnectionId, dialogId.ToString());
        //}
    }
}