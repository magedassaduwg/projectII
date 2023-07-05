namespace TeaLeaves.Models
{
    /// <summary>
    /// The model object for the SurveyOption table
    /// </summary>
    public class SurveyOption
    {
        public string? Name { get; set; }
        public int Votes { get; set; }
        public int Id { get; set; }
        public int SurveyId { get; set; }
    }
}
