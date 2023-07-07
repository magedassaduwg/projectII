namespace TeaLeaves.Models
{
    /// <summary>
    /// The model object for the Survey table
    /// </summary>
    public class Survey
    {
        public string? SurveyName { get; set; }
        public DateTime SurveyDateTime { get; set; }
        public int CreatorId { get; set; }
        public string? CreatorName { get; set; }
        public int Id { get; set; }
    }
}
