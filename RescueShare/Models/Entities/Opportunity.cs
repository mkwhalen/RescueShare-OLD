using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class Opportunity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }
        public string LocationId { get; set; }

        public virtual OpportunityType Type { get; set; }
        public virtual Shelter Location { get; set; }
    }
}
