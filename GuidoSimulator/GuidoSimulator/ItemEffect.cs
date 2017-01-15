using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// 
    /// Name :      ItemEffect.cs
    /// Created:    Mohammad Ahraz Asif, modified by Marco Trifance
    /// Purpose:    The effects the item will have on the Player.
    /// </summary>
    public class ItemEffect
    {
        // PROPERTIES: read-only
        private int appearance;
        private int family;
        private int reputation;
        private int school;

        public int Appearance { get { return appearance; } }
        public int Family { get { return family; } }
        public int Reputation { get { return reputation; } }
        public int School { get { return school; } }

        /// <summary>
        /// Constructor. Sets Item properties to parameter values.
        /// </summary>
        /// <param name="appearance">The impact on the 'appearance' stat of the player.</param>
        /// <param name="family">The impact on the 'family' stat of the player.</param>
        /// <param name="reputation">The impact on the 'reputation' stat of the player.</param>
        /// <param name="school">The impact on the 'school' stat of the player.</param>
        public ItemEffect(int appearance, int family, int reputation, int school)
        {
            this.appearance = appearance;
            this.family = family;
            this.reputation = reputation;
            this.school = school;
        }
    }
}
