using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class ResultSurvey : Form
    {
        private SurveyController _surveyController;
        private List<SurveyOption> _surveyOption;
        private List<SurveyOption> _newSurveyOption;
        private SurveyOptionController _surveyOptionController;
        private Survey _survey;
        public ResultSurvey(Models.Survey selectedSurvey)
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
