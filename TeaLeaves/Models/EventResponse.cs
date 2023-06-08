namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class representing the EventResponses table
    /// </summary>
    public class EventResponse
    {
        public int Id { get; set; }
        public int InviterId { get; set; }
        public int ReceiverId { get; set; }
        public int EventId { get; set; }
    }
}
