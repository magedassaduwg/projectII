using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for interacting with the EventResponsibilities table
    /// </summary>
    public class EventResponsibilityDAL
    {
        /// <summary>
        /// Inserts a new EventResponsibility row into the database
        /// </summary>
        /// <param name="eventResponse"></param>
        /// <returns></returns>
        public int AddEventResponsibility(EventResponsibility @eventResponsibility)
        {
            string query = @"INSERT INTO EventResponsbilities (EventId, UserId, Name) 
                             VALUES (@EventId, @UserId, @Name)
                             select scope_identity()";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@EventId", @eventResponsibility.EventId);
                    saveCommand.Parameters.AddWithValue("@UserId", @eventResponsibility.EventId);
                    saveCommand.Parameters.AddWithValue("@Name", @eventResponsibility.EventId);
                    return Convert.ToInt32(saveCommand.ExecuteScalar());
                }
            }
        }
    }
}
