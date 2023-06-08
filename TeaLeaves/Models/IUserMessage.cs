namespace TeaLeaves.Models
{
    /// <summary>
    /// Interface represents a message being sent or received
    /// </summary>
    public interface IUserMessage
    {
        int MessageId { get; set; }
        int SenderId { get; set; }
        int ReceiverId { get; set; }
        string? Text { get; set; }
        int? MediaId { get; set; }
        DateTime TimeStamp { get; set; }
    }
}
