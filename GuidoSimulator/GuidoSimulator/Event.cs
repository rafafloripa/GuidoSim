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
        int[] effect;

        public Event(string title, string description, bool hasPlayerChoice, int[] effect)
        {
            this.Title = title;
            this.Description = description;
            this.HasPlayerChoice = hasPlayerChoice;
            this.Effect = effect;
        }

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

        public int[] Effect
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
