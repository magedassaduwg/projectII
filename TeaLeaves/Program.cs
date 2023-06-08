using TeaLeaves.Controllers;
using TeaLeaves.Models;
using TeaLeaves.Views;

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
            try
            {
                User user = new User
                {
                    Email = "assadmaged@gmail.com",
                    FirstName = "Maged",
                    LastName = "Assad",
                    Password = "password123",
                    UserId = 1,
                    Username = "magedassad1"
                };

                CurrentUser.SetCurrentUser(user);
            }
            catch (Exception)
            {

                throw;
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MessageForm());
        }
    }
}