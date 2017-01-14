using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    class StoreManager
    {
        protected Item[] itemList;
        private Item currItem;

        public StoreManager (Item[] itemList)
        {
            this.itemList = itemList;
        }

        public bool attemptPurchase(Player player, Item item)
        {
            if (player.Money < item.Price) return false;
            player.Money = player.Money - item.Price;
            // Change the current item
            // Check if curr item if player already owns item
            return true;
        }
    }
}
