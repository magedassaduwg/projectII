using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller for the EventResponseDAL
    /// </summary>
    public class EventResponseController
    {
        EventResponseDAL _eventResponseDAL;

        /// <summary>
        /// The constructor for the EventResponseController class
        /// </summary>
        public EventResponseController()
        {
            _eventResponseDAL = new EventResponseDAL();
        }

        /// <summary>
        /// Adds an EventResponse to the database
        /// </summary>
        /// <param name="eventResponse"></param>
        /// <returns></returns>
        public int AddEventResponse(EventResponse eventResponse)
        {
            return _eventResponseDAL.AddEventResponse(eventResponse);
        }

        /// <summary>
        /// Removes an EventResponse from the database
        /// </summary>
        /// <param name="eventReceiverId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public bool DeleteEventResponse(int eventReceiverId, int eventId)
        {
            return _eventResponseDAL.DeleteEventResponse(eventReceiverId, eventId);
        }

        /// <summary>
        /// Sets an EventResponse accept column to true for the given event response
        /// </summary>
        /// <param name="eventReceiverId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public int AcceptEventResponse(int eventReceiverId, int eventId)
        {
            return _eventResponseDAL.AcceptEventResponse(eventReceiverId, eventId);
        }

        /// <summary>
        /// Sets an EventResponse decline column to true for the given event response
        /// </summary>
        /// <param name="eventReceiverId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public int DeclineEventResponse(int eventReceiverId, int eventId)
        {
            return _eventResponseDAL.DeclineEventResponse(eventReceiverId, eventId);
        }

        /// <summary>
        /// Returns all EventResponses with matching receivingId
        /// </summary>
        /// <param name="receivingId"></param>
        /// <returns></returns>
        public List<EventResponse> GetEventResponses(int receivingId)
        {
            return _eventResponseDAL.GetEventsByReceivingId(receivingId);
        }
    }
}
