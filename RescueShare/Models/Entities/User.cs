using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class User : IdentityUser
    {
        public int Spaces { get; set; }

        public virtual ICollection<ShelterMember> Members { get; set; }
    }
}
