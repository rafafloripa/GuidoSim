using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    class Events
    {
        List<Event> workEvents = new List<Event>();
        List<Event> familyEvents = new List<Event>();
        List<Event> gymEvents = new List<Event>();
        List<Event> schoolEvents = new List<Event>();
        List<Event> clubbingEvents = new List<Event>();

        public Events()
        {
            AddWorkEvents();
            AddFamilyEvents();
            AddGymEvents();
            AddSchoolEvents();
            AddClubbingEvents();
        }

        public List<Event> WorkEvents
        {
            get
            {
                return workEvents;
            }

            set
            {
                workEvents = value;
            }
        }

        public List<Event> FamilyEvents
        {
            get
            {
                return familyEvents;
            }

            set
            {
                familyEvents = value;
            }
        }

        public List<Event> GymEvents
        {
            get
            {
                return gymEvents;
            }

            set
            {
                gymEvents = value;
            }
        }

        public List<Event> SchoolEvents
        {
            get
            {
                return schoolEvents;
            }

            set
            {
                schoolEvents = value;
            }
        }

        public List<Event> ClubbingEvents
        {
            get
            {
                return clubbingEvents;
            }

            set
            {
                clubbingEvents = value;
            }
        }

        private void AddClubbingEvents()
        {
            //
        }

        private void AddSchoolEvents()
        {
            //
        }

        private void AddGymEvents()
        {
            //
        }

        private void AddFamilyEvents()
        {
            //
        }

        private void AddWorkEvents()
        {
            WorkEvents.Add(new Event(
                "Generous Tip", 
                "One of your customers was very happy with your service and gave you a fat $100 tip!", 
                false,
                new int[5] {100, 0, 0, 0, 0}
                ));
        }
    }
}
