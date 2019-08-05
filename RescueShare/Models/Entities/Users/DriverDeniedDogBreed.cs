using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class DriverDeniedDogBreed
    {
        public string Id { get; set; }
        public string DogBreedId { get; set; }
        public string DriverPreferencesId { get; set; }

        public virtual DriverPreferences DriverPreferences { get; set; }
        public virtual DogBreed DogBreed { get; set; }
    }
}
