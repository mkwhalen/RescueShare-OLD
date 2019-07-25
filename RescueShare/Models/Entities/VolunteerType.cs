using System.ComponentModel.DataAnnotations;

namespace RescueShare.Models.Entities
{
    public enum VolunteerType
    {
        [Display(Name = "Shelter Volunteer")]
        ShelterVolunteer,
        Driver, 
        Foster,
        [Display(Name = "Rescue Facilitator")]
        ResuceOrganization
    }
}
