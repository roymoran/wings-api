using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpPut]
        public void Put([FromBody]User user)
        {
            // Creating new user and updating permissable fields from paseed in user
            User userInternal = db.Users.Find(user.Id);

            userInternal.FirstName = user.FirstName;
            userInternal.LastName = user.LastName;
            userInternal.DOB = user.DOB;
            userInternal.AgeInterestedMax = user.AgeInterestedMax;
            userInternal.AgeInterestedMin = user.AgeInterestedMin;
            userInternal.Bio = user.Bio;
            userInternal.Gender = user.Gender;
            userInternal.GenderInterested = user.GenderInterested;
            userInternal.Job = user.Job;
            userInternal.School = user.School;
            userInternal.PhoneNumber = user.PhoneNumber;
            userInternal.City = user.City;
            userInternal.State = user.State;
            userInternal.Zip = user.Zip;
            userInternal.Latitude = user.Latitude;
            userInternal.Longitude = user.Longitude;
            userInternal.DateUpdated = DateTime.UtcNow;
            userInternal.Active = user.Active;
            
            db.Entry(userInternal).State = EntityState.Modified;

            db.SaveChanges();
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
