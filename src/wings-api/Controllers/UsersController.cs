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
        User[] users = new User[]
        {
            new User { Id = 1, FirstName = "Roy", LastName = "Moran", School = "UIC", Job = "Consultant", Gender = "Male", GenderInterested = "Female", AgeInterestedMin = 18, AgeInterestedMax = 22, Bio = "Why, hello there.", Onboarded = false},
            new User { Id = 2, FirstName = "Aman", LastName = "Choudhury", School = "UIC", Job = "Finance", Gender = "Male", GenderInterested = "Female", AgeInterestedMin = 18, AgeInterestedMax = 30, Bio = "What is love, baby don't hurt me. Don't hurt me. No more.", Onboarded = false}
        };

        /// <summary>
        /// Retrieve all users
        /// </summary>
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            var user = new User();
            
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
        }
    }
}
