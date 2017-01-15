using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoSimulator
{
    /// <summary>
    /// Class:   EventManager.cs
    /// 
    /// Created:    by Marco Trifance, Jan 13th 2017
    /// Purpose:    Contains the logic for generating random events for each 
    ///             Player activity.
    /// </summary>
    class EventManager
    {
        private const double EVENT_PROBABILITY = 0.33;

        Random rnd = new Random();      

        private List<Event> workEvents = new List <Event>();
        private List<Event> schoolEvents = new List<Event>();
        private List<Event> gymEvents = new List<Event>();
        private List<Event> familyEvents = new List<Event>();
        private List<Event> clubbingEvents = new List<Event>();

        /// <summary>
        /// Constructor. Initializes the lists from the values stored
        /// in class EventsHolder.
        /// </summary>
        public EventManager()
        {
            this.workEvents = EventsHolder.CreateWorkEvents();
            this.schoolEvents = EventsHolder.CreateSchoolEvents();
            this.gymEvents = EventsHolder.CreateGymEvents();
            this.familyEvents = EventsHolder.CreateFamilyEvents();
            this.clubbingEvents = EventsHolder.CreateClubbingEvents();
        }

        /// <summary>
        /// Selects random work-event and removes it from the list.
        /// Refills list when empty.
        /// </summary>
        /// <returns>The random work-event if generated, null otherwise</returns>
        public Event RandomWorkEvent()
        {
            // Calculate probability of generating an event
            if (!EventIsTriggered())
                return null;

            // Recreate list if empty
            if (workEvents.Count == 0)
                workEvents = EventsHolder.CreateWorkEvents();

            // Select random event and remove it from list 
            int index = rnd.Next(0, workEvents.Count);
            Event randomEvent = workEvents[index];
            workEvents.RemoveAt(index);
            return randomEvent;
        }

        /// <summary>
        /// Selects random gym-event and removes it from the list.
        /// Refills list when empty.
        /// </summary>
        /// <returns>The random gym-event if generated, null otherwise</returns>
        public Event RandomGymEvent()
        {
            if (!EventIsTriggered())
                return null;

            // Refill list if empty
            if (gymEvents.Count == 0)
                gymEvents = EventsHolder.CreateGymEvents();

            // Select random event and remove from list
            int index = rnd.Next(0, gymEvents.Count);
            Event randomEvent = gymEvents[index];
            gymEvents.RemoveAt(index);

            return randomEvent;
        }

        /// <summary>
        /// Selects random school-event and removes it from the list.
        /// Refills list when empty.
        /// </summary>
        /// <returns>The random school-event</returns>
        public Event RandomSchoolEvent()
        {
            if (!EventIsTriggered())
                return null;

            // Refill list if empty
            if (schoolEvents.Count == 0)
                schoolEvents = EventsHolder.CreateSchoolEvents();

            // Select random event and remove from list
            int index = rnd.Next(0, schoolEvents.Count);
            Event randomEvent = schoolEvents[index];
            schoolEvents.RemoveAt(index);

            return randomEvent;
        }

        /// <summary>
        /// Selects random family-event and removes it from the list.
        /// Refills list when empty.
        /// </summary>
        /// <returns>The random family-event</returns>
        public Event RandomFamilyEvent()
        {
            if (!EventIsTriggered())
                return null;

            // Refill list if empty
            if (familyEvents.Count == 0)
                familyEvents = EventsHolder.CreateFamilyEvents();

            // Select random event and remove from list
            int index = rnd.Next(0, familyEvents.Count);
            Event randomEvent = familyEvents[index];
            familyEvents.RemoveAt(index);

            return randomEvent;
        }

        /// <summary>
        /// Selects random clubbing-event and removes it from the list.
        /// Refills list when empty.
        /// </summary>
        /// <returns>The random clubbing-event</returns>
        public Event RandomClubbingEvent()
        {
            if (!EventIsTriggered())
                return null;

            // Refill list if empty
            if (clubbingEvents.Count == 0)
                clubbingEvents = EventsHolder.CreateClubbingEvents();

            // Select random event and remove from list
            int index = rnd.Next(0, clubbingEvents.Count);
            Event randomEvent = clubbingEvents[index];
            clubbingEvents.RemoveAt(index);

            return randomEvent;
        }

        /// <summary>
        /// Returns true if randomly generated double between 0.0 and 1.0 
        /// is below 'EVENT_PROBABILITY'.
        /// </summary>
        /// <returns></returns>
        private bool EventIsTriggered()
        {
            double randomDouble = rnd.NextDouble();

            if (randomDouble < EVENT_PROBABILITY)
                return true;
            else
                return false;
        }
    }
}
