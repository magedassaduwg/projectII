namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class representing the Events table
    /// </summary>
    public class Event
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? StreetNumber { get; set; }
        public DateTime EventDateTime { get; set; }

      
    }
}
