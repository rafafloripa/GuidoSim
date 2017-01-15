using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /* Class:       EventEffect.cs
     * 
     * Created:     by Marco Trifance, Jan 13th 2017
     * Purpose:     data-type that holds the points to be added or subtracted
     *              from the Player stats as the effect of an Event.
     */
    public class EventEffect
    {
        private decimal money;
        private int appearance;
        private int family;
        private int reputation;
        private int school;

        // Property: gives read and write access to 'money'
        public decimal Money
        {
            get{ return money; }
            set { this.money = value;}
        }

        // Property: gives read and write access to 'appearance'
        public int Appearance
        {
            get { return appearance; }
            set { this.appearance = value; }
        }

        // Property: gives read and write access to 'family'
        public int Family
        {
            get { return family; }
            set { this.family = value; }
        }

        // Property: gives read and write access to 'reputation'
        public int Reputation
        {
            get { return reputation; }
            set { this.reputation = value; }
        }

        // Property: gives read and write access to 'school'
        public int School
        {
            get { return school; }
            set { this.school = value; }
        }

        // Constructor
        public EventEffect(decimal money, int appearance, int family, int reputation, int school) {
            this.money = money;
            this.appearance = appearance;
            this.family = family;
            this.reputation = reputation;
            this.school = school;
        }

        // To-do
        public override string ToString()
        {
            // To-do...
            return base.ToString();
        }
    }
}
