using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoSimulator
{
    class EventManager
    {
        Events events;
        Random rnd = new Random();

        public EventManager()
        {
            this.events = new Events();
        }

        public int[] WorkEvent()
        {
            int eventIndex = rnd.Next(0, events.WorkEvents.Count - 1);
            Event randomEvent = events.WorkEvents[eventIndex];
            if (randomEvent.HasPlayerChoice == false)
            {
                MessageBox.Show(randomEvent.Description, randomEvent.Title);
                return randomEvent.Effect;
            }
            else
            {
                //TODO
                return new int[5] { 0, 0, 0, 0, 0 };
            }
            
        }
    }
}
