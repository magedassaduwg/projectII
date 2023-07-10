using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for voting on a given survey
    /// </summary>
    public partial class VoteSurveyForm : Form
    {
        private SurveyOptionController _surveyOptionController;
        private SurveyVoteController _surveyVoteController;
        private Survey _survey;
        private bool _newSurveyVote;

        /// <summary>
        /// The constructor for the VoteSurveyForm
        /// </summary>
        /// <param name="survey"></param>
        public VoteSurveyForm(Survey survey, bool newSurveyVote)
        {
            _newSurveyVote = newSurveyVote;
            _survey = survey;
            _surveyOptionController = new SurveyOptionController();
            _surveyVoteController = new SurveyVoteController();
            InitializeComponent();
            LoadOptions();
        }

        private void LoadOptions()
        {
            List<SurveyOption> options = _surveyOptionController.GetSurveyOptionsBySurveyId(_survey.Id);
            List<string> optionsString = new List<string>();
            foreach (SurveyOption option in options)
            {
                optionsString.Add(option.Name);
            }
            cbSurveyOptions.Items.Clear();
            cbSurveyOptions.DataSource = options;
            cbSurveyOptions.DisplayMember = "Name";
            cbSurveyOptions.ValueMember = "SurveyOptionId";
        }

        private void VoteSurveyForm_Load(object sender, EventArgs e)
        {
            lblSurveyQuestion.Text = _survey.SurveyName;
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (_newSurveyVote)
            {
                SurveyVote surveyVote = new SurveyVote();
                surveyVote.SurveyOptionId = Convert.ToInt32(cbSurveyOptions.SelectedValue.ToString());
                surveyVote.SurveyId = _survey.Id;
                surveyVote.UserId = CurrentUserStore.User.UserId;
                _surveyVoteController.SaveVote(surveyVote);
                lblSeletedVote.Text = "Selected Option: " + _surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId).Name;
                _newSurveyVote = false;
            } else
            {
                SurveyVote surveyVote = new SurveyVote();
                surveyVote.SurveyOptionId = Convert.ToInt32(cbSurveyOptions.SelectedValue.ToString());
                surveyVote.SurveyId = _survey.Id;
                surveyVote.UserId = CurrentUserStore.User.UserId;
                List<SurveyOption> surveyOptions = new List<SurveyOption>();

                _surveyVoteController.SaveVote(surveyVote);
                lblSeletedVote.Text = "Selected Option: " + _surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId).Name;
            }
        }
    }
}
