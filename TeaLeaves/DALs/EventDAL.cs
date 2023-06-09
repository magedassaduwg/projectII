﻿using System.Data.SqlClient;
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
        public int SaveEvent(Event @event, List<EventResponsibility> eventResponsibilities)
        {
            string query = @event.Id <= 0 ?
                @"INSERT INTO Events (Description, Name, Category, State, City, StreetNumber, Zipcode, EventDateTime, CreatorId) 
                VALUES (@Description, @Name, @Category, @State, @City, @StreetNumber, @Zipcode, @EventDateTime, @CreatorId)
                select scope_identity()"
                :
                @"UPDATE Events 
                SET Name = @Name, Category = @Category, StreetNumber = @StreetNumber, State = @State, City = @City, Zipcode = @Zipcode, EventDateTime = @EventDateTime, Description = @Description 
                WHERE eventId = @eventId

                select @eventId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (SqlCommand saveCommand = new SqlCommand(query, connection, transaction))
                {
                    saveCommand.Parameters.AddWithValue("@eventId", @event.Id);
                    saveCommand.Parameters.AddWithValue("@Description", @event.Description);
                    saveCommand.Parameters.AddWithValue("@State", @event.State);
                    saveCommand.Parameters.AddWithValue("@City", @event.City);
                    saveCommand.Parameters.AddWithValue("@Category", @event.Category);
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
                    saveCommand.Parameters.AddWithValue("@CreatorId", @event.CreatorId);

                    try
                    {
                        int lastEvent = Convert.ToInt32(saveCommand.ExecuteScalar());

                        foreach(EventResponsibility eventResponsibility in eventResponsibilities)
                        {
                            SqlCommand insertResponsibilitiesCommand = new SqlCommand("INSERT INTO EventResponsibilities (EventId, Name) " +
                            "Values (@EventId, @Name); ", connection, transaction);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@Name", eventResponsibility.Name);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@EventId", lastEvent);
                            insertResponsibilitiesCommand.ExecuteNonQuery();
                        }
                        
                        transaction.Commit();

                        return lastEvent;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                    
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
                string query = @"SELECT e.EventId as UserEventId, CreatorId, FirstName, LastName, EventDateTime, Category, State, City, StreetNumber, Zipcode, Name, Description
                    FROM Events e
                    JOIN EventResponses er
                    ON e.EventID = er.EventID
                    JOIN Users u
                    ON u.UserId = e.CreatorId
                    WHERE er.EventReceiverId = @UserId AND er.Accepted = 1 AND e.EventDateTime > GETDATE();";

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
                        CreatorName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                        EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                        State = reader["State"].ToString(),
                        City = reader["City"].ToString(),
                        StreetNumber = reader["StreetNumber"].ToString(),
                        Zipcode = Convert.ToInt32(reader["Zipcode"]),
                        EventName = reader["Name"].ToString(),
                        Category = reader["Category"].ToString(),
                        Description = reader["Description"].ToString(),
                    };
                    userEvents.Add(userEvent);
                }
            }
            return userEvents;
        }

        /// <summary>
        /// Returns all Events which the given user by userId has been invited to and has declined
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetDeclinedEventsReceivedByUserId(int userId)
        {
            List<Event> userEvents = new List<Event>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT e.EventId as UserEventId, CreatorId, FirstName, LastName, EventDateTime, Category, State, City, StreetNumber, Zipcode, Name, Description
                                 FROM Events e
                                 JOIN EventResponses er
                                 ON e.EventID = er.EventID
                                 JOIN Users u
                                 ON u.UserId = e.CreatorId
                                 WHERE er.EventReceiverId = @UserId AND er.Declined = 1 AND e.EventDateTime > GETDATE();";

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
                        CreatorName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                        EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                        State = reader["State"].ToString(),
                        City = reader["City"].ToString(),
                        StreetNumber = reader["StreetNumber"].ToString(),
                        Zipcode = Convert.ToInt32(reader["Zipcode"]),
                        EventName = reader["Name"].ToString(),
                        Category = reader["Category"].ToString(),
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
                string query = @"SELECT e.EventId as UserEventId, CreatorId, FirstName, LastName, EventDateTime, Category, State, City, StreetNumber, Zipcode, Name, Description
                                 FROM Events e
                                 JOIN EventResponses er
                                 ON e.EventID = er.EventID
                                 JOIN Users u
                                 ON u.UserId = e.CreatorId
                                 WHERE er.EventReceiverId = @UserId AND er.Accepted = 0 AND er.Declined = 0 AND e.EventDateTime > GETDATE();";

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
                        CreatorName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                        EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                        State = reader["State"].ToString(),
                        City = reader["City"].ToString(),
                        StreetNumber = reader["StreetNumber"].ToString(),
                        Zipcode = Convert.ToInt32(reader["Zipcode"]),
                        EventName = reader["Name"].ToString(),
                        Category = reader["Category"].ToString(),
                        Description = reader["Description"].ToString(),
                    };
                    userEvents.Add(userEvent);
                }
            }
            return userEvents;
        }

        /// <summary>
        /// Returns the past events the user has been invited to
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetPastEventsReceivedByUserId(int userId)
        {
            List<Event> userEvents = new List<Event>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT e.EventId as UserEventId, CreatorId, FirstName, LastName, EventDateTime, Category, State, City, StreetNumber, Zipcode, Name, Description, Accepted, Declined
                                 FROM Events e
                                 JOIN EventResponses er
                                 ON e.EventID = er.EventID
                                 JOIN Users u
                                 ON u.UserId = e.CreatorId
                                 WHERE er.EventReceiverId = @UserId AND e.EventDateTime < GETDATE();";

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
                        CreatorName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                        EventDateTime = Convert.ToDateTime(reader["EventDateTime"]),
                        State = reader["State"].ToString(),
                        City = reader["City"].ToString(),
                        StreetNumber = reader["StreetNumber"].ToString(),
                        Zipcode = Convert.ToInt32(reader["Zipcode"]),
                        EventName = reader["Name"].ToString(),
                        Category = reader["Category"].ToString(),
                        Description = reader["Description"].ToString(),
                        Accepted = Convert.ToInt32(reader["Accepted"]) > 0,
                        Declined = Convert.ToInt32(reader["Declined"]) > 0,
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

            string query = @"SELECT EventId, EventDateTime, State, City, StreetNumber, Zipcode, Name, Category, Description
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
                                Category = reader["Category"].ToString(),
                                Description = reader["Description"].ToString(),
                            };

                            events.Add(@event);
                        }
                    }
                }
            }

            return events;
        }
        /// <summary>
        /// Get event by ID
        /// </summary>
        /// <param name="selectedEventId"></param>
        /// <returns></returns>
        public Event GetEventById(int selectedEventId)
        {
            Event @event = null;

            string selectStatement = @"SELECT [EventId],[Name],[Category],[StreetNumber],[City] ,[State], [Zipcode] , [EventDateTime], [Description],[CreatorId] " +
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
                                Category = reader["Category"].ToString(),
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


