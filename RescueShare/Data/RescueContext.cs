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

        public DbSet<Space> Spaces { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogAge> DogAges { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }
        public DbSet<DogWeight> DogWeights { get; set; }
        public DbSet<DogSpecialNeeds> DogSpecialNeeds { get; set; }
        public DbSet<DogTemperment> DogTemperments { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<OpportunityType> OpportunityTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<DriverApprovedDogSpecialNeeds> DriverApprovedDogSpecialNeeds { get; set; }
        public DbSet<DriverDeniedDogAge> DriverDeniedDogAges { get; set; }
        public DbSet<DriverDeniedDogBreed> DriverDeniedDogBreeds { get; set; }
        public DbSet<DriverDeniedDogTemperment> DriverDeniedDogTemperments { get; set; }
        public DbSet<DriverDeniedDogWeight> DriverDeniedDogWeights { get; set; }
        public DbSet<FosterApprovedDogSpecialNeeds> FosterApprovedDogSpecialNeeds { get; set; }
        public DbSet<FosterDeniedDogAge> FosterDeniedDogAges { get; set; }
        public DbSet<FosterDeniedDogBreed> FosterDeniedDogBreeds { get; set; }
        public DbSet<FosterDeniedDogTemperment> FosterDeniedDogTemperments { get; set; }
        public DbSet<FosterDeniedDogWeight> FosterDeniedDogWeights { get; set; }
        public DbSet<DriverPreferences> DriverPreferences { get; set; }
        public DbSet<FosterPreferences> FosterPreferences { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationMember> OrganizationMembers { get; set; }


    }
}
