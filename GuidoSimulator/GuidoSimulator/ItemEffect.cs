using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class ItemEffect
    {
        private int appearance;
        private int family;
        private int reputation;
        private int school;

        public int Appearance { get { return appearance; } }
        public int Family { get { return family; } }
        public int Reputation { get { return reputation; } }
        public int School { get { return school; } }


        public ItemEffect(int appearance, int family, int reputation, int school)
        {
            this.appearance = appearance;
            this.family = family;
            this.reputation = reputation;
            this.school = school;
        }
    }
}
