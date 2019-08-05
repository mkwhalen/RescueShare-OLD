using System.Collections.Generic;

namespace RescueShare.Models.Entities
{
    public class Organization
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public bool IsShelter { get; set; }
        public bool IsFosterOrg { get; set; }
        public bool IsTransportOrg { get; set; }

        public virtual ICollection<OrganizationMember> OrganizationMembers { get; set; }
    }
}