using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    public class EventController
    {
        private AddEventDAL _addEventDAL;

        /// <summary>
        /// Constructor to initialize the DAL access
        /// </summary>
        public EventController()
        {
            _addEventDAL = new AddEventDAL();
        }

        public bool SaveEvent(Event @event)
        {
            return _addEventDAL.SaveEvent(@event);
        }
    }
}
