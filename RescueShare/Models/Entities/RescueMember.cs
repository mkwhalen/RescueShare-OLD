namespace RescueShare.Models.Entities
{
    public class RescueMember
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string RescueId { get; set; }

        public virtual User User { get; set; }
        public virtual Rescue Rescue { get; set; }
    }
}