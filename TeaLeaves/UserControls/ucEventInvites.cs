using System.Windows.Forms;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucEventInvites : UserControl
    {
        EventController _eventController;
        EventResponseController _eventResponseController;
        List<Event> _events;
        List<Event> _eventsAccepted;
        List<Event> _eventsDeclined;


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
            if (ShouldDecline())
            {
                if (dgvEventInvites.SelectedRows.Count > 0)
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
                return;
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
                    if (string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("Please enter category name", "Category name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _events = _eventController.GetEventsReceivedByUserIdWithCategory(CurrentUserStore.User.UserId, category);

                    if (_events.Count == 0)
                    {
                        MessageBox.Show("No event found with that category");
                    }
                    dgvEventInvites.DataSource = _events;
                }

                else if (radioButtonDate.Checked)
                {
                    DateTime eventDate = Convert.ToDateTime(dateTimePickerFilter.Value).Date;
                    _events = _eventController.GetEventsReceivedByUserIdWithDate(CurrentUserStore.User.UserId, eventDate);

                    if (_events.Count == 0)
                    {
                        MessageBox.Show("No event found with that date");
                    }
                    dgvEventInvites.DataSource = _events;
                }

                eventName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void eventName()
        {
            dgvEventInvites.DataSource = _events;

            if (dgvEventInvites.Rows.Count > 0)
            {
                dgvEventInvites.Rows[0].Selected = true;
            }
        }
    }
}
