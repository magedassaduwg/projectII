﻿using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucEventPlanner : UserControl
    {
        private List<Event> _events;
        private EventController _eventController;

        public ucEventPlanner()
        {
            InitializeComponent();
            _eventController = new EventController();
            dgEvents.AutoGenerateColumns = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm eventForm = new AddEventForm())
            {
                eventForm.ShowDialog();

                InitializeEvents();

            }
        }

        private void ucEventPlanner_Load(object sender, EventArgs e)
        {
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            try
            {
                _events = _eventController.GetEventsByUserId(CurrentUserStore.User.UserId);

                dgEvents.DataSource = _events;

                if (dgEvents.Rows.Count > 0)
                {
                    dgEvents.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEvents.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgEvents.SelectedRows[0].DataBoundItem;
                bool deleted = _eventController.DeleteEvent(selectedEvent.Id);
                if (deleted)
                {
                    MessageBox.Show("Event deleted successfully.");
                    InitializeEvents();
                }
                else
                {
                    MessageBox.Show("Failed to delete the event.");
                }
            }
        }
    }
}
