using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       Event.cs 
    /// 
    /// Created:    by Marco Trifance, Jan 15th 2017
    /// Purpose:    base class for Event objects. Events contain a data-type 
    ///             of type EventEffectaffect to affect the player stats.
    /// 
    /// </summary>
    public class Event
    {

        protected string title;
        protected string description;
        protected Image image;
        private EventEffect effect;

        // Properties: read-only
        public string Title { get { return title; } }
        public string Description { get { return description; } }
        public Image EventImage { get { return image; } }
        public EventEffect Effect { get { return effect; } }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Event() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="title">The title of the event.</param>
        /// <param name="description">The description of the event.</param>
        /// <param name="hasPlayerChoice"></param>
        /// <param name="effect"></param>
        public Event(string title, string description, Image image, EventEffect effect)
        {
            this.title = title;
            this.description = description;
            this.image = image;
            this.effect = effect;
        }
    }
}
