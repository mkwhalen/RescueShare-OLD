using Microsoft.AspNetCore.Identity;
using RescueShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class User : IdentityUser
    {
        public bool IsShelterWorker { get; set; }
        public bool IsRescueWorker { get; set; }
        public bool IsVolunteer { get; set; }
        public bool IsDriver { get; set; }
        public string TransportDayAvailability { get; set; }
        public string TransportTimeAvailability { get; set; }
        public int TransportSpace { get; set; }
        public string TransportTemperment { get; set; }
        public string TransportWeights { get; set; }
        public bool IsFoster { get; set; }
        public string FosterAvailability { get; set; }
        public int FosterSpace { get; set; }
        public string FosterBreeds { get; set; }
        public string FosterAges { get; set; }
        public string FosterWeights { get; set; }
        public string FosterTemperment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserDeniedTemperment> UserDeniedTemperments { get; set; }
        public virtual ICollection<UserDeniedDogWeight> UserDeniedDogWeights { get; set; }
        public virtual ICollection<UserDeniedDogAge> UserDeniedDogAges { get; set; }
        public virtual ICollection<UserDeniedDogBreed> UserDeniedDogBreeds { get; set; }
        public virtual ICollection<ShelterMember> Members { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
