using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    class Player
    {
        private string name;
        private string city;

        private decimal money;
        private int appearance;
        private int family;
        private int reputation;
        private int school;

        private const int maxAttributeValue = 100;

        public Player()
        {
            this.Name = "Guido Guidi";
            this.City = "Gothenburg";
            this.Money = 0;
            this.Appearance = 0;
            this.Family = 0;
            this.Reputation = 0;
            this.School = 0;
        }

        public decimal Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

        public int Appearance
        {
            get
            {
                return appearance;
            }

            set
            {
                appearance = setValue(value);
            }
        }

        public int Family
        {
            get
            {
                return family;
            }

            set
            {
                family = setValue(value);
            }
        }

        public int Reputation
        {
            get
            {
                return reputation;
            }

            set
            {
                reputation = setValue(value);
            }
        }

        public int School
        {
            get
            {
                return school;
            }

            set
            {
                school = setValue(value);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        private int setValue(int value)
        {
            if (value < 0)
            {
                return 0;
            } else if (value > maxAttributeValue)
            {
                return maxAttributeValue;
            }
            else
            {
                return value;
            }
        }
    }
}
