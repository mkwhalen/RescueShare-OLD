using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class Transport
    {

        public string Id { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime DropoffTime { get; set; }
        public DateTime TransportTime { get; set; }
        public string SendingShelterId { get; set; }
        public string ReceivingShelterId { get; set; }
        public string UserId { get; set; }
        
        public virtual Shelter SendingShelter { get; set; }
        public virtual Shelter ReceivingShelter { get; set; }
        public virtual User User { get; set; }

    }
}
