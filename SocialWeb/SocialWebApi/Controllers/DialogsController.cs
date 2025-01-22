using SocialWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialWebApi.Controllers
{
    public class DialogsController : ApiController
    {
        public SocialWebEntities _db = new SocialWebEntities();

        [HttpGet]
        [Route("api/Chat/GetChats/{userId}")]
        public IHttpActionResult GetChats(int userId)
        {
            var chats = _db.DialogUsers.Where(d => d.idUser == userId)
                .Select(x => new
                {
                    x.Dialog.idDialog,
                    x.Dialog.Name,
                    LastMessage = _db.DialogMessage.Where(lm => lm.idDialog == x.idDialog)
                    .OrderByDescending(ob => ob.DateOfSender)
                    .Select(ob => new
                    {
                        ob.TextSender,
                        ob.DateOfSender
                    }).FirstOrDefault()
                }).ToList(); 
            return Ok(chats);
        }

        [HttpGet]
        [Route("api/Chat/GetMessage/{dialogId}")]
        public IHttpActionResult GetMessage(int dialogId)
        {
            var messages = _db.DialogMessage.Where(x => x.idDialog == dialogId)
                .OrderBy(g => g.DateOfSender).Select(y => new
                {
                    y.TextSender,
                    y.DateOfSender,
                    UserName = y.Users.Name
                }).ToList();
            return Ok(messages);
        }

        [HttpGet]
        [Route("api/Chat/SendMessage")]
        public IHttpActionResult SendMessage(DialogMessage message)
        {
            _db.DialogMessage.Add(message);
            _db.SaveChanges();
            return Ok(message);
        }

        [HttpGet]
        [Route("api/Chat/CreateChat")]
        public IHttpActionResult CreateChat(Dialog dialog)
        {
            _db.Dialog.Add(dialog);
            _db.SaveChanges();
            return Ok(dialog);
        }
    }
}
