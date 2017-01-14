using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class Event
    {
        string title;
        string description;
        bool hasPlayerChoice;

        EventEffect effect;     //** NEW

        //** NEW
        public Event(string title, string description, bool hasPlayerChoice, EventEffect effect)
        {
            this.Title = title;
            this.Description = description;
            this.HasPlayerChoice = hasPlayerChoice;
            this.effect = effect;
        }

        // *** TEMP: remove this constructor!! used in EventManager, RandomWorkEvent()...***
        public Event() { }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool HasPlayerChoice
        {
            get
            {
                return hasPlayerChoice;
            }

            set
            {
                hasPlayerChoice = value;
            }
        }

        //** NEW
        public EventEffect Effect
        {
            get
            {
                return effect;
            }

            set
            {
                effect = value;
            }
        }
    }
}
