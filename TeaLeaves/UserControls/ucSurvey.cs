using MassTransit;
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
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucSurvey : UserControl
    {
        private List<Survey> _survey;
        private SurveyController _surveyController;
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
            using (AddSurveyForm surveyForm = new AddSurveyForm(newSurvey))
            {
                surveyForm.ShowDialog();

                InitializeSurvey();

            }
        }
    }
}
