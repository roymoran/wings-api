using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class UserInterest
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Interest { get; set; }
    }
}
