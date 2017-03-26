using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class UserPicture
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Url { get; set; }
    }
}
