using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wings_api.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace wings_api.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        User[] users = new User[]
        {
            new User { Id = 1, FirstName = "Roy", LastName = "Moran", School = "UIC", Job = "Consultant", Gender = "Male", GenderInterested = "Female", AgeInterestedMin = 18, AgeInterestedMax = 22, Bio = "Why, hello there.", Onboarded = false},
            new User { Id = 2, FirstName = "Aman", LastName = "Choudhury", School = "UIC", Job = "Finance", Gender = "Male", GenderInterested = "Female", AgeInterestedMin = 18, AgeInterestedMax = 30, Bio = "What is love, baby don't hurt me. Don't hurt me. No more.", Onboarded = false}
        };
        
        // GET: api/values
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = users.FirstOrDefault((p) => p.Id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

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
