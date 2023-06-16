using System.Data.SqlClient;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    public partial class ucMessage : UserControl
    {
        private MessageController _messageController;
        private ContactsController _contactsController;
        private User _selectedUser;
        private List<User> _contactList;

        public ucMessage()
        {
            InitializeComponent();

            _messageController = new MessageController();
            _contactsController = new ContactsController();

            LoadContacts();

            if(!IsHandleCreated)
            {
                Thread.Sleep(500);
            }
            CurrentUserStore.IncomingMessageEvent += ReceiveMessage_Event;
        }

        private void LoadContacts()
        {
            _contactList = _contactsController.GetUsersContacts(CurrentUserStore.User);

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
                if (_selectedUser != null && _selectedUser.UserId == e.SenderId)
                {
                    AddMessageToScreen(e);
                }
                else
                {
                    UpdateContactUnreadStatus(e.SenderId, true);
                }
            });
        }

        private void UpdateContactUnreadStatus(int senderId, bool isUnread)
        {
            int senderIndex = _contactList.FindIndex(c => c.UserId == senderId);

            if (senderIndex > -1)
            {
                User sender = _contactList[senderIndex];
                sender.IsContainUnread = isUnread;

                lstContacts.Items.Insert(senderIndex, sender);
                lstContacts.Items.RemoveAt(senderIndex + 1);

                if (isUnread == false)
                {
                    lstContacts.SelectedIndex = senderIndex;
                }
            }
        }

        private void AddMessageToScreen(IUserMessage message)
        {
            if (message.Text?.Trim().Length > 0)
            {
                Label lblMessage = new Label();
                lblMessage.Text = message.Text;
                lblMessage.AutoSize = true;
                lblMessage.BorderStyle = BorderStyle.FixedSingle;
                lblMessage.Padding = new Padding(5, 5, 5, 5);
                lblMessage.Margin = new Padding(0, 0, 20, 0);
                lblMessage.BackColor = Color.White;
                new ToolTip().SetToolTip(lblMessage, message.TimeStamp.ToString());

                int row = tblMessages.RowCount - 1;

                if (tblMessages.RowCount == 1 && tblMessages.GetControlFromPosition(0, 0) == null
                    && tblMessages.GetControlFromPosition(1, 0) == null)
                {
                    row = 0;
                }
                else
                {
                    tblMessages.RowCount = tblMessages.RowCount + 1;
                    tblMessages.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                if (CurrentUserStore.User.UserId == message.SenderId)
                {
                    lblMessage.Dock = DockStyle.Right;
                    tblMessages.Controls.Add(lblMessage, 1, row);
                }
                else
                {
                    lblMessage.Dock = DockStyle.Left;
                    tblMessages.Controls.Add(lblMessage, 0, row);
                }

                tblMessages.ScrollControlIntoView(lblMessage);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Trim().Length == 0)
            {
                return;
            }

            if (_selectedUser != null)
            {
                IUserMessage newMessage = new UserMessage
                {
                    ReceiverId = _selectedUser.UserId,
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
                    RabbitBusController.SendMessage(_selectedUser.Username, newMessage);
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

            LoadContacts();
        }

        private void LoadMessagesFromUser(int contactId)
        {
            try
            {
                tblMessages.Controls.Clear();

                List<IUserMessage> userMessages = _messageController.GetMessagesByUserId(CurrentUserStore.User.UserId, contactId);

                if (userMessages != null && userMessages.Count > 0)
                {
                    foreach (IUserMessage message in userMessages)
                    {
                        AddMessageToScreen(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lstContacts.SelectedItem;

            if (lstContacts.SelectedIndex > -1 && selectedItem.GetType() == typeof(User))
            {
                _selectedUser = (User)selectedItem;
                lblSelectedContact.Text = _selectedUser.FullName;

                if (_selectedUser.IsContainUnread)
                {
                    UpdateContactUnreadStatus(_selectedUser.UserId, false);
                }

                LoadMessagesFromUser(_selectedUser.UserId);
            }
        }

        private void lstContacts_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var dataItem = lstContacts.Items[e.Index];

            if (dataItem.GetType() == typeof(User))
            {
                User contact = (User)dataItem;

                if (contact.IsContainUnread)
                {
                    e.Graphics.DrawString(contact.FullName, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString(contact.FullName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, e.Bounds);
                }
            }
            else if (dataItem.GetType() == typeof(string))
            {
                e.Graphics.DrawString(dataItem.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
    }
}
