using System.ComponentModel.DataAnnotations;

namespace RescueShare.Models.Entities
{
    public class DogWeight
    {
        [Display(Name = "0 - 10 lbs")]
        public bool Mini { get; set; }
        [Display(Name = "10 - 25 lbs")]
        public bool Small { get; set; }
        [Display(Name = "25 - 40 lbs")]
        public bool Medium { get; set; }
        [Display(Name = "40 - 80 lbs")]
        public bool Large { get; set; }
        [Display(Name = "80+ lbs")]
        public bool ExtraLarge { get; set; }
    }
}