using System.Data.SqlClient;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Main form for the message client application
    /// </summary>
    public partial class MessageForm : Form
    {
        private MessageController _messageController;
        private ContactsController _contactsController;
        /// <summary>
        /// Contractor to initialize the form controls
        /// </summary>
        public MessageForm()
        {
            InitializeComponent();

            _messageController = new MessageController();
            _contactsController = new ContactsController();

            LoadContacts();
            CurrentUserStore.IncomingMessageEvent += ReceiveMessage_Event;
        }

        private void LoadContacts()
        {
            List<User> _contactList = _contactsController.GetUsersContacts(CurrentUserStore.User);

            lstContacts.Items.Clear();

            if (_contactList != null && _contactList.Count > 0)
            {
                lstContacts.Items.AddRange(_contactList.ToArray());
                lstContacts.DisplayMember = "FullName";
            }
            else
            {
                lstContacts.Items.Add("No contacts");
            }
        }

        private void ReceiveMessage_Event(IUserMessage e)
        {
            Invoke((MethodInvoker)delegate
            {
                AddMessageToScreen(e);
            });
        }

        private void AddMessageToScreen(IUserMessage message)
        {
            Label lblMessage = new Label();
            lblMessage.Text = message.Text;
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(panelMessages.Width - 50, 0);
            lblMessage.BorderStyle = BorderStyle.FixedSingle;

            if (CurrentUserStore.User.UserId != message.SenderId)
            {
                using (Graphics graphic = lblMessage.CreateGraphics())
                {
                    SizeF size = graphic.MeasureString(message.Text, lblMessage.Font);
                    //lblMessage.Margin = new Padding(panelMessages.Width - lblMessage.Width - 10, 0, 0, 0);
                    lblMessage.Margin = new Padding(panelMessages.Width - Convert.ToInt32(size.Width) - 10, 0, 0, 0);
                }
            }

            panelMessages.Controls.Add(lblMessage);
            panelMessages.ScrollControlIntoView(lblMessage);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)lstContacts.SelectedItem;

            if (selectedUser != null)
            {
                IUserMessage newMessage = new UserMessage
                {
                    ReceiverId = selectedUser.UserId,
                    SenderId = CurrentUserStore.User.UserId,
                    Text = txtMessage.Text,
                    MediaId = null,
                    TimeStamp = DateTime.Now
                };

                try
                {
                    _messageController.SaveMessageToDatabase(newMessage);
                    AddMessageToScreen(newMessage);
                    txtMessage.Clear();
                    RabbitBusController.SendMessage(selectedUser.Username, newMessage);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not send message", "Check your connection");
                }
            }
            else
            {
                MessageBox.Show("No contact selected", "Please select a contact");
            }
        }

        private void btnManageContacts_Click(object sender, EventArgs e)
        {
            using (ManageContactForm contacts = new ManageContactForm())
            {
                contacts.ShowDialog();
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)lstContacts.SelectedItem;
            lblSelectedContact.Text = selectedUser.FullName;

            LoadMessagesFromUser(selectedUser.UserId);
        }

        private void LoadMessagesFromUser(int contactId)
        {
            try
            {
                panelMessages.Controls.Clear();

                List<IUserMessage> userMessages = _messageController.GetMessagesByUserId(CurrentUserStore.User.UserId, contactId);

                if (userMessages != null && userMessages.Count > 0)
                {
                    foreach (IUserMessage message in userMessages)
                    {
                        AddMessageToScreen(message);
                    }
                }
                else
                {
                    Label lblMessage = new Label();
                    lblMessage.Text = "Chat History Is Empty";
                    panelMessages.Controls.Add(lblMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
