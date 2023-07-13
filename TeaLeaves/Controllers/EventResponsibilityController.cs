using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller for the EventResponsibilityDAL
    /// </summary>
    public class EventResponsibilityController
    {
        private EventResponsibilityDAL _eventResponsibilityDAL;

        /// <summary>
        /// The constructor for the EventResponsibilityController
        /// </summary>
        public EventResponsibilityController()
        {
            _eventResponsibilityDAL = new EventResponsibilityDAL();
        }

        /// <summary>
        /// Deletes the given eventResponsibility from the database
        /// </summary>
        /// <param name="eventResponsibilityId"></param>
        /// <returns></returns>
        public bool DeleteEventResponsibility(int eventResponsibilityId)
        {
            return _eventResponsibilityDAL.DeleteEventResponsibility(eventResponsibilityId);
        }

        /// <summary>
        /// Adds a new EventResponsibility to the database and returns the Id
        /// </summary>
        /// <param name="eventResponsibility"></param>
        /// <returns></returns>
        public int AddEventResponsibility(EventResponsibility eventResponsibility)
        {
            return _eventResponsibilityDAL.AddEventResponsibility(eventResponsibility);
        }

        /// <summary>
        /// Assigns a user to an EventResponsibility
        /// </summary>
        /// <param name="user"></param>
        /// <param name="eventId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int AssignEventResponsibility(User user, int eventId, string name)
        {
            return _eventResponsibilityDAL.AssignEventResponsibility(user, eventId, name);
        }

        /// <summary>
        /// Removes the user from a given EventResponsibility
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int UnassignEventResponsibility(int eventId, string name)
        {
            return _eventResponsibilityDAL.UnassignEventResponsibility(eventId, name);
        }

        /// <summary>
        /// Returns a list of EventResponsibilities from the database based on the given userId and eventId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetEventResponsibilitiesByUserIdAndEventId(int userId, int eventId)
        {
            return _eventResponsibilityDAL.GetEventResponsibilitiesByUserIdAndEventId(userId, eventId);
        }

        /// <summary>
        /// Returns a list of EventResponsibilities from the database based on the given eventId
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetEventResponsibilitiesByEventId(int eventId)
        {
            return _eventResponsibilityDAL.GetEventResponsibilitiesByEventId(eventId);
        }

        /// <summary>
        /// Returns a list of EventResponsibilities from the database based on the given eventId which have not been assigned
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public List<EventResponsibility> GetUnassignedEventResponsibilitiesByEventId(int eventId)
        {
            return _eventResponsibilityDAL.GetUnassignedEventResponsibilitiesByEventId(eventId);
        }
    }
}
