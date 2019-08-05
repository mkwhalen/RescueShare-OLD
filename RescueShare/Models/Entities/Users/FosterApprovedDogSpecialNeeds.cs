using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class FosterApprovedDogSpecialNeeds
    {
        public string Id { get; set; }
        public string SpecialNeedsId { get; set; }
        public string FosterPreferencesId { get; set; }

        public virtual FosterPreferences DriverPreferences { get; set; }
        public virtual DogSpecialNeeds DogSpecialNeeds { get; set; }
    }
}
