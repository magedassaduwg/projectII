﻿using TeaLeaves.Controllers;
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
            _surveyOption = new List<SurveyOption>();
            _newSurveyOption = new List<SurveyOption>();
            _survey = selectedSurvey ?? new Survey();
            _surveyController = new SurveyController();
            _surveyOptionController = new SurveyOptionController();
            dataGridViewSurvey.AutoGenerateColumns = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SurveyOption addedOption = new SurveyOption
            {
                Name = surveyOption.Text,
            };
            _newSurveyOption.Add(addedOption);

            List<SurveyOption> allSurveyOption = new List<SurveyOption>();
            allSurveyOption.AddRange(_surveyOption);
            allSurveyOption.AddRange(_newSurveyOption);
            try
            {
                dataGridViewSurvey.DataSource = allSurveyOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            surveyOption.Text = "";
        }

        private void addSurveyForm_Load(object sender, EventArgs e)
        {
            LoadSurveyOptions();
        }

        private void LoadSurveyOptions()
        {
            try
            {
                _surveyOption = _surveyOptionController.GetSurveyOptionByEventId(_survey.Id);

                dataGridViewSurvey.DataSource = _surveyOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}