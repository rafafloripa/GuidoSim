using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       ChoiceEvent.cs
    /// 
    /// Created:    by Marco Trifance, Jan 15th 2017
    /// Purpose:    this class extends the base class Event. ChoiceEvent Objects give the player
    ///             two alternatives on how to react to an Event.
    ///             
    /// </summary>
    public class ChoiceEvent : Event
    {
        private string option_a;
        private string option_b;
        private EventEffect effect_a;
        private EventEffect effect_b;
        // string outcome a
        // string outcome b  (*** maybe encapsulate all this in Option class?)

        // Properties: read-only
        public string Option_A { get { return this.option_a; } }
        public string Option_B { get { return this.option_b; } }
        public EventEffect Effect_A { get { return this.effect_a; } }
        public EventEffect Effect_B { get { return this.effect_b; } }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public ChoiceEvent() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="title">The title of the ChoiceEvent object.</param>
        /// <param name="description">The string description of the ChoiceEvent object.</param>
        /// <param name="option_a">The string description of the first option.</param>
        /// <param name="effect_a">The EventEffect of the first option.</param>
        /// <param name="option_b">The string description of the second option.</param>
        /// <param name="effect_b">The EventEffect of the second option</param>
        public ChoiceEvent(string title, string description, string option_a, EventEffect effect_a, string option_b, EventEffect effect_b)
        {
            this.title = title;
            this.description = description;
            this.option_a = option_a;
            this.effect_a = effect_a;
            this.option_b = option_b;
            this.effect_b = effect_b;
        }


    }
}
