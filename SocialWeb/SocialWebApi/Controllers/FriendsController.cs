using SocialWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialWebApi.Controllers
{
    public class FriendsController : ApiController
    {
        public SocialWebEntities db = new SocialWebEntities();

        [HttpPost]
        [Route("api/Friend/SendRequest")]
        public IHttpActionResult SendRequest(int userId, int friendId)
        {
            var request = db.Friends.FirstOrDefault(x => x.idUser == userId && x.idFried == friendId);

            if (request != null)
            {
                return BadRequest("Запрос уже существует!");
            }

            var friendRequest = new Friends
            {
                idUser = userId,
                idFried = friendId,
                idAppStatus = 1,
                RequestDate = DateTime.Now
            };
            db.Friends.Add(friendRequest);
            db.SaveChanges();
            return Ok("Запрос отправлен!");
        }

        [HttpPost]
        [Route("api/Friend/AcceptRequest")]
        public IHttpActionResult AcceptRequest(int friendshipId)
        {
            var request = db.Friends.FirstOrDefault(x => x.idFriendship == friendshipId);

            if (request == null)
            {
                return NotFound();
            }
            request.idAppStatus = 2;
            request.isFriend = true;
            db.SaveChanges();

            return Ok("Запрос принят!");
        }

        [HttpPost]
        [Route("api/Friend/RejectRequest")]
        public IHttpActionResult RejectRequest(int friendshipId)
        {
            var request = db.Friends.FirstOrDefault(x => x.idFriendship == friendshipId);

            if (request == null)
            {
                return NotFound();
            }

            db.Friends.Remove(request);
            db.SaveChanges();

            return Ok("Запрос отклонен!");
        }

        [HttpGet]
        [Route("api/Friend/GetFriends/{userId}")]
        public IHttpActionResult GetFriends(int userId)
        {
            var friends = db.Friends.Where(x => x.idUser == userId && x.idAppStatus == 2)
                .Select(y => new FriendDTO
                {
                    Name = y.Users1.Name,
                    Surname = y.Users1.Surname,
                    ImageUser = y.Users1.ImageUser,
                }).ToList();
            return Ok(friends);
        }

        [HttpGet]
        [Route("api/Friend/GetRequests/{userId}")]
        public IHttpActionResult GetRequests(int userId)
        {
            var requests = db.Friends.Where(x => x.idFried == userId && !x.isFriend)
                .Select(y => new
                {
                    y.idFriendship,
                    RequesterId = y.idUser,
                    Name = y.Users.Name,
                    Surname = y.Users.Surname,
                    RequestDate = y.RequestDate,
                    Status = y.ApplicationStatus.Name
                }).ToList();
            return Ok(requests);
        }
    }
}
