using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for viewing and accepting EventResponsibilities
    /// </summary>
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
                _unacceptedEventResponsibilities = _eventResponsibilityController.GetUnassignedEventResponsibilitiesByEventId(_event.Id);

                dgvUnassignedResponsibilities.DataSource = _unacceptedEventResponsibilities;

                _myEventResponsibilities = _eventResponsibilityController.GetEventResponsibilitiesByUserIdAndEventId(CurrentUserStore.User.UserId, _event.Id);

                dgvMyResponsibilities.DataSource = _myEventResponsibilities;

                if (dgvUnassignedResponsibilities.Rows.Count > 0)
                {
                    dgvUnassignedResponsibilities.Rows[0].Selected = true;
                }

                if (dgvMyResponsibilities.Rows.Count > 0)
                {
                    dgvMyResponsibilities.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool ShouldAcceptResponsibility()
        {
            DialogResult decline = MessageBox.Show("Are you sure you want to accept this responsibility?", "" +
                "", MessageBoxButtons.YesNo);
            return DialogResult.Yes == decline;
        }

        private void btnAcceptResponsibility_Click(object sender, EventArgs e)
        {
            if (dgvUnassignedResponsibilities.Rows.Count > 0)
            {
                if (!ShouldAcceptResponsibility())
                {
                    return;
                }
                EventResponsibility selectedEventResponsibility = (EventResponsibility)dgvUnassignedResponsibilities.SelectedRows[0].DataBoundItem;
                _eventResponsibilityController.AssignEventResponsibility(CurrentUserStore.User, _event.Id, selectedEventResponsibility.Name);
            }
            GetEventResponsibilities();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMyResponsibilities.Rows.Count > 0)
            {
                EventResponsibility selectedEventResponsibility = (EventResponsibility)dgvMyResponsibilities.SelectedRows[0].DataBoundItem;
                _eventResponsibilityController.UnassignEventResponsibility(_event.Id, selectedEventResponsibility.Name);
            }
            GetEventResponsibilities();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewEventResponsibilitiesForm_Load(object sender, EventArgs e)
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
    }
}
