using TeaLeaves.DALs;

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
    }
}
