using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class OrganizationMember
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDriver { get; set; }
        public bool IsFoster { get; set; }

        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
