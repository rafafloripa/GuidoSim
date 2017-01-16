using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       Clothing.cs 
    /// 
    /// Created:    by Mohammad Ahraz Asif
    /// Purpose:    Wrapper class around the Item class representing a phone item
    /// </summary>
    /// 
    public class Phone : Item
    {
        public Phone(int id, String name, String description, decimal price, Image image, ItemEffect itemEffect) : base(id, name, description, price, image, itemEffect)
        {

        }
    }
}
