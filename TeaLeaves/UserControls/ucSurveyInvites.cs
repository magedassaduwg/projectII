using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    /// <summary>
    /// The user control for viewing, and voting on, invited surveys
    /// </summary>
    public partial class ucSurveyInvites : UserControl
    {
        SurveyController _surveyController;
        List<Survey> _surveys;
        List<Survey> _answeredSurveys;

        /// <summary>
        /// The constructor for the ucSurveyInvites
        /// </summary>
        public ucSurveyInvites()
        {
            _surveyController = new SurveyController();
            _surveys = new List<Survey>();
            _answeredSurveys = new List<Survey>();
            InitializeComponent();
            GetUserSurveys();
        }

        private void GetUserSurveys()
        {
            try
            {
                _surveys = _surveyController.GetSurveysReceivedByUserId(CurrentUserStore.User.UserId);

                dgvSurveyInvites.DataSource = _surveys;

                _answeredSurveys = _surveyController.GetAnsweredSurveysReceivedByUserId(CurrentUserStore.User.UserId);

                dgvAcceptedInvites.DataSource = _answeredSurveys;

                if (dgvSurveyInvites.Rows.Count > 0)
                {
                    dgvSurveyInvites.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnViewSurvey_Click(object sender, EventArgs e)
        {
            if (dgvSurveyInvites.SelectedRows.Count > 0)
            {
                Survey selectedSurvey = (Survey)dgvSurveyInvites.SelectedRows[0].DataBoundItem;
                using (VoteSurveyForm viewEventForm = new VoteSurveyForm(selectedSurvey))
                {
                    viewEventForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No event on your Invite!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
