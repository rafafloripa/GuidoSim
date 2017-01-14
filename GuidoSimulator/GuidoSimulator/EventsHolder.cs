using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /* Class:       EventsHolder.cs
     * 
     * Created:     by Marco Trifance, Jan 13th 2017
     * Purpose:     this class provides publicly accessible methods to generate the list of events 
     *              for each of the player activities.
     */
    public class EventsHolder
    {
        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateWorkEvents()
        {
            List<Event> workEvents = new List<Event>();

            // TO-DO... add events
            workEvents.Add(new Event("Generous Tip", "One of your customers was very happy with your service and gave you a fat $100 tip!", false, 
                            new EventEffect(100, 0, 0, 0, 0)));

            workEvents.Add(new Event("Making new friends", "One of your colleagues can't stop telling the funniest jokes about... well, mmm... about you...", false,
                            new EventEffect(0, 0, 0, -3, 0)));

            workEvents.Add(new Event("If you can't beat them...", "Your boss must have had a wrong day. Reputation loss -3", false,
                            new EventEffect(0, 0, 0, -3, 0)));

            workEvents.Add(new Event("Slow Down!", "You were fined on your way to work. Money - 48$", false,
                            new EventEffect(-48, 0, 0, 0, 0)));

            return workEvents;
        }
        
        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateSchoolEvents() {
            List<Event> schoolEvents = new List<Event>();

            schoolEvents.Add(new Event("School Event 1", "The 1st TEST school event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            schoolEvents.Add(new Event("School Event 2", "The 2nd TEST school event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            return schoolEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateFamilyEvents()
        {
            List<Event> familyEvents = new List<Event>();

            familyEvents.Add(new Event("Family Event 1", "The 1st TEST family event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            familyEvents.Add(new Event("Family Event 2", "The 2nd TEST family event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            return familyEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateGymEvents()
        {
            List<Event> gymEvents = new List<Event>();

            gymEvents.Add(new Event("Gym Event 1", "The 1st TEST Gym event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            gymEvents.Add(new Event("Gym Event 2", "The 2nd TEST Gym event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            return gymEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateClubbingEvents()
        {
            List<Event> clubbingEvents = new List<Event>();

            clubbingEvents.Add(new Event("Clubbing Event 1", "The 1st TEST Clubbing event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            clubbingEvents.Add(new Event("Clubbing Event 2", "The 2nd TEST Clubbing event", false,
                new EventEffect(0, 0, 0, 0, 0)));

            return clubbingEvents;
        }
    }
}
