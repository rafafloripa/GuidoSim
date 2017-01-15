using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       ActivityResult.cs
    /// 
    /// Created:    by Marco Trifance, Jan 15th 2017
    /// Purpose:    Data-Type holding the outcome of a player's activity.
    /// </summary>
    public class ActivityResult
    {
        private bool completed;
        private string description;
        private Event evt;

        // Property: gives read and write access to completed
        public bool Completed {
            get { return completed; }
            set { this.completed = value; }
        }

        // Property: gives read and write access to description
        public string Description {
            get { return description; }
            set { this.description = value; }
        }

        // Property: gives read and write access to evt
        public Event ActivityEvent {
            get { return evt; }
            set { this.evt = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ActivityResult(bool completed, string description, Event evt)
        {
            this.completed = completed;
            this.description = description;
            this.evt = evt;
        }
    }
}
