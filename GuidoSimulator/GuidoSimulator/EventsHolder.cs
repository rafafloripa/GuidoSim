﻿using System;
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
        /// Work events factory method
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateWorkEvents()
        {
            List<Event> workEvents = new List<Event>();

            workEvents.Add(new Event("Generous Tip", "One of your customers was very happy with your service and gave you a fat $100 tip!", 
                            Properties.Resources.happy_face, new EventEffect(100, 0, 0, 0, 0)));
            
            workEvents.Add(new Event("Clumsy!", "You spilled milk all over the staff room desk today. Your reputation has gone down.",
                            Properties.Resources.happy_face, new EventEffect(0, 0, 0, -3, 0)));
            
            workEvents.Add(new Event("Great skills", "You landed a big client at work today. You got a bonus, and your reputation has gone up!",
                            Properties.Resources.happy_face, new EventEffect(50, 0, 0, 10, 0)));

            workEvents.Add(new Event("Slow Down!", "You were fined on your way to work. Money - 48$",
                            Properties.Resources.sad_face, new EventEffect(-48, 0, 0, 0, 0)));

            
            return workEvents;
        }
        
        /// <summary>
        /// School event factory method
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateSchoolEvents() {
            List<Event> schoolEvents = new List<Event>();
            // Add choice events...***
            schoolEvents.Add(new Event("Mom...", "You accidentally called the teacher mom today. Your reputation and appearance has gone down.",
                Properties.Resources.sad_face, new EventEffect(0, -10, 0, -10, 0)));

            schoolEvents.Add(new Event("Ace!", "You aced the test today! Your family is happy with you and decides to give you a fat $100 tip!",
                Properties.Resources.happy_face, new EventEffect(100, 0, 10, 0, 20)));

            schoolEvents.Add(new Event("Fight!", "You fought the school bully today. The school isn't happy with you, but your reputation has increased!",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, 20, -10)));

            schoolEvents.Add(new Event("Whoops..", "Seems that you 'accidentally' put off the fire alarm today with your fireworks! Your classmates are impressed, your reputation has gone up.",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, 10, 0)));

            return schoolEvents;
        }

        /// <summary>
        /// Family event factory method
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateFamilyEvents()
        {
            List<Event> familyEvents = new List<Event>();
            // 
            familyEvents.Add(new Event("Babysitting", "Your parents gave you a fat $100 tip for babysitting today!",
                Properties.Resources.happy_face, new EventEffect(100, 0, 10, 0, 0)));
            familyEvents.Add(new Event("Fight", "You got in a fight with your parents over your curfew.",
                Properties.Resources.sad_face, new EventEffect(0, 0, -10, 0, 0)));
            familyEvents.Add(new Event("Family reunion", "You attended the family reunion today! The family is very happy with you.",
                Properties.Resources.happy_face, new EventEffect(0, 0, 10, 0, 0)));
            familyEvents.Add(new Event("Phone addict!", "Your parents got mad at you today for being on your phone all day. They are not happy!",
                Properties.Resources.sad_face, new EventEffect(0, 0, -5, 0, 0)));

            return familyEvents;
        }

        /// <summary>
        /// Gym event factory method
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
        /// Clubbing event factory method
        /// </summary>
        /// <returns></returns>
        public static List<Event> CreateClubbingEvents()
        {
            List<Event> clubbingEvents = new List<Event>();

            clubbingEvents.Add(new Event("Sick", "You had a few too many drinks at the club today and had to take a cab home. This isn't good for your reputation!",
                Properties.Resources.sad_face, new EventEffect(0, 0, 0, -10, 0)));

            clubbingEvents.Add(new Event("Life of the party!", "The DJ played all the right music today and you busted some great dance moves. Your appearance and reputation have increased!",
                Properties.Resources.happy_face, new EventEffect(0, 15, 0, 8, 0)));

            clubbingEvents.Add(new Event("Fight!", "You hit on the wrong girl so her boyfriend beat you up and broke your nose! This is not good for your reputation and appearance..",
                Properties.Resources.sad_face, new EventEffect(0, -10, 0, -10, 0)));

            clubbingEvents.Add(new Event("Bouncer problems", "The bouncer checked your ID and saw that you were too young to hit the club. Your reputation has decreased!",
                Properties.Resources.happy_face, new EventEffect(0, 0, 0, -20, 0)));

            return clubbingEvents;
        }
    }
}
