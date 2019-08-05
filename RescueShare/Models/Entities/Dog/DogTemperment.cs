using System.ComponentModel.DataAnnotations;

namespace RescueShare.Models.Entities
{
    public class DogTemperment
    {
        [Display(Name = "No Kids")]
        public bool NoKids { get; set; }
        [Display(Name = "No Dogs")]
        public bool NoDogs { get; set; }
        [Display(Name = "No Cats")]
        public bool NoCats { get; set; }
        [Display(Name = "Bite History")]
        public bool Biter { get; set; }
    }
}