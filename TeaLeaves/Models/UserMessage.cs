namespace TeaLeaves.Models
{
    /// <summary>
    /// Message class implementing IMessage
    /// </summary>
    public class UserMessage : IUserMessage
    {
        public int MessageId {get; set; }
        public int SenderId {get; set; }
        public int ReceiverId {get; set; }
        public string? Text {get; set; }
        public int? MediaId {get; set; }
        public DateTime TimeStamp {get; set; }
    }
}
