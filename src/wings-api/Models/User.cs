﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string School { get; set; }
        public string Job { get; set; }
        public string Gender { get; set; } // male or female
        public string GenderInterested { get; set; } // male, female, or both
        public int AgeInterestedMin { get; set; }
        public int AgeInterestedMax { get; set; }
        public string Bio { get; set; }
        public bool Onboarded { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [JsonIgnore]
        public ICollection<UserFriend> UserFriends { get; set; }
        [JsonIgnore]
        public ICollection<UserPicture> UserPictures { get; set; }
        [JsonIgnore]
        public ICollection<UserBacklog> UserBacklogs { get; set; }
        [JsonIgnore]
        public ICollection<UserMatch> UserMatches { get; set; }
        [JsonIgnore]
        public ICollection<UserInterest> UserInterests { get; set; }

    }
}
