namespace TeaLeaves.Models
{
    /// <summary>
    /// The model class for the SurveyVote object
    /// </summary>
    public class SurveyVote
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public int SurveyOptionId { get; set; }

    }
}
