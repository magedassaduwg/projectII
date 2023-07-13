namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class representing the Events table
    /// </summary>
    public class Event 
    {
        public string? EventName { get; set; }
        public string? Category { get; set; }
        public DateTime EventDateTime { get; set; }
        public string? Description { get; set; }
        public int CreatorId { get; set; }
        public string? CreatorName { get; set; }
        public int Id { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public int Zipcode { get; set; }
        public string? StreetNumber { get; set; }
        public bool Accepted { get; set; }
        public bool Declined { get; set; }
    }
}
