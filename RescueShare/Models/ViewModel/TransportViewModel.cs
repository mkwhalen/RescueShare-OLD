using RescueShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class TransportViewModel
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

        

        public TransportViewModel(Transport entity)
        {
            this.Id = entity.Id;
        }



        public string SenderName
        {
            get
            {
                switch (SenderType)
                {
                    case SenderType.Rescue:
                        return RescueSender.Name;
                    case SenderType.Shelter:
                        return ShelterSender.Name;
                    case SenderType.Foster:
                        return FosterSender.User.FullName;
                    default:
                        return null;
                }
            }
        }
        public string ReceiverName
        {
            get
            {
                switch (ReceiverType)
                {
                    case ReceiverType.Rescue:
                        return RescueReceiver.Name;
                    case ReceiverType.Shelter:
                        return ShelterReceiver.Name;
                    case ReceiverType.Foster:
                        return FosterReceiver.User.FullName;
                    default:
                        return null;
                }
            }
        }
        public string SenderId
        {
            get
            {
                switch (SenderType)
                {
                    case SenderType.Rescue:
                        return RescueSender.Id;
                    case SenderType.Shelter:
                        return ShelterSender.Id;
                    case SenderType.Foster:
                        return FosterSender.User.Id;
                    default:
                        return null;
                }
            }
        }
        public string ReceiverId
        {
            get
            {
                switch (ReceiverType)
                {
                    case ReceiverType.Rescue:
                        return RescueReceiver.Id;
                    case ReceiverType.Shelter:
                        return ShelterReceiver.Id;
                    case ReceiverType.Foster:
                        return FosterReceiver.User.Id;
                    default:
                        return null;
                }
            }
        }
    }
}

