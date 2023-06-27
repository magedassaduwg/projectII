﻿using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for interacting with the EventResponsibilities table
    /// </summary>
    public class EventResponsibilityDAL
    {

        /// <summary>
        /// Deletes an EventResponsibility from the database
        /// </summary>
        /// <param name="eventResponsibilityId"></param>
        /// <returns></returns>
        public bool DeleteEventResponsibility(int eventResponsibilityId)
        {
            string query = @"DELETE FROM EventResponsbilities
                             WHERE EventResponsbilityId = @EventResponsbilityId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@EventResponsbilityId", eventResponsibilityId);
                    return saveCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Inserts a new EventResponsibility row into the database
        /// </summary>
        /// <param name="eventResponsibility"></param>
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

        /// <summary>
        /// method to retrieve a list of EventResponsibilities with the given UserId and EventId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetEventResponsibilitiesByUserIdAndEventId(int userId, int eventId)
        {
            List<EventResponsibility> userEventResponses = new List<EventResponsibility>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT EventId, FirstName, LastName, Name
                                 FROM EventResponsibilities er JOIN Users u 
                                 ON u.UserId = er.UserId WHERE er.UserId = @userId And er.EventId = @eventId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventResponsibility userEventResponse = new EventResponsibility
                    {
                        Id = Convert.ToInt32(reader["EventResponseId"]),
                        EventId = Convert.ToInt32(reader["EventId"]),
                    };
                    userEventResponses.Add(userEventResponse);
                }
            }
            return userEventResponses;
        }

        /// <summary>
        /// method to retrieve a list of EventResponsibilities with the given EventId
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetEventResponsibilitiesByEventId(int eventId)
        {
            List<EventResponsibility> userEventResponses = new List<EventResponsibility>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT EventId, FirstName, LastName, Name
                                 FROM EventResponsibilities er JOIN Users u 
                                 ON u.UserId = er.UserId WHERE er.EventId = @eventId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventResponsibility userEventResponse = new EventResponsibility
                    {
                        Id = Convert.ToInt32(reader["EventResponseId"]),
                        EventId = Convert.ToInt32(reader["EventId"]),
                    };
                    userEventResponses.Add(userEventResponse);
                }
            }
            return userEventResponses;
        }

        /// <summary>
        /// method to retrieve a list of EventResponsibilities with the given EventId
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetUnassignedEventResponsibilitiesByEventId(int eventId)
        {
            List<EventResponsibility> userEventResponses = new List<EventResponsibility>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT EventId, FirstName, LastName, Name
                                 FROM EventResponsibilities er JOIN Users u 
                                 ON u.UserId = er.UserId WHERE er.UserId IS NULL And er.EventId = @eventId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@eventId", eventId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventResponsibility userEventResponse = new EventResponsibility
                    {
                        Id = Convert.ToInt32(reader["EventResponseId"]),
                        EventId = Convert.ToInt32(reader["EventId"]),
                    };
                    userEventResponses.Add(userEventResponse);
                }
            }
            return userEventResponses;
        }
    }
}
