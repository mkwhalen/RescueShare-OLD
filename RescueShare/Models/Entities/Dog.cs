using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class Dog
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public string Breed { get; set; }
        public string CurrentMedications { get; set; }
        public string CurrentInjuries { get; set; }
        public string Food { get; set; }
        public string Notes { get; set; }
        public int Flag { get; set; }
        public bool IsSaved { get; set; }
        public string SpaceId { get; set; }
        public string ShelterId { get; set; }


        public virtual Space Space { get; set; }
        public virtual Shelter Shelter { get; set; }
    }
}
