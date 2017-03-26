using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class UserMatch
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int UserMatchID { get; set; }
        public int UserFriendID { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("UserMatches")]
        public User User { get; set; }

        [ForeignKey("UserFriendID")]
        [InverseProperty("UserMatches")]
        public User Friend { get; set; }

        [ForeignKey("UserMatchID")]
        [InverseProperty("UserMatches")]
        public User Match { get; set; }
    }
}
