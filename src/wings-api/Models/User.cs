using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wings_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Job { get; set; }
        public string Gender { get; set; } // male or female
        public string Gender_Interested { get; set; } // male, female, or both
        public int Age_Interested_Min { get; set; }
        public int Age_Interested_Max { get; set; }
        public string Bio { get; set; }
        public string Loves_One { get; set; }
        public string Loves_Two { get; set; }
        public string Loves_Three { get; set; }
        public bool Onboarded { get; set; }
    }
}
