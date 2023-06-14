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
        public int SaveEvent(Event @event)
        {
            string query = @event.Id <= 0 ?
                @"INSERT INTO Events (Description, Name, State, City, StreetNumber, Zipcode, EventDateTime, CreatorId) 
        VALUES (@Description, @Name, @State, @City, @StreetNumber, @Zipcode, @EventDateTime, @CreatorId)"
                :
                @"UPDATE Events 
        SET Name = @Name, StreetNumber = @StreetNumber, State = @State, City = @City, Zipcode = @Zipcode, EventDateTime = @EventDateTime, Description = @Description 
        WHERE eventId = @eventId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@eventId", @event.Id);
                    saveCommand.Parameters.AddWithValue("@Description", @event.Description);
                    saveCommand.Parameters.AddWithValue("@State", @event.State);
                    saveCommand.Parameters.AddWithValue("@City", @event.City);
                    if (@event.Zipcode != 0)
                    {
                        saveCommand.Parameters.AddWithValue("@Zipcode", @event.Zipcode.ToString().TrimStart('0'));
                    }
                    else
                    {
                        saveCommand.Parameters.AddWithValue("@Zipcode", "00000");
                    }
                    saveCommand.Parameters.AddWithValue("@StreetNumber", @event.StreetNumber);
                    saveCommand.Parameters.AddWithValue("@Name", @event.EventName);
                    saveCommand.Parameters.AddWithValue("@EventDateTime", @event.EventDateTime);
                    saveCommand.Parameters.AddWithValue("@CreatorId", CurrentUserStore.User.UserId);
                    saveCommand.Parameters.AddWithValue("@eventId", @event.Id);

                    return Convert.ToInt32(saveCommand.ExecuteScalar());
                }
            }
        }


        /// <summary>
        /// Deletes an event from the database
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public bool DeleteEvent(int eventId)
        {
            string query = @"DELETE Events " +
                            "WHERE EventId = @eventId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@eventId", eventId);

                    int rowsAffected = saveCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// Returns all Events which the given user by userId has been invited to and has accepted
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetAcceptedEventsReceivedByUserId(int userId)
        {
            List<Event> userEvents = new List<Event>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT e.EventId as UserEventId, CreatorId, EventDateTime, State, City, StreetNumber, Zipcode, Name, Description " +
                    "FROM Events e " +
                    "JOIN EventResponses er " +
                    "ON e.EventID = er.EventID " +
                    "WHERE er.EventReceiverId = @UserId AND er.Accepted = 1;";

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
                    "WHERE er.EventReceiverId = @UserId AND er.Accepted = 0;";

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

        /// <summary>
        /// Returns all the Events in the database with the given creatorId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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

        public Event GetEventById(int selectedEventId)
        {
            Event @event = null;

            string selectStatement = @"SELECT [EventId],[Name],[StreetNumber],[City] ,[State], [Zipcode] , [EventDateTime], [Description],[CreatorId] " +
                "FROM [Events]  " +
                "Where EventId = @EventId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@EventId", selectedEventId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            @event = new Event
                            {
                                Id = Convert.ToInt32(reader["EventId"]),
                                CreatorId = Convert.ToInt32(reader["CreatorId"]),
                                EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                                State = reader["State"].ToString(),
                                City = reader["City"].ToString(),
                                StreetNumber = reader["StreetNumber"].ToString(),
                                Zipcode = Convert.ToInt32(reader["Zipcode"]),
                                EventName = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                            };
                           
                        }
                    }

                }
            }
            return @event;
        }

    }
    
}
    
