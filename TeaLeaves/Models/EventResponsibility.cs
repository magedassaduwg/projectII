namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class representing the EventResponsibilities table
    /// </summary>
    public class EventResponsibility
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
    }
}
