
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    /// <summary>
    ///  Represents a user control for event invites.
    /// </summary>
    public partial class ucEventInvites : UserControl
    {
        EventController _eventController;
        EventResponseController _eventResponseController;
        List<Event> _events;
        List<Event> _eventsAccepted;
        List<Event> _eventsDeclined;

        /// <summary>
        /// Initializes a new instance of the ucEventInvities
        /// </summary>
        public ucEventInvites()
        {
            InitializeComponent();
            _eventController = new EventController();
            _eventResponseController = new EventResponseController();
            _events = new List<Event>();
            _eventsAccepted = new List<Event>();
            _eventsDeclined = new List<Event>();
            dgvEventInvites.AutoGenerateColumns = false;
            dgvAcceptedInvites.AutoGenerateColumns = false;
            dgvDeclinedInvites.AutoGenerateColumns = false;
        }

        private void GetUserEvents()
        {
            try
            {
                _events = _eventController.GetEventsReceivedByUserId(CurrentUserStore.User.UserId);

                dgvEventInvites.DataSource = _events;

                _eventsAccepted = _eventController.GetAcceptedEventsReceivedByUserId(CurrentUserStore.User.UserId);

                dgvAcceptedInvites.DataSource = _eventsAccepted;

                _eventsDeclined = _eventController.GetDeclinedEventsReceivedByUserId(CurrentUserStore.User.UserId);

                dgvDeclinedInvites.DataSource = _eventsDeclined;

                if (dgvEventInvites.Rows.Count > 0)
                {
                    dgvEventInvites.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetUserEvents();
        }

        private void ucEventInvites_Load(object sender, EventArgs e)
        {
            GetUserEvents();
            BindCategory();
        }
        private void BindCategory()
        {
            string[] category = {
                "Personal", "Friends", "Family", "Office", "Business", "Others"
            };
            tbCategory.Items.Clear();
            tbCategory.Items.AddRange(category);
            tbCategory.SelectedIndex = 0;

        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvEventInvites.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgvEventInvites.SelectedRows[0].DataBoundItem;
                _eventResponseController.AcceptEventResponse(CurrentUserStore.User.UserId, selectedEvent.Id);
                GetUserEvents();
            }
            else
            {
                MessageBox.Show("No event on your Invite!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dgvEventInvites.SelectedRows.Count > 0)
            {
                dgvEventInvites.Rows[0].Selected = true;
            }
        }

        private bool ShouldDecline()
        {
            DialogResult decline = MessageBox.Show("Are you sure you want to decline this event?", "" +
                "", MessageBoxButtons.YesNo);
            return DialogResult.Yes == decline;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {

            if (dgvEventInvites.SelectedRows.Count > 0)
            {
                if (ShouldDecline())
                {
                    Event selectedEvent = (Event)dgvEventInvites.SelectedRows[0].DataBoundItem;
                    _eventResponseController.DeclineEventResponse(CurrentUserStore.User.UserId, selectedEvent.Id);
                    GetUserEvents();
                }
                if (dgvEventInvites.SelectedRows.Count > 0)
                {
                    dgvEventInvites.Rows[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("No event on your Invite!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvEventInvites.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgvEventInvites.SelectedRows[0].DataBoundItem;
                using (ViewEventForm viewEventForm = new ViewEventForm(selectedEvent))
                {
                    viewEventForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No event on your Invite!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButtonFilterByCategory_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFilter.Enabled = false;
            tbCategory.Enabled = true;
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            tbCategory.Enabled = false;
            dateTimePickerFilter.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string category = tbCategory.Text;


            try
            {
                if (radioButtonFilterByCategory.Checked)
                {
                    dgvEventInvites.DataSource = _events.Where(ev => ev.Category == category).ToList();
                    dgvAcceptedInvites.DataSource = _eventsAccepted.Where(ev => ev.Category == category).ToList();
                    dgvDeclinedInvites.DataSource = _eventsDeclined.Where(ev => ev.Category == category).ToList();
                }

                else if (radioButtonDate.Checked)
                {
                    DateTime selectedDate = dateTimePickerFilter.Value.Date;

                    dgvEventInvites.DataSource = _events.Where(ev => ev.EventDateTime.Date == selectedDate).ToList();
                    dgvAcceptedInvites.DataSource = _eventsAccepted.Where(ev => ev.EventDateTime.Date == selectedDate).ToList();
                    dgvDeclinedInvites.DataSource = _eventsDeclined.Where(ev => ev.EventDateTime.Date == selectedDate).ToList();
                }

                //eventName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnResponsibilities_Click(object sender, EventArgs e)
        {
            if (dgvAcceptedInvites.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgvAcceptedInvites.SelectedRows[0].DataBoundItem;
                using (ViewEventResponsibilitiesForm viewEventForm = new ViewEventResponsibilitiesForm(selectedEvent))
                {
                    viewEventForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No event on your Invite!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPassedEvents_Click(object sender, EventArgs e)
        {
            using (ViewPassedEventsForm viewEventForm = new ViewPassedEventsForm())
            {
                viewEventForm.ShowDialog();
            }
        }
    }
}
