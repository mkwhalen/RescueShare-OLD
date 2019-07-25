using RescueShare.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RescueShare.Models
{
    public class Dog
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
        [Required, DisplayName("Date In")]
        public DateTime InDate { get; set; }
        [DisplayName("Date Out")]
        public DateTime OutDate { get; set; }
        public string BreedId { get; set; }
        [DisplayName("Current Medications")]
        public string CurrentMedications { get; set; }
        [DisplayName("Current Injuries")]
        public string CurrentInjuries { get; set; }
        public string Food { get; set; }
        public string Notes { get; set; }
        public int Flag { get; set; }
        [DisplayName("Tagged for Rescue")]
        public bool IsSaved { get; set; }
        public string SpaceId { get; set; }
        public string ShelterId { get; set; }
        public string ImageId { get; set; }

        public virtual Image Image { get; set; }
        public virtual Space Space { get; set; }
        public virtual Shelter Shelter { get; set; }
        public virtual DogBreed Breed { get; set; }
    }
}
