using System.Data.SqlClient;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Gets the connection string
    /// </summary>
    public static class TeaLeaveConnectionstring
    {
        /// <summary>
        /// returns the connection string of the tech support DB
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=TeaLeaves;Integrated Security=True");
        }
    }
}
