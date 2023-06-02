using TeaLeaves.Controllers;
using TeaLeaves.Models;
using Message = TeaLeaves.Models.Message;

namespace TeaLeaves
{
    /// <summary>
    /// Main entry to the program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RabbitBus.InitializeRabbitConnection();
            RabbitBus.AddConsumer("magedassad");
            IMessage newMessage = new Message
            {
                MessageId = 1,
                ReceiverId = 1,
                SenderId = 1,
                Text = "Test",
                MediaId = null,
                TimeStamp = DateTime.Now
            };

            RabbitBus.SendMessage("magedassad", newMessage);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}