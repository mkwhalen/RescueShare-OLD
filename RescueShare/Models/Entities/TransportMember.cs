namespace RescueShare.Models
{
    public class TransportMember
    {
        public string Id { get; set; }
        public string UserId { get; set; }
     
        public virtual User User { get; set; }
        
    }
}