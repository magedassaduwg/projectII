using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucEventPlanner : UserControl
    {
        public ucEventPlanner()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AddEventForm addEventForm = new AddEventForm())
                addEventForm.ShowDialog();
        }

        private void dataGridViewEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

