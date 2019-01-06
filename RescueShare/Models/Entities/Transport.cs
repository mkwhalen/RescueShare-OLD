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
        public ReceiverType ReceiverType { get; set; }
        public SenderType SenderType { get; set; }

        public virtual List<TransportMember> Transporters { get; set; }
        public virtual Rescue OrganizingRescue { get; set; }
        public virtual Shelter ShelterSender { get; set; }
        public virtual Shelter ShelterReceiver { get; set; }
        public virtual Foster FosterSender { get; set; }
        public virtual Foster FosterReceiver { get; set; }
        public virtual Rescue RescueSender { get; set; }
        public virtual Rescue RescueReceiver { get; set; }
        public virtual User User { get; set; }


    }
}
