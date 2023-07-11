using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.UserControls;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for voting on a given survey
    /// </summary>
    public partial class VoteSurveyForm : Form
    {
        private ucSurveyInvites _ucSurveyInvites;
        private SurveyOptionController _surveyOptionController;
        private SurveyVoteController _surveyVoteController;
        private Survey _survey;
        private bool _newSurveyVote;

        /// <summary>
        /// The constructor for the VoteSurveyForm
        /// </summary>
        /// <param name="survey"></param>
        public VoteSurveyForm(Survey survey, bool newSurveyVote, ucSurveyInvites ucSurveyInvites)
        {
            _newSurveyVote = newSurveyVote;
            _survey = survey;
            _surveyOptionController = new SurveyOptionController();
            _surveyVoteController = new SurveyVoteController();
            _ucSurveyInvites = ucSurveyInvites;
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
            if (!_newSurveyVote)
            {
                SurveyVote surveyVote = GetSurveyVote();
                lblSeletedVote.Text = "Selected Option: " + _surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId).Name;
            }          
        }

        private void VoteSurveyForm_Load(object sender, EventArgs e)
        {
            lblSurveyQuestion.Text = _survey.SurveyName;
        }

        private SurveyVote GetSurveyVote()
        {
            SurveyVote surveyVote = new SurveyVote();
            surveyVote.SurveyOptionId = Convert.ToInt32(cbSurveyOptions.SelectedValue.ToString());
            surveyVote.SurveyId = _survey.Id;
            surveyVote.UserId = CurrentUserStore.User.UserId;
            surveyVote.Id = _surveyVoteController.GetSurveyVoteBySurveyIdAndUserId(_survey.Id, CurrentUserStore.User.UserId).Id;
            return surveyVote;
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (_newSurveyVote)
            {
                SurveyVote surveyVote = GetSurveyVote();
                _surveyVoteController.SaveVote(surveyVote);
                lblSeletedVote.Text = "Selected Option: " + _surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId).Name;
                _newSurveyVote = false;
            }
            else
            {
                SurveyVote surveyVote = GetSurveyVote();
                List<SurveyOption> surveyOptions = new List<SurveyOption>();
                surveyOptions.Add(_surveyOptionController.GetSurveyOptionBySurveyOptionId(_surveyVoteController.GetSurveyVoteBySurveyIdAndUserId(_survey.Id, CurrentUserStore.User.UserId).SurveyOptionId));
                surveyOptions.Add(_surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId));
                surveyOptions[0].Votes--;
                surveyOptions[1].Votes++;
                _surveyVoteController.SaveVote(surveyVote, surveyOptions);
                lblSeletedVote.Text = "Selected Option: " + _surveyOptionController.GetSurveyOptionBySurveyOptionId(surveyVote.SurveyOptionId).Name;
            }
        }

        private void VoteSurveyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ucSurveyInvites.GetUserSurveys();
        }
    }
}
