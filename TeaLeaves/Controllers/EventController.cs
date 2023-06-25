using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller that interacts with the EventDAL
    /// </summary>
    public class EventController
    {
        private EventDAL _eventDAL;

        /// <summary>
        /// Constructor to initialize the DAL access
        /// </summary>
        public EventController()
        {
            _eventDAL = new EventDAL();
        }

        /// <summary>
        /// Saves the event to the database
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public int SaveEvent(Event @event)
        {
            return _eventDAL.SaveEvent(@event);
        }

        /// <summary>
        /// Deletes an event in the database
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public bool DeleteEvent(int eventId)
        {
            return _eventDAL.DeleteEvent(eventId);
        }

        /// <summary>
        /// Returns all the events the given user has received
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Event> GetEventsReceivedByUserId(int userId)
        {
            return _eventDAL.GetEventsReceivedByUserId(userId);
        }
        public List<Event> GetEventsReceivedByUserIdWithCategory(int userId, string category)
        {
            return _eventDAL.GetEventsReceivedByUserIdWithCategory(userId, category);
        }

        /// <summary>
        /// Returns all the events the given user has accepted
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetAcceptedEventsReceivedByUserId(int userId)
        {
            return _eventDAL.GetAcceptedEventsReceivedByUserId(userId);
        }

        /// <summary>
        /// Returns all the events the given user has declined
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetDeclinedEventsReceivedByUserId(int userId)
        {
            return _eventDAL.GetDeclinedEventsReceivedByUserId(userId);
        }

        /// <summary>
        /// Returns all the events in the database with the given creatorId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Event> GetEventsByUserId(int userId)
        {
            return _eventDAL.GetEventsByUserId(userId);
        }

        /// <summary>
        /// Returns an event by it's id
        /// </summary>
        /// <param name="selectedEventId"></param>
        /// <returns></returns>
        public Event GetEventById(int selectedEventId)
        {
            return _eventDAL.GetEventById(selectedEventId);
        }
        /// <summary>
        /// Get event by category name
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Event> GetEventByCategory(string category)
        {
            return _eventDAL.GetEventByCategory(category);
        }
        /// <summary>
        /// Get event by date
        /// </summary>
        /// <param name="eventDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Event> GetEventByDate(DateTime eventDate)
        {
            return _eventDAL.GetEventByDate(eventDate);
        }

        internal List<Event> GetEventsReceivedByUserIdWithDate(int userId, DateTimePicker dateTimePickerFilter)
        {
            throw new NotImplementedException();
        }
    }
}
