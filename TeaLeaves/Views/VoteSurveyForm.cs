using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for voting on a given survey
    /// </summary>
    public partial class VoteSurveyForm : Form
    {
        private SurveyOptionController _surveyOptionController;
        private Survey _survey;

        /// <summary>
        /// The constructor for the VoteSurveyForm
        /// </summary>
        /// <param name="survey"></param>
        public VoteSurveyForm(Survey survey)
        {
            _survey = survey;
            _surveyOptionController = new SurveyOptionController();
            InitializeComponent();
            LoadOptions();
        }

        private void LoadOptions()
        {
            List<SurveyOption> options = _surveyOptionController.GetSurveyOptionBySurveyId(_survey.Id);
            cbSurveyOptions.Items.Clear();
            cbSurveyOptions.DataSource = options;
        }
    }
}
