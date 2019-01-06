using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models.Entities
{
    public class Rescue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        public string Zip { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<RescueMember> Members { get; set; }
        public virtual ICollection<Dog> Dogs { get; set; }
    }
}
