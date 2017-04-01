using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wings_api.Models;

namespace wings_api.Data
{
    public class WingsContext : DbContext
    {
        public WingsContext(DbContextOptions<WingsContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<UserFriend> UserFriends { get; set; }
        public DbSet<UserBacklog> UserBacklogs { get; set; }
        public DbSet<UserMatch> UserMatches { get; set; }
        public DbSet<UserChatlog> UserChatlogs { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }
        public DbSet<UserPicture> UserPictures { get; set; }
    }
}
