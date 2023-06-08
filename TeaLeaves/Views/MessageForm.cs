using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Main form for the message client application
    /// </summary>
    public partial class MessageForm : Form
    {
        private MessageController _messageController;

        /// <summary>
        /// Contractor to initialize the form controls
        /// </summary>
        public MessageForm()
        {
            InitializeComponent();

            _messageController = new MessageController();
            CurrentUser.IncomingMessageEvent += ReceiveMessage_Event;
        }

        private void ReceiveMessage_Event(IMessage e)
        {
            Invoke((MethodInvoker)delegate
            {
                AddMessageToScreen(e);
            });
        }

        private void AddMessageToScreen(IMessage message)
        {
            Label lblMessage = new Label();
            lblMessage.Text = message.Text;

            if (CurrentUser.User.UserId != message.SenderId)
            {
                lblMessage.Margin = new Padding(panelMessages.Size.Width - lblMessage.Size.Width - 10, 0, 0, 0);
            }

            panelMessages.Controls.Add(lblMessage);
            panelMessages.ScrollControlIntoView(lblMessage);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IMessage newMessage = new Models.Message
            {
                MessageId = 1,
                ReceiverId = 1,
                SenderId = 1,
                Text = "Test a message that is really long and hope that it will wrap around to the next line.",
                MediaId = null,
                TimeStamp = DateTime.Now
            };

            AddMessageToScreen(newMessage);

            RabbitBus.SendMessage("magedassad1", newMessage);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ok = "ok";
        }
    }
}
