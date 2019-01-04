using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RescueShare.Models;
using RescueShare.Models.Entities;

namespace RescueShare.Models
{
    public class RescueContext : IdentityDbContext<User>
    {
        public RescueContext()
        {
        }

        public RescueContext(DbContextOptions<RescueContext> options)
           : base(options)
        {
        }

        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Space> Spaces { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Trips> Trips { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<OpportunityType> OpportunityTypes { get; set; }
        public DbSet<ShelterMember> ShelterMembers { get; set; }
        public DbSet<Image> Images { get; set; }

        

    }
}
