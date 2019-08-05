using RescueShare.Models.Entities;
using System.Collections.Generic;

namespace RescueShare.Models
{
    public class DriverPreferences
    {
        public string Id { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public ICollection<DriverApprovedDogSpecialNeeds> ApprovedSpecialNeeds { get; set; }
        public ICollection<DriverDeniedDogAge> DeniedDogAge { get; set; }
        public ICollection<DriverDeniedDogBreed> DeniedDogBreed { get; set; }
        public ICollection<DriverDeniedDogTemperment> DeniedDogTemperment { get; set; }
        public ICollection<DriverDeniedDogWeight> DeniedDogWeight { get; set; }

    }
}