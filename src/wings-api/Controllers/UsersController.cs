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
            new User { Id = 1, First_Name = "Roy", Last_Name = "Moran", Age = 23, School = "UIC", Job = "Consultant", Gender = "Male", Gender_Interested = "Female", Age_Interested_Min = 18, Age_Interested_Max = 22, Bio = "Why, hello there.", Loves_One = "Mother nature", Loves_Two = "One Direction", Loves_Three = "Nancy Pelosi", Onboarded = false},
            new User { Id = 2, First_Name = "Aman", Last_Name = "Choudhury", Age = 24, School = "UIC", Job = "Finance", Gender = "Male", Gender_Interested = "Female", Age_Interested_Min = 18, Age_Interested_Max = 30, Bio = "What is love, baby don't hurt me. Don't hurt me. No more.", Loves_One = "World Travel", Loves_Two = "Lifting Heavy", Loves_Three = "Kanye West aka Yeezus", Onboarded = false}
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
