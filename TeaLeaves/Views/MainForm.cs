namespace TeaLeaves.Views
{
    public partial class MainForm : Form
    {
        public MainForm(Models.User verifiedUser)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MessageForm chatForm = new MessageForm())
            {
                chatForm.ShowDialog();
            }
        }
    }
}
