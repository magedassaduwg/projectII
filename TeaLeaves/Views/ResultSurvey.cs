
using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// View Survey result in this form
    /// </summary>
    public partial class ResultSurvey : Form
    {
        private List<SurveyOption> _surveyOption;
        private SurveyOptionController _surveyOptionController;
        private Survey _survey;
        /// <summary>
        /// The constructor for the ResultSurvey class
        /// </summary>
        /// <param name="selectedSurvey"></param>
        public ResultSurvey(Models.Survey selectedSurvey)
        {

            InitializeComponent();
            _surveyOptionController = new SurveyOptionController();
            _surveyOption = new List<SurveyOption>();
            _survey = selectedSurvey ?? new Survey(); 
            BindSurveyValue();
            dataGridViewSurvey.AutoGenerateColumns = false;
        }
        private void BindSurveyValue()
        {
            richTextBoxDescription.Text = _survey.SurveyName;
        }


        private void LoadSurveyOptions()
        {
            try
            {
                _surveyOption = _surveyOptionController.GetSurveyOptionsBySurveyId(_survey.Id);

                dataGridViewSurvey.DataSource = _surveyOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ResultSurvey_Load(object sender, EventArgs e)
        {
            LoadSurveyOptions();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
