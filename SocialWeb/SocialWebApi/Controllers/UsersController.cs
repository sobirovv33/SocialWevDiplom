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
                x.ImageUser,
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

        //Api sessia

        [HttpPost]
        [Route("api/Users/Authenticate")]
        public IHttpActionResult Authenticate(UserDTO loginData)
        {
            var user = db.Users.FirstOrDefault(x => x.PhoneNumber == loginData.PhoneNumber && x.Password == loginData.Password);
            return Ok(new
            {
                user.idUser,
                user.Name,
                user.Surname,
                user.LastName,
                user.Email,
                user.Password,
                user.PhoneNumber,
                user.DataBirthDay,
            });
            //return Ok(new UserDTO()
            //{
            //    Name = user.Name,
            //    user.Surname,
            //    user.LastName,
            //    user.Email,
            //    user.Password,
            //    user.PhoneNumber,
            //    user.DataBirthDay,
            //});
        }

        [HttpPost]
        [Route("api/Users/Registration")]
        public IHttpActionResult Registration(UserDTO loginData)
        {
            var user = new Users
            {
                Name = loginData.Name,
                Surname = loginData.Surname,
                LastName = loginData.LastName,
                PhoneNumber = loginData.PhoneNumber,
                Password = loginData.Password,
                Email = loginData.Email,
                DataBirthDay = loginData.DataBirthDay,
                ImageUser = loginData.ImageUser,
                RoleId = loginData.idRole,
            };

            if (user != null)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        [Route("api/Users/UpdateProfile")]
        public IHttpActionResult UpdateProfile(UserDTO logindata)
        {
            var user = new Users
            {
                Name = logindata.Name,
                Surname = logindata.Surname,
                LastName = logindata.LastName,
                PhoneNumber = logindata.PhoneNumber,
                Password = logindata.Password,
                Email = logindata.Email,
                DataBirthDay = logindata.DataBirthDay,
                ImageUser = logindata.ImageUser,
                RoleId = logindata.idRole,
            };

            if (user != null)
            {
                db.SaveChanges();
            }
            return Ok();
        }
        //[HttpGet]
        //[Route("api/Users/SearchUser")]
        //public IHttpActionResult SearchUser(string searchUser)
        //{
            
        //}
    }
}
