using System.Data.SqlClient;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Gets the connection string
    /// </summary>
    public static class TeaLeavesConnectionstring
    {
        /// <summary>
        /// returns the connection string of the tech support DB
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=SQL5106.site4now.net;Initial Catalog=db_a8fed6_tealeaves;User Id=db_a8fed6_tealeaves_admin;Password=Te@Leave$F0rLif3;");
            //return new SqlConnection("Data Source=localhost;Initial Catalog=TeaLeaves;Integrated Security=True");
        }
    }
}
