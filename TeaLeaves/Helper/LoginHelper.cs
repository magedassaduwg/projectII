

namespace TeaLeaves.Helper
{
    public static class LoginHelper
    {
        private static readonly string CredentialsFilePath = "loginCredentials.txt";
        public static void SaveCredentials(string username, string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(CredentialsFilePath))
                {
                    writer.WriteLine(username);
                    writer.WriteLine(password);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error saving login credentials: {ex.Message}");
            }
        }
        public static (string username, string password) LoadCredentials()
        {
            string username = string.Empty;
            string password = string.Empty;

            try
            {
                if (File.Exists(CredentialsFilePath))
                {
                    using (StreamReader reader = new StreamReader(CredentialsFilePath))
                    {
                        username = reader.ReadLine();
                        password = reader.ReadLine();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error loading login credentials: {ex.Message}");
            }

            return (username, password);
        }
    }

}
