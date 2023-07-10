
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for adding a new survey
    /// </summary>
    public partial class addSurveyForm : Form
    {
        private SurveyController _surveyController;
        private List<SurveyOption> _surveyOption;
        private List<SurveyOption> _newSurveyOption;
        private SurveyOptionController _surveyOptionController;
        private Survey _survey;

        /// <summary>
        /// The constructor for the addSurveyForm class
        /// </summary>
        /// <param name="selectedSurvey"></param>
        public addSurveyForm(Survey selectedSurvey)
        {
            InitializeComponent();
            _surveyController = new SurveyController();
            _surveyOptionController = new SurveyOptionController();
            _surveyOption = new List<SurveyOption>();
            _newSurveyOption = new List<SurveyOption>();
            _survey = selectedSurvey ?? new Survey(); ;
            BindSurveyValue();
            dataGridViewSurvey.AutoGenerateColumns = false;
            
        }

        private void BindSurveyValue()
        {
            richTextBoxDescription.Text = _survey.SurveyName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (surveyOption.Text != "" && CheckSurveyName(surveyOption.Text))
            {
                SurveyOption addedSurvey = new SurveyOption
                {
                    Name = surveyOption.Text,
                };
                _newSurveyOption.Add(addedSurvey);

                List<SurveyOption> allOption = new List<SurveyOption>();
                allOption.AddRange(_surveyOption);
                allOption.AddRange(_newSurveyOption);
                try
                {
                    dataGridViewSurvey.DataSource = allOption;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                surveyOption.Text = "";
            }
            else if (!CheckSurveyName(surveyOption.Text))
            {
                labelError.Text = "A Survey with that name already exists";
            }
            else
            {
                labelError.Text = "Survey name cannot be blank";
            }
        }

        private bool CheckSurveyName(string name)
        {
            foreach (SurveyOption option in _surveyOption)
            {
                if (option.Name == name) { return false; }
            }

            foreach (SurveyOption option in _newSurveyOption)
            {
                if (option.Name == name) { return false; }
            }

            return true;
        }

        private void addSurveyForm_Load(object sender, EventArgs e)
        {
            LoadSurveyOptions();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
            if (IsFormValid())
            {
                _survey.CreatorId = CurrentUserStore.User.UserId;
                _survey.SurveyDateTime = DateTime.Now;
                _survey.SurveyName = richTextBoxDescription.Text;
                try
                {
                    _surveyController.SaveSurvey(_survey, _newSurveyOption);
                    MessageBox.Show("Survey has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool IsFormValid()
        {
            if (richTextBoxDescription.Text.Trim().Length == 0)
            {
                labelError.Text = "Please enter the survey description/question";
                return false;
            }
            if (dataGridViewSurvey.Rows.Count < 2)
            {
                labelError.Text = "Please add at least two survey options";
                return false;
            }
            return true;
        }

        private void surveyOption_TextChanged(object sender, EventArgs e)
        {
            labelError.Text="";
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelError.Text="";
        }
    }
}
