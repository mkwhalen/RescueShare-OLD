namespace RescueShare.Models
{
    public class Foster
    {
        public string Id { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}