using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for the event class
    /// </summary>
    public class EventDAL
    {
        /// <summary>
        /// saves an event to the database
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool SaveEvent(Event @event)
        {

            string query = @"INSERT INTO Events (Description, Name, State, City, StreetNumber, Zipcode, EventDateTime, CreatorId) 
                             VALUES (@Description, @Name, @State, @City, @StreetNumber, @Zipcode, @EventDateTime, @CreatorId)";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
               
                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@Description", @event.Description);
                    saveCommand.Parameters.AddWithValue("@Name", @event.EventName);
                    saveCommand.Parameters.AddWithValue("@State", @event.State);
                    saveCommand.Parameters.AddWithValue("@City", @event.City);
                    saveCommand.Parameters.AddWithValue("@Zipcode", @event.Zipcode.ToString().TrimStart('0'));
                    saveCommand.Parameters.AddWithValue("@StreetNumber", @event.StreetNumber);
                    saveCommand.Parameters.AddWithValue("@EventDateTime", @event.EventDateTime);
                    saveCommand.Parameters.AddWithValue("@CreatorId", CurrentUserStore.User.UserId);

                    int rowsAffected = saveCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// Returns all Events which the given user by userId has been invited to
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetEventsReceivedByUserId(int userId)
        {
            List<Event> userEvents = new List<Event>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT e.EventId as UserEventId, CreatorId, EventDateTime, State, City, StreetNumber, Zipcode, Name, Description " +
                    "FROM Events e " +
                    "JOIN EventResponses er " +
                    "ON e.EventID = er.EventID " +
                    "WHERE er.EventReceiverId = @UserId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Event userEvent = new Event
                    {
                        Id = Convert.ToInt32(reader["UserEventId"]),
                        CreatorId = Convert.ToInt32(reader["CreatorId"]),
                        EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                        State = reader["State"].ToString(),
                        City = reader["City"].ToString(),
                        StreetNumber = reader["StreetNumber"].ToString(),
                        Zipcode = Convert.ToInt32(reader["Zipcode"]),
                        EventName = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                    };
                    userEvents.Add(userEvent);
                }
            }
            return userEvents;
            }
        public List<Event> GetEventsByUserId(int userId)
        {
            List<Event> events = new List<Event>();

            string query = @"SELECT EventId, EventDateTime, State, City, StreetNumber, Zipcode, Name, Description
                     FROM Events
                     WHERE CreatorId = @UserId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event @event = new Event
                            {
                                Id = Convert.ToInt32(reader["EventId"]),
                                EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                                State = reader["State"].ToString(),
                                City = reader["City"].ToString(),
                                StreetNumber = reader["StreetNumber"].ToString(),
                                Zipcode = Convert.ToInt32(reader["Zipcode"]),
                                EventName = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                            };

                            events.Add(@event);
                        }
                    }
                }
            }

            return events;
        }

    }
}
