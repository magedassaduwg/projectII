using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucEventPlanner : UserControl
    {
        public ucEventPlanner()
        {
            InitializeComponent();
        }

        public User UserId { get; private set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm eventForm = new AddEventForm(UserId))
                eventForm.ShowDialog();
        }

        private void dataGridViewEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

