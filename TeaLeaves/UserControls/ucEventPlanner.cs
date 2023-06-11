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
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucEventPlanner : UserControl
    {
        private List<Event> _events;
        private EventController _eventController;
        private User _user;
        public ucEventPlanner(User user)
        {
            InitializeComponent();
            _eventController = new EventController();
            dataGridViewEvent.AutoGenerateColumns = false;
            _user = user;
        }

        public User UserId { get; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm eventForm = new AddEventForm(UserId))
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
                _events = _eventController.GetAllEvents(_user.UserId);

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
