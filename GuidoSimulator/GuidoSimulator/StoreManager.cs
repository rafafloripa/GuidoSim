using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class StoreManager
    {
        protected Item[] itemList;

        public StoreManager (Item[] itemList)
        {
            this.itemList = itemList;
        }

        public Item getItem(int index)
        {
            return itemList[index];
        }

        public bool attemptPurchase(Player player, int index)
        {
            if (player.Money < itemList[index].Price) return false;
            player.Money = player.Money - itemList[index].Price;
            // Check if curr item if player already owns item
            return true;
        }
    }
}
