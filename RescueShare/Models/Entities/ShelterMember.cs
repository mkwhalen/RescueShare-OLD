namespace RescueShare.Models
{
    public class ShelterMember
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ShelterId { get; set; }

        public virtual User User { get; set; }
        public virtual Shelter Shelter { get; set; }
    }
}