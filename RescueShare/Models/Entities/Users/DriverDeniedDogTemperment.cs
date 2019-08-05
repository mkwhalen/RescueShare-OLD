using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class DriverDeniedDogTemperment
    {
        public string Id { get; set; }
        public string DogTempermentId { get; set; }
        public string DriverPreferencesId { get; set; }

        public virtual DriverPreferences DriverPreferences { get; set; }
        public virtual DogTemperment DogTemperment { get; set; }
    }
}
