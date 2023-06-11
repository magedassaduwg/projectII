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
        public bool SaveEvent(Event @event)
        {
            return _eventDAL.SaveEvent(@event);
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

        public List<Event> GetAllEvents(int userId)
        {
            return _eventDAL.GetEventsByUserId(userId);
        }
    }
}
