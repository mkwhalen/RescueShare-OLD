using System.ComponentModel.DataAnnotations;

namespace RescueShare.Models.Entities
{
    public class DogAge
    {
        [Display(Name = "0 - 1 year")]
        public bool Puppy { get; set; }
        [Display(Name = "1 - 3 years")]
        public bool Young { get; set; }
        [Display(Name = "3 - 8 years")]
        public bool Adult { get; set; }
        [Display(Name = "8+ years")]
        public bool Senior { get; set; }
    }
}