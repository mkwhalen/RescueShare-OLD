using Microsoft.AspNetCore.Identity;
using RescueShare.Models.Entities;
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
        public string ShelterSenderId { get; set; }
        public string ShelterReceiverId { get; set; }
        public string FosterSenderId { get; set; }
        public string FosterReceiverId { get; set; }
        public string RescueSenderId { get; set; }
        public string RescueReceiverId { get; set; }
        public string UserId { get; set; }
        
        public virtual User User { get; set; }


    }
}
