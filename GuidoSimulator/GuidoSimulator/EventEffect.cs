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
            set { money = value;}
        }

        // Property: gives read and write access to 'appearance'
        public int Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }

        // Property: gives read and write access to 'family'
        public int Family
        {
            get { return family; }
            set { family = value; }
        }

        // Property: gives read and write access to 'reputation'
        public int Reputation
        {
            get { return reputation; }
            set { reputation = value; }
        }

        // Property: gives read and write access to 'school'
        public int School
        {
            get { return school; }
            set { school = value; }
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
            string effectString = string.Empty;

            if (money > 0)
                effectString += "Money  +" + money.ToString();
            else if(money < 0)
                effectString += "Money " + money.ToString();

            if (appearance > 0)
                effectString += "   Appearance  +" + appearance.ToString();
            else if (appearance < 0)
                effectString += "   Appearance" + appearance.ToString();

            if (family > 0)
                effectString += "   Family  +" + family.ToString();
            else if (family< 0)
                effectString += "   Family " + family.ToString();

            if (reputation > 0)
                effectString += "   Reputation  +" + reputation.ToString();
            else if (reputation < 0)
                effectString += "   Reputation " + reputation.ToString();

            if (school > 0)
                effectString += "   School +" + school.ToString();
            else if (school < 0)
                effectString += "   School " + school.ToString();

            return effectString;
        }
        
    }
}
