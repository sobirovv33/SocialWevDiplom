using SocialWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SocialWebApi.Controllers
{
    public class UsersController : ApiController
    {
        public SocialWebEntities db = new SocialWebEntities();

        [HttpGet]
        [Route("api/Users/GetUsers")]
        public IHttpActionResult GetUsers()
        {
            var users = db.Users.ToList();

            return Ok(users.Select(x => new
            {
                x.Surname,
                x.Email
            }).ToList());
        }
        [HttpGet]
        [Route("api/Users/GetUser/{id}")]
        public IHttpActionResult GetUser(int id)
        {
            var user = db.Users.FirstOrDefault(x=>x.idUser == id);

            return Ok(new
            {
                user.Name,
                user.Email
            });
        }

        [HttpPost]
        [Route("api/Users/Authenticate")]
        public IHttpActionResult Authenticate(LoginData loginData)
        {
            var user = db.Users.FirstOrDefault(x => x.PhoneNumber == loginData.PhoneNumber && x.Password == loginData.Password);
            return Ok(new
            {
                user.Name,
                user.Surname,
                user.LastName,
                user.Email,
                user.Password,
                user.PhoneNumber,
                user.DataBirthDay,
            });
        }
    }
}
