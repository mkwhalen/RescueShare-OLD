using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class FosterDeniedDogTemperment
    {
        public string Id { get; set; }
        public string DogTempermentId { get; set; }
        public string FosterPreferencesId { get; set; }

        public virtual FosterPreferences DriverPreferences { get; set; }
        public virtual DogTemperment DogTemperment { get; set; }
    }
}
