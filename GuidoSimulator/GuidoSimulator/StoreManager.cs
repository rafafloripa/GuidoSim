using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       StoreManager.cs 
    /// 
    /// Created:    Mohammad Ahraz Asif & Marco Trifance
    /// Purpose:    Provides the store functionality for the UI layer (BaseStoreForm) to utilise.
    /// </summary>
    public class StoreManager
    {
        protected Item[] items;

        public StoreManager (Item[] itemList)
        {
            this.items = itemList;
        }

        /// <summary>
        /// Returns the item placet it 'items' array at 'index' position.
        /// </summary>
        /// <param name="index">The int index position of the item in the items array.</param>
        /// <returns></returns>
        public Item getItem(int index)
        {
            return items[index];
        }

        /// <summary>
        /// Returns true if purchase of item at 'index' position in 'items' array is succesful.
        /// Returns false if Player can't afford item.
        /// </summary>
        /// <param name="player">The Player instance who is attempting the purchase.</param>
        /// <param name="index">The int index of the item in the 'items' array.</param>
        /// <returns></returns>
        public bool attemptPurchase(Player player, int index)
        {
            Item item = items[index];

            // Check item type and set in Player
            if (item.GetType() == typeof(Vehicle))
            {
                if (player.BuyVehicle((Vehicle)item))
                    return true;
                else
                    return false;
            }
            else if (item.GetType() == typeof(Watch))           
            {
                if (player.BuyWatch((Watch)item))
                    return true;
                else
                    return false;
            }
            else if (item.GetType() == typeof(Phone))           
            {
                if (player.BuyPhone((Phone)item))
                    return true;
                else
                    return false;
            }
            else if (item.GetType() == typeof(Clothing))        
            {
                if (player.BuyClothing((Clothing)item))
                    return true;
                else
                    return false;
            }
            else   // unknown item-type
                return false;               
        }

        // TO-DO...
        public bool playerHasItem(Player player, int index)
        {
            Item item = items[index];

            if (player.HasItem(item))
                return true;
            else
                return false;
        }
    }
}
