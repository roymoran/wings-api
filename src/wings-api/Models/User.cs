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
        public string LovesOne { get; set; }
        public string LovesTwo { get; set; }
        public string LovesThree { get; set; }
        public bool Onboarded { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
