using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wings_api.Data;
using wings_api.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace wings_api.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly WingsContext db;

        public UsersController(WingsContext context)
        {
            db = context;
        }
        

        /// <summary>
        /// Retrieve all users
        /// </summary>
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User> users = new User[] { };
            users = db.Users.ToList();
            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = db.Users.Find(id);
            if (user == null)
            {
                return null;
            }

            return user;
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            user.DateCreated = DateTime.UtcNow;
            db.Add(user);
            db.SaveChanges();
            return Ok();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = new User { Id = id };
            db.Users.Attach(user);
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
