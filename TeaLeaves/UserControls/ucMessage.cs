using System.Data.SqlClient;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves.UserControls
{
    /// <summary>
    /// user control for the message feature
    /// </summary>
    public partial class ucMessage : UserControl
    {
        private MessageController _messageController;
        private GroupMemberController _groupMemberController;
        private UsersController _usersController;
        private ContactsController _contactsController;
        private object _selectedUser;
        private List<object> _allContacts;

        /// <summary>
        /// constructor to initialize components, controllers, and then load contacts
        /// </summary>
        public ucMessage()
        {
            InitializeComponent();

            _messageController = new MessageController();
            _groupMemberController = new GroupMemberController();
            _contactsController = new ContactsController();
            _usersController = new UsersController();

            LoadContacts();

            if (!IsHandleCreated)
            {
                Thread.Sleep(500);
            }
            CurrentUserStore.IncomingMessageEvent += ReceiveMessage_Event;
        }

        private void LoadContacts()
        {
            try
            {
                _allContacts = new List<object>();
                List<User> contactList = _contactsController.GetMessageContacts(CurrentUserStore.User);
                List<GroupMember> groupList = _groupMemberController.GetMyGroupContact(CurrentUserStore.User.UserId);

                _allContacts.AddRange(contactList);
                _allContacts.AddRange(groupList);

                _allContacts = _allContacts.OrderByDescending(c => ((dynamic)c).TimeStamp).ToList();
                lstContacts.Items.Clear();

                lstContacts.Items.AddRange(_allContacts.ToArray());

                if (_allContacts?.Count == 0)
                {
                    lstContacts.Items.Add("No contacts");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ReceiveMessage_Event(IUserMessage e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (_selectedUser != null && ((_selectedUser.GetType() == typeof(User) && ((User)_selectedUser).UserId == e.SenderId) ||
                                             (_selectedUser.GetType() == typeof(GroupMember) && ((GroupMember)_selectedUser).GroupId == e.GroupId)))
                {
                    AddMessageToScreen(e);
                }
                else
                {
                    UpdateContactUnreadStatus(e, true);
                }
            });
        }

        private void UpdateContactUnreadStatus(IUserMessage message, bool isUnread)
        {
            int senderIndex = _allContacts.FindIndex(c => (c.GetType() == typeof(User) && ((User)c).UserId == message.SenderId && !message.GroupId.HasValue) ||
                                                          (c.GetType() == typeof(GroupMember) && ((GroupMember)c).GroupId == message.GroupId));

            if (senderIndex > -1)
            {
                dynamic sender = _allContacts[senderIndex].GetType() == typeof(User) ? (User)_allContacts[senderIndex] : (GroupMember)_allContacts[senderIndex];
                sender.IsContainUnread = isUnread;

                lstContacts.Items.RemoveAt(senderIndex);
                lstContacts.Items.Insert(senderIndex, sender);

                if (isUnread == false)
                {
                    lstContacts.SelectedIndex = senderIndex;
                }
            }
            else
            {
                try
                {
                    if (message.GroupId.HasValue)
                    {
                        GroupMember groupInfo = _groupMemberController.GetGroupById(message.GroupId.Value);

                        if (groupInfo != null)
                        {
                            groupInfo.IsContainUnread = isUnread;
                            _allContacts.Insert(0, groupInfo);
                            lstContacts.Items.Insert(0, groupInfo);
                        }
                    }
                    else
                    {
                        User newUser = _usersController.GetUserById(message.SenderId);

                        if (newUser != null)
                        {
                            newUser.IsContainUnread = isUnread;
                            _allContacts.Insert(0, newUser);
                            lstContacts.Items.Insert(0, newUser);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private string GetUserNameById(int userId)
        {
            var user = _allContacts.Find(u => u.GetType() == typeof(User) && ((User)u).UserId == userId);

            if (user == null)
            {
                user = _usersController.GetUserById(userId);
            }

            return ((User)user).FullName;
        }

        private void AddMessageToScreen(IUserMessage message)
        {
            if (message.Text?.Trim().Length > 0)
            {
                Label lblMessage = new Label();
                lblMessage.Text = message.GroupId.HasValue ? $"{GetUserNameById(message.SenderId)}:{Environment.NewLine}{message.Text.Replace("\n", Environment.NewLine)}" : message.Text.Replace("\n", Environment.NewLine);
                lblMessage.BorderStyle = BorderStyle.FixedSingle;
                lblMessage.Padding = new Padding(5, 5, 5, 5);
                lblMessage.Margin = new Padding(0, 0, 20, 0);
                lblMessage.BackColor = Color.White;
                lblMessage.AutoSize = true;
                lblMessage.UseMnemonic = false;

                new ToolTip().SetToolTip(lblMessage, message.TimeStamp.ToString());

                tblMessages.RowCount++;
                tblMessages.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                int row = tblMessages.RowCount - 1;

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

                if (tblMessages.Controls.Count > 10)
                {
                    tblMessages.AutoScroll = true;
                    tblMessages.ScrollControlIntoView(lblMessage);
                }
                else
                {
                    tblMessages.AutoScroll = false;
                }
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
                    ReceiverId = _selectedUser.GetType() == typeof(User) ? ((User)_selectedUser).UserId : ((GroupMember)_selectedUser).GroupId,
                    SenderId = CurrentUserStore.User.UserId,
                    Text = txtMessage.Text,
                    MediaId = null,
                    GroupId = _selectedUser.GetType() == typeof(GroupMember) ? ((GroupMember)_selectedUser).GroupId : null,
                    TimeStamp = DateTime.Now
                };

                try
                {
                    _messageController.SaveMessageToDatabase(newMessage);
                    AddMessageToScreen(newMessage);
                    txtMessage.Clear();

                    if (_selectedUser.GetType() == typeof(User))
                    {
                        RabbitBusController.SendMessage(((User)_selectedUser).Username, newMessage);
                    }
                    else
                    {
                        GroupMember groupMember = (GroupMember)_selectedUser;
                        foreach (int userId in groupMember.UserIds)
                        {
                            User user = _usersController.GetUserById(userId);

                            if (user != null && user.UserId != CurrentUserStore.User.UserId)
                            {
                                RabbitBusController.SendMessage(user.Username, newMessage);
                            }
                        }
                    }
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
                tblMessages.RowCount = 0;

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

        private void LoadMessagesFromGroup(int groupId)
        {
            tblMessages.Controls.Clear();
            tblMessages.RowCount = 0;

            try
            {
                List<IUserMessage> userMessages = _messageController.GetMessagesByGroupId(groupId);

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
                User currentUser = (User)selectedItem;
                lblSelectedContact.Text = currentUser.FullName;

                if (currentUser.IsContainUnread)
                {
                    IUserMessage message = new UserMessage
                    {
                        GroupId = null,
                        MediaId = null,
                        SenderId = currentUser.UserId
                    };

                    UpdateContactUnreadStatus(message, false);
                }

                LoadMessagesFromUser(currentUser.UserId);
            }
            else if (lstContacts.SelectedIndex > -1 && selectedItem.GetType() == typeof(GroupMember))
            {
                _selectedUser = (GroupMember)selectedItem;
                GroupMember currentMember = (GroupMember)selectedItem;
                lblSelectedContact.Text = currentMember.GroupName;

                if (currentMember.IsContainUnread)
                {
                    IUserMessage message = new UserMessage
                    {
                        GroupId = currentMember.GroupId,
                        MediaId = null,
                        SenderId = currentMember.GroupId
                    };

                    UpdateContactUnreadStatus(message, false);
                }

                LoadMessagesFromGroup(currentMember.GroupId);
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
            else if (dataItem.GetType() == typeof(GroupMember))
            {
                GroupMember contact = (GroupMember)dataItem;

                if (contact.IsContainUnread)
                {
                    e.Graphics.DrawString($"Group - {contact.GroupName}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString($"Group - {contact.GroupName}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, e.Bounds);
                }

            }
            else if (dataItem.GetType() == typeof(string))
            {
                e.Graphics.DrawString(dataItem.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            List<User> usersOnly = _allContacts.Where(x => x.GetType() == typeof(User)).OfType<User>().ToList();

            using frmCreateGroup createGroup = new frmCreateGroup(usersOnly);
            var result = createGroup.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadContacts();
            }
        }
    }
}
