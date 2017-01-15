using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GuidoSimulator
{
    /// <summary>
    /// 
    /// Name :      Item.cs
    /// Created:    Mohammad Ahraz Asif, modified by Marco Trifance
    /// Purpose:    Base class for all Items. Extended by child classes such as Clothing, Watch,
    ///             and Vehicle.
    /// </summary>
    public class Item
    {
        protected int id;
        protected String name;
        protected String description;
        protected decimal price;
        protected Image image;
        protected ItemEffect itemEffect;

        // PROPERTIES: read-only
        public int Id { get { return this.id; } }
        public String Name { get {return this.name; } }
        public String Description { get { return this.description; } }
        public decimal Price { get { return this.price; } }
        public Image ItemImage { get { return this.image; } }
        public ItemEffect ItemEffect { get { return this.itemEffect; } }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Item(){}

        /// <summary>
        /// Constructor. Sets Item properties to parameter values.
        /// </summary>
        /// <param name="name">The name of the Item object.</param>
        /// <param name="description">The description of the Item object.</param>
        /// <param name="price">The price of the Item object.</param>
        /// <param name="image">The image of the Item object.</param>
        /// <param name="itemEffect">The effects the item will have on the Player.</param>
        public Item(int id, String name, String description, decimal price, Image image, ItemEffect itemEffect)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.id = id;
            this.itemEffect = itemEffect;
        }
    }
}
