using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wings_api.Data;
using wings_api.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace wings_api.Controllers
{
    [Route("api/[controller]")]
    public class UserFriendsController : Controller
    {
        private readonly WingsContext db;

        public UserFriendsController(WingsContext context)
        {
            db = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<UserFriend> GetAllUserFriends()
        {
            UserFriend[] userFriends = new UserFriend[] {};
            return userFriends;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]UserFriend userFriend)
        {
            // if UserFriendID exists we immediately save to database 
            userFriend.DateCreated = DateTime.UtcNow;
            db.Add(userFriend);
            db.SaveChanges();
            return Ok();

            // otherwise we create a new user object and set active to false and save that UserFriendID
            // value that must be filled in for new non-existent user friend is phone number to validate that
            // that user friend joined on sign up
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
