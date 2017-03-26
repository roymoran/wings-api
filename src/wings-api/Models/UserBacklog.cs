using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class UserBacklog
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int UserPotentialMatchID { get; set; }
        public int UserFriendID { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("UserBacklogs")]
        public User User { get; set; }

        [ForeignKey("UserFriendID")]
        [InverseProperty("UserBacklogs")]
        public User Friend { get; set; }

        [ForeignKey("UserPotentialMatchID")]
        [InverseProperty("UserBacklogs")]
        public User PotentialMatch { get; set; }
    }
}
