using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    /// <summary>
    ///  Represents a user control for survey.
    /// </summary>
    public partial class ucSurvey : UserControl
    {
        private List<Survey> _survey;
        private SurveyController _surveyController;
        /// <summary>
        /// Initializes a new instance of the ucSurvey.
        /// </summary>
        public ucSurvey()
        {
            InitializeComponent();
            _surveyController = new SurveyController();
            dataGridViewSurvey.AutoGenerateColumns = false;
        }
        private void InitializeSurvey()
        {
            try
            {
                _survey = _surveyController.GetSurveyByUserId(CurrentUserStore.User.UserId);

                dataGridViewSurvey.DataSource = _survey;

                if (dataGridViewSurvey.Rows.Count > 0)
                {
                    dataGridViewSurvey.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ucSurvey_Load(object sender, EventArgs e)
        {
            InitializeSurvey();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Survey newSurvey = new Survey();
            using (addSurveyForm surveyForm = new addSurveyForm(newSurvey))
            {
                surveyForm.ShowDialog();

                InitializeSurvey();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSurvey.SelectedRows.Count > 0)
            {
                Survey selectedSurvey = (Survey)dataGridViewSurvey.SelectedRows[0].DataBoundItem;

                using (addSurveyForm surveyForm = new addSurveyForm(selectedSurvey))
                {
                    surveyForm.ShowDialog();
                }
                InitializeSurvey();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSurvey.SelectedRows.Count > 0)
            {
                Survey selectedSurvey = (Survey)dataGridViewSurvey.SelectedRows[0].DataBoundItem;


                bool deleted = _surveyController.DeleteSurvey(selectedSurvey.Id);
                if (deleted)
                {
                    MessageBox.Show("Survey deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InitializeSurvey();
                }
                else
                {
                    MessageBox.Show("Failed to Survey the event.");
                }


            }
        }

        private void btnInvites_Click(object sender, EventArgs e)
        {
            if (dataGridViewSurvey.SelectedRows.Count > 0)
            {
                Survey selectedSurvey = (Survey)dataGridViewSurvey.SelectedRows[0].DataBoundItem;

                using (SurveyInvitesForm eventForm = new SurveyInvitesForm(selectedSurvey))
                {
                    eventForm.ShowDialog();
                }
                InitializeSurvey();
            }
        }


    }
}
