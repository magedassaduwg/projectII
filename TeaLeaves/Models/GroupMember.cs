namespace TeaLeaves.Models
{
    /// <summary>
    /// Model represents a group message
    /// </summary>
    public class GroupMember
    {
        public int GroupMemberId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int[] UserIds { get; set; }
        public DateTime? TimeStamp { get; set; }
        public bool IsContainUnread { get; set; }
    }
}