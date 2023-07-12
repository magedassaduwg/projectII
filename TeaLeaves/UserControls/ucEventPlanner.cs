using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    /// <summary>
    /// Represents a user control for event planning.
    /// </summary>
    public partial class ucEventPlanner : UserControl
    {
        private List<Event> _events;
        private EventController _eventController;
        /// <summary>
        /// Initializes a new instance of the ucEventPlanner.
        /// </summary>
        public ucEventPlanner()
        {
            InitializeComponent();
            _eventController = new EventController();
            dgEvents.AutoGenerateColumns = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Event newEvent = new Event();
            using (AddEventForm eventForm = new AddEventForm(newEvent))
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

        private bool ShouldDelete()
        {
            DialogResult decline = MessageBox.Show("Are you sure you want to delete this event?", "" +
                "", MessageBoxButtons.YesNo);
            return DialogResult.Yes == decline;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ShouldDelete())
            {
                return;
            }

            if (dgEvents.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgEvents.SelectedRows[0].DataBoundItem;
                DateTime eventDateTime = (DateTime)selectedEvent.EventDateTime;
                if (eventDateTime > DateTime.Now)
                {
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
                else
                {
                    MessageBox.Show("Selected event cannot be deleted because it has already passed.");
                    InitializeEvents();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgEvents.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgEvents.SelectedRows[0].DataBoundItem;

                using (AddEventForm eventForm = new AddEventForm(selectedEvent))
                {
                    eventForm.ShowDialog();
                }
                InitializeEvents();
            }

        }

        private void btnInvites_Click(object sender, EventArgs e)
        {
            if (dgEvents.SelectedRows.Count > 0)
            {
                Event selectedEvent = (Event)dgEvents.SelectedRows[0].DataBoundItem;

                using (EventInvitesForm eventForm = new EventInvitesForm(selectedEvent))
                {
                    eventForm.ShowDialog();
                }
                InitializeEvents();
            }
        }
    }
}

