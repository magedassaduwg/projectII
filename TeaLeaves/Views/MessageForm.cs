using MassTransit.Logging;
using System.Collections.Generic;
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
                lstMessages.Items.Add(e);

                Label l = new Label();
                l.Text = e.Text;
                panelMessages.Controls.Add(l);
                panelMessages.ScrollControlIntoView(l);

            });
        }

        private void lstMessages_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(lstMessages.Items[e.Index].ToString(), lstMessages.Font, lstMessages.Width).Height;
        }

        private void lstMessages_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                dynamic currentObject = lstMessages.Items[e.Index];
                string output = currentObject.Text;
                int lineHeight = e.Bounds.Height;

                e.DrawBackground();
                e.DrawFocusRectangle();

                if (currentObject.SenderId == CurrentUser.User.UserId)
                {
                    float olength = e.Graphics.MeasureString(output, e.Font).Width;
                    float pos = lstMessages.Width - olength;

                    //SolidBrush brushBack = new SolidBrush(e.BackColor);
                    //e.Graphics.FillRectangle(brushBack, e.Bounds.Left, e.Bounds.Top + 50, e.Bounds.Width - 50, lineHeight);

                    //SolidBrush brush = new SolidBrush(e.ForeColor);
                    //e.Graphics.DrawString(output, e.Font, brush, pos, e.Bounds.Top);

                    e.Graphics.DrawString(output, e.Font, new SolidBrush(e.ForeColor), pos, e.Bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(output, e.Font, new SolidBrush(e.ForeColor), e.Bounds);

                    //SolidBrush brushBack = new SolidBrush(e.BackColor);
                    //e.Graphics.FillRectangle(brushBack, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width - 50, lineHeight);

                    //SolidBrush brush = new SolidBrush(e.ForeColor);
                    //e.Graphics.DrawString(output, e.Font, brush, 0, e.Bounds.Top);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IMessage newMessage = new Models.Message
            {
                MessageId = 1,
                ReceiverId = 1,
                SenderId = 1,
                Text = "Test a message that is really long and hope that it will wrap around to the next line. Test a message that is really long and hope that it will wrap around to the next line.",
                MediaId = null,
                TimeStamp = DateTime.Now
            };

            RabbitBus.SendMessage("magedassad1", newMessage);
        }
    }
}
