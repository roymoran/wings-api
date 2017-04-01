using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class UserFriend
    {
        public int Id { get; set; }        
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public int? UserFriendID { get; set; }
        [ForeignKey("UserFriendID")]
        [InverseProperty("UserFriends")]
        public User Friend { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
