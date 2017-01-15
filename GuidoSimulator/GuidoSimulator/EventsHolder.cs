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

            workEvents.Add(new Event("Generous Tip", "One of your customers was very happy with your service and gave you a fat $100 tip!", 
                            Properties.Resources.happy_face, new EventEffect(100, 0, 0, 0, 0)));
            
            workEvents.Add(new Event("Work Event01", "Work Event01 description",
                            Properties.Resources.happy_face, new EventEffect(0, 0, 0, -3, 0)));
            
            workEvents.Add(new Event("Work Event02", "Work Event02 description",
                            Properties.Resources.sad_face, new EventEffect(0, 0, 0, -3, 0)));

            workEvents.Add(new Event("Slow Down!", "You were fined on your way to work. Money - 48$",
                            Properties.Resources.sad_face, new EventEffect(-48, 0, 0, 0, 0)));
            
            return workEvents;
        }
        
        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateSchoolEvents() {
            List<Event> schoolEvents = new List<Event>();

            // Add choice events...***
            schoolEvents.Add(new Event("School Event 1", "The 1st TEST school event",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, 0, 0)));

            schoolEvents.Add(new Event("School Event 2", "The 2nd TEST school event",
                Properties.Resources.sad_face, new EventEffect(0, 0, 0, 0, 0)));

            return schoolEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateFamilyEvents()
        {
            List<Event> familyEvents = new List<Event>();

            familyEvents.Add(new Event("Family Event 1", "The 1st TEST family event",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, 0, 0)));

            familyEvents.Add(new Event("Family Event 2", "The 2nd TEST family event",
                Properties.Resources.sad_face, new EventEffect(0, 0, 0, 0, 0)));

            return familyEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateGymEvents()
        {
            List<Event> gymEvents = new List<Event>();

            gymEvents.Add(new Event("Challenge accepted!", "Francis has been acting a bit of a loud-mouth lately, boasting he has the gym push-up record. You decide to set him straight. You make it look like it was his first day there.",
                Properties.Resources.fitness_master, new EventEffect(0, 0, 0, 50, 0)));

            gymEvents.Add(new Event("We all have those days...", "Better lay off on the extra candies and cakes from your grandma!",
                Properties.Resources.fitness_nerd, new EventEffect(0, 0, 0, -10, 0)));

            gymEvents.Add(new Event("Damn Joakim!", "Better workout solo for a while, before you compete with the fitness-guru Joakim",
                Properties.Resources.fitness_master, new EventEffect(0, 0, 0, -15, 0)));

            gymEvents.Add(new Event("Think before you act!", "You challenge Screech in an arm wrestling competition. You must have overestimated your abilities... you lose the competition, yor reputation and your Guido mojo!",
                Properties.Resources.fitness_nerd, new EventEffect(0, 0, 0, -20, 0)));

            return gymEvents;
        }

        /// <summary>
        /// TO-DO...
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateClubbingEvents()
        {
            List<Event> clubbingEvents = new List<Event>();

            clubbingEvents.Add(new Event("Clubbing Event 1", "The 1st TEST Clubbing event",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, 0, 0)));

            clubbingEvents.Add(new Event("Clubbing Event 2", "The 2nd TEST Clubbing event",
                Properties.Resources.sad_face, new EventEffect(0, 0, 0, 0, 0)));

            return clubbingEvents;
        }
    }
}
