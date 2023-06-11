using TeaLeaves.Controllers;
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
            dataGridViewEvent.AutoGenerateColumns = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm eventForm = new AddEventForm())
                if (eventForm.ShowDialog() == DialogResult.OK)
                {
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
                _events = _eventController.GetAllEvents(CurrentUserStore.User.UserId);

                dataGridViewEvent.DataSource = _events;

                if (dataGridViewEvent.Rows.Count > 0)
                {
                    dataGridViewEvent.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
