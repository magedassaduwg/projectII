using System.ComponentModel;
using System.Data.SqlClient;
using System.Media;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;
using Tulpep.NotificationWindow;

namespace TeaLeaves.UserControls
{
    /// <summary>
    /// user control for the message feature
    /// </summary>
    public partial class ucMessage : UserControl
    {
        private IContainer _components;
        private MessageController _messageController;
        private GroupMemberController _groupMemberController;
        private UsersController _usersController;
        private ContactsController _contactsController;
        private object _selectedUser;
        private List<IUserMessage> _userMessages;
        private List<object> _allContacts;
        private string _messageImage;
        private bool _isFormMinimized = false;
        private int _searchIndex;

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
                if (_selectedUser != null && ((_selectedUser.GetType() == typeof(User) && e.GroupId == null && ((User)_selectedUser).UserId == e.SenderId) ||
                                             (_selectedUser.GetType() == typeof(GroupMember) && e.GroupId.HasValue && ((GroupMember)_selectedUser).GroupId == e.GroupId)))
                {
                    AddMessageToScreen(e);
                }
                else
                {
                    UpdateContactUnreadStatus(e, true);
                }

                ShowNotification(e);
                playSimpleSound();
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
            int row = tblMessages.RowCount - 1;

            if (row < 1)
            {
                tblMessages.AutoScroll = true;
                tblMessages.RowStyles.Clear();
                tblMessages.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));
            }

            if (message.MediaId.HasValue)
            {
                try
                {
                    string base64Image = _messageController.GetMediaById(message.MediaId.Value);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64Image)));
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ContextMenuStrip = cmsMessage;
                    pictureBox.Name = message.MessageId.ToString();

                    tblMessages.RowCount++;
                    row = tblMessages.RowCount - 1;

                    if (CurrentUserStore.User.UserId == message.SenderId)
                    {
                        pictureBox.Dock = DockStyle.Right;
                        tblMessages.Controls.Add(pictureBox, 1, row);
                    }
                    else
                    {
                        pictureBox.Dock = DockStyle.Left;
                        tblMessages.Controls.Add(pictureBox, 0, row);
                    }

                    tblMessages.ScrollControlIntoView(pictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

            if (!string.IsNullOrEmpty(message.Text))
            {
                Label lblMessage = new Label();
                lblMessage.Text = message.GroupId.HasValue ? $"{GetUserNameById(message.SenderId)}:{Environment.NewLine}{message.Text.Replace("\n", Environment.NewLine)}" : message.Text.Replace("\n", Environment.NewLine);
                lblMessage.BorderStyle = BorderStyle.FixedSingle;
                lblMessage.Padding = new Padding(5, 5, 5, 5);
                lblMessage.Margin = new Padding(0, 0, 20, 0);
                lblMessage.BackColor = Color.White;
                lblMessage.AutoSize = true;
                lblMessage.UseMnemonic = false;
                lblMessage.ContextMenuStrip = cmsMessage;
                lblMessage.Name = message.MessageId.ToString();

                new ToolTip().SetToolTip(lblMessage, message.TimeStamp.ToLocalTime().ToString());

                tblMessages.RowCount++;
                tblMessages.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                row = tblMessages.RowCount - 1;

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

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {
                try
                {
                    int mediaId = 0;

                    if (!string.IsNullOrEmpty(_messageImage))
                    {
                        mediaId = _messageController.SaveImageToDatabase(_messageImage);
                    }

                    IUserMessage newMessage = new UserMessage
                    {
                        ReceiverId = _selectedUser.GetType() == typeof(User) ? ((User)_selectedUser).UserId : CurrentUserStore.User.UserId,
                        SenderId = CurrentUserStore.User.UserId,
                        Text = txtMessage.Text,
                        MediaId = mediaId > 0 ? mediaId : null,
                        GroupId = _selectedUser.GetType() == typeof(GroupMember) ? ((GroupMember)_selectedUser).GroupId : null,
                        TimeStamp = DateTime.Now.ToUniversalTime(),
                    };

                    newMessage.MessageId = _messageController.SaveMessageToDatabase(newMessage);
                    AddMessageToScreen(newMessage);

                    txtMessage.Clear();
                    ResetImagePreview();

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

                _userMessages = _messageController.GetMessagesByUserId(CurrentUserStore.User.UserId, contactId);

                if (_userMessages != null && _userMessages.Count > 0)
                {
                    foreach (IUserMessage message in _userMessages)
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

                Size size = new Size(tblMessagesWithHeader.Width - 10, Convert.ToInt32(tblMessagesWithHeader.Height / 1.15));
                SplashScreen.ShowSplashScreen(tblMessages.PointToScreen(Point.Empty), size);

                LoadMessagesFromUser(currentUser.UserId);

                SplashScreen.CloseForm();
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

                Size size = new Size(tblMessagesWithHeader.Width - 10, Convert.ToInt32(tblMessagesWithHeader.Height / 1.15));
                SplashScreen.ShowSplashScreen(tblMessages.PointToScreen(Point.Empty), size);

                LoadMessagesFromGroup(currentMember.GroupId);

                SplashScreen.CloseForm();
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpener = new OpenFileDialog();
            fileOpener.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(fileOpener.FileName);

                if (info.Length > 3000000)
                {
                    MessageBox.Show("File size is too large", "Max file size is 3MB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetImagePreview();
                }
                else
                {
                    byte[] imageArray = File.ReadAllBytes(fileOpener.FileName);
                    _messageImage = Convert.ToBase64String(imageArray);
                    btnImagePreview.BackgroundImage = Image.FromStream(new MemoryStream(Convert.FromBase64String(_messageImage)));
                    btnImagePreview.Visible = true;
                }
            }
        }

        private void ResetImagePreview()
        {
            _messageImage = string.Empty;
            btnImagePreview.BackgroundImage = null;
            btnImagePreview.Visible = false;
        }

        private void btnImagePreview_Click(object sender, EventArgs e)
        {
            ResetImagePreview();
        }

        private void ucMessage_Resize(object sender, EventArgs e)
        {
            //_isFormMinimized = ((ucMessage)sender).Size == new Size(0, 0);
            if (ParentForm != null)
                _isFormMinimized = ParentForm.WindowState == FormWindowState.Minimized;
        }

        private void ShowNotification(IUserMessage message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Incoming Message";
            popup.ContentText = message.Text;
            popup.Click += Popup_Click;
            popup.Popup();
        }

        private void Popup_Click(object? sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Normal;
            ParentForm.Activate();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Resources\\notification.wav");
            simpleSound.Play();
        }

        private void cmsMessage_Opening(object sender, CancelEventArgs e)
        {
            cmsMessage.Items.Clear();

            ToolStripItem title = new ToolStripMenuItem();
            title.Text = "Forward Message To:";
            title.Enabled = false;

            cmsMessage.Items.Add(title);

            foreach (var contact in _allContacts)
            {
                if (contact.GetType() == typeof(User))
                {
                    User user = (User)contact;
                    ToolStripItem tsContact = new ToolStripMenuItem(user.FullName, null, ForwardMessageToUser,
                        $"{((ContextMenuStrip)sender).SourceControl.Name}:{user.UserId}");
                    cmsMessage.Items.Add(tsContact);
                }
                else
                {
                    GroupMember group = (GroupMember)contact;
                    ToolStripItem tsContact = new ToolStripMenuItem(group.GroupName, null, ForwardMessageToGroup,
                        $"{((ContextMenuStrip)sender).SourceControl.Name}:{group.GroupId}");
                    cmsMessage.Items.Add(tsContact);
                }

            }
        }

        private void ForwardMessageToUser(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string[] ids = item.Name.Split(':', StringSplitOptions.RemoveEmptyEntries);
            int messageId = Convert.ToInt32(ids[0]);
            int userId = Convert.ToInt32(ids[1]);

            try
            {
                _messageController.ForwardMessage(messageId, CurrentUserStore.User.UserId, userId, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void ForwardMessageToGroup(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string[] ids = item.Name.Split(':', StringSplitOptions.RemoveEmptyEntries);
            int messageId = Convert.ToInt32(ids[0]);
            int groupId = Convert.ToInt32(ids[1]);

            try
            {
                _messageController.ForwardMessage(messageId, CurrentUserStore.User.UserId, groupId, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && _userMessages != null && _userMessages.Count > 0)
            {
                IUserMessage message = _userMessages.Where(x => x.Text.ToLower().IndexOf(txtSearch.Text.ToLower().Trim()) > -1).Skip(_searchIndex).FirstOrDefault();
                if (message != null)
                {
                    foreach (Control ctrl in tblMessages.Controls)
                    {
                        if (ctrl.Name.Equals(message.MessageId.ToString()))
                        {
                            tblMessages.ScrollControlIntoView(ctrl);
                            _searchIndex++;
                        }
                    }
                }
                else
                {
                    if (_searchIndex == 0)
                    {
                        MessageBox.Show($"Could not find a message containing \"{txtSearch.Text}\"", "No match");
                    }
                    else
                    {
                        MessageBox.Show("Could not find anymore messages matching the search keyword", "No more matching");
                    }
                }
            }
        }
    }
}
