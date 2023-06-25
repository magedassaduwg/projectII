using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// A small form to display a users contact list to create a new message group
    /// </summary>
    public partial class frmCreateGroup : Form
    {
        private GroupMemberController _groupMemberController;
        private List<User> _contactList;

        /// <summary>
        /// Constructor to display list of contacts
        /// </summary>
        /// <param name="contactList"></param>
        public frmCreateGroup(List<User> contactList)
        {
            _contactList = contactList;
            _groupMemberController = new GroupMemberController();

            InitializeComponent();
        }

        private void frmCreateGroup_Load(object sender, EventArgs e)
        {
            lstContacts.Items.Clear();
            lstContacts.Items.AddRange(_contactList.ToArray());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Group name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGroupName.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            if (lstContacts.SelectedItems.Count > 1)
            {
                try
                {
                    List<int> userIds = lstContacts.SelectedItems.OfType<User>().ToArray().Select(u => u.UserId).ToList();
                    userIds.Insert(0, CurrentUserStore.User.UserId);

                    _groupMemberController.CreateNewGroup(txtGroupName.Text.Trim(), string.Join(",", userIds));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Not enough contacts selected, please choose at least 2 contacts", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
    }
}
