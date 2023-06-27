﻿using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class ViewEventResponsibilitiesForm : Form
    {
        Event _event;
        EventResponsibilityController _eventResponsibilityController;
        List<EventResponsibility> _myEventResponsibilities;
        List<EventResponsibility> _unacceptedEventResponsibilities;

        /// <summary>
        /// The constructor for the ViewEventResponsibilitiesForm class
        /// </summary>
        /// <param name="event"></param>
        public ViewEventResponsibilitiesForm(Event @event)
        {
            InitializeComponent();
            _event = @event;
            _eventResponsibilityController = new EventResponsibilityController();
            _myEventResponsibilities = new List<EventResponsibility>();
            _unacceptedEventResponsibilities = new List<EventResponsibility>();
            dgvMyResponsibilities.AutoGenerateColumns = false;
            dgvUnassignedResponsibilities.AutoGenerateColumns = false;
        }

        private void GetEventResponsibilities()
        {
            try
            {
                _unacceptedEventResponsibilities = _eventResponsibilityController.GetEventResponsibilitiesByEventId(_event.Id);

                dgvUnassignedResponsibilities.DataSource = _unacceptedEventResponsibilities;

                _myEventResponsibilities = _eventResponsibilityController.GetEventResponsibilitiesByUserIdAndEventId(CurrentUserStore.User.UserId, _event.Id);

                dgvMyResponsibilities.DataSource = _myEventResponsibilities;

                if (dgvUnassignedResponsibilities.Rows.Count > 0)
                {
                    dgvUnassignedResponsibilities.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ViewEventForm_Load(object sender, EventArgs e)
        {
            tbName.Text = _event.EventName;
            if (_event.City != "" && _event.StreetNumber != "")
            {
                tbAddress.Text = _event.StreetNumber + ", " + _event.City + ", " + _event.State + " " + _event.Zipcode;
            }
            string[] dateAndTimeStrings = _event.EventDateTime.ToString().Split(" ");
            tbDate.Text = dateAndTimeStrings[0];
            tbTime.Text = dateAndTimeStrings[1];
            tbDescription.Text = _event.Description;

            GetEventResponsibilities();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcceptResponsibility_Click(object sender, EventArgs e)
        {

        }
    }
}
