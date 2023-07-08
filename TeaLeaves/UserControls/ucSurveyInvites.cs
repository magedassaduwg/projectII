using TeaLeaves.Controllers;

namespace TeaLeaves.UserControls
{
    /// <summary>
    /// The user control for viewing, and voting on, invited surveys
    /// </summary>
    public partial class ucSurveyInvites : UserControl
    {
        SurveyController surveyController = new SurveyController();

        public ucSurveyInvites()
        {
            InitializeComponent();
        }

        private void btnViewSurvey_Click(object sender, EventArgs e)
        {

        }
    }
}
