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
