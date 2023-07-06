namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class for the SurveyInvites table
    /// </summary>
    public class SurveyInvite
    {
        public int Id { get; set; }
        public int InviterId { get; set; }
        public int ReceiverId { get; set; }
        public int SurveyId { get; set; }
        public bool Answered { get; set; }
    }
}
