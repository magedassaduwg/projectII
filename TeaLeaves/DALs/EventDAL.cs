using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    public class EventDAL
    {
        public bool SaveEvent(Event @event)
        {
            string query = @"INSERT INTO Events (Description, Name, State, City, StreetNumber, [DateTime]) 
                             VALUES (@Description, @Name, @State, @City, @StreetNumber, @DateTime)";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
               
                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@Description", @event.Description);
                    saveCommand.Parameters.AddWithValue("@Name", @event.Name);
                    saveCommand.Parameters.AddWithValue("@State", @event.State);
                    saveCommand.Parameters.AddWithValue("@City", @event.City);
                    saveCommand.Parameters.AddWithValue("@StreetNumber", @event.StreetNumber);
                    saveCommand.Parameters.AddWithValue("@DateTime", @event.EventDateTime);

                    int rowsAffected = saveCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            }
    }
}
