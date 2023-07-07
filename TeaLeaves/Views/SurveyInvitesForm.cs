using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for inviting contacts to take a survey
    /// </summary>
    public partial class SurveyInvitesForm : Form
    {
        ContactsController _contactsController;
        SurveyInviteController _surveyInviteController;
        List<User> _invitedUsers;
        List<User> _uninvitedUsers;
        Survey _survey;

        /// <summary>
        /// The constructor for the SurveyInvitesForm
        /// </summary>
        public SurveyInvitesForm(Survey survey)
        {
            InitializeComponent();
            _survey = survey;
            _contactsController = new ContactsController();
            _surveyInviteController = new SurveyInviteController();
            _invitedUsers = new List<User>();
            _uninvitedUsers = new List<User>();
            dgvInvitedContacts.AutoGenerateColumns = false;
            dgvUninvitedContacts.AutoGenerateColumns = false;           
        }

        private void GetUserSurveys()
        {
            try
            {
                _invitedUsers = _contactsController.GetUserContactsBySurvey(CurrentUserStore.User, _survey);

                dgvInvitedContacts.DataSource = _invitedUsers;

                _uninvitedUsers = _contactsController.GetUsersContactsNotInvitedBySurvey(CurrentUserStore.User, _survey);

                dgvUninvitedContacts.DataSource = _uninvitedUsers;

                if (dgvUninvitedContacts.Rows.Count > 0)
                {
                    dgvUninvitedContacts.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (dgvUninvitedContacts.Rows.Count > 0)
            {
                User selectedUser = (User)dgvUninvitedContacts.SelectedRows[0].DataBoundItem;
                SurveyInvite surveyInvite = new SurveyInvite();
                surveyInvite.InviterId = CurrentUserStore.User.UserId;
                surveyInvite.ReceiverId = selectedUser.UserId;
                surveyInvite.Answered = false;
                surveyInvite.SurveyId = _survey.Id;
                _surveyInviteController.AddSurveyInvite(surveyInvite);
                GetUserSurveys();
            }
        }
    }
}
