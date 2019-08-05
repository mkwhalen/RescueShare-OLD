using RescueShare.Models.Entities;
using System.Collections.Generic;

namespace RescueShare.Models
{
    public class FosterPreferences
    {
        public string Id { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public ICollection<FosterApprovedDogSpecialNeeds> ApprovedSpecialNeeds { get; set; }
        public ICollection<FosterDeniedDogAge> DeniedDogAge { get; set; }
        public ICollection<FosterDeniedDogBreed> DeniedDogBreed { get; set; }
        public ICollection<FosterDeniedDogTemperment> DeniedDogTemperment { get; set; }
        public ICollection<FosterDeniedDogWeight> DeniedDogWeight { get; set; }
    }
}