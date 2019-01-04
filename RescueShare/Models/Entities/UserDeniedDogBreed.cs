using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class UserDeniedDogBreed
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string DogBreedId { get; set; }

        public virtual User User { get; set; }
        public virtual DogBreed DogBreed { get; set; }
    }
}
