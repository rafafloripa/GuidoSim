using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class ItemsHolder
    {
        // IDs: 0-9
        public static Clothing[] createClothes()
        {
            Clothing[] clothingList = new Clothing[4];
            clothingList[0] = new Clothing(0, "Basic Guido", "With this basic outfit, you can hit any club and party with anyone in the line.", 500,
                Properties.Resources.guido, new ItemEffect(10, 0, 10, 0));
            clothingList[1] = new Clothing(1, "Sporty Guido", "This tracksuit allows you to run away fast when the bouncers rush to throw you out.", 1500,
               Properties.Resources.clothes_level_1, new ItemEffect(25, 0, 15, 0));
            clothingList[2] = new Clothing(2, "Party boy", "This outfit makes you look like Jonah Hill and John Travolta", 6000,
               Properties.Resources.clothes_level_2, new ItemEffect(35, 0, 20, 0));
            clothingList[3] = new Clothing(3, "Livin' La Vida Loca", "With this basic outfit, you can hit any club and party with anyone.", 12000,
               Properties.Resources.clothes_level_3, new ItemEffect(15, 0, 10, 0));
            return clothingList;
        }

        // IDs: 10-19
        public static Vehicle[] createVehicles()
        {
            Vehicle[] vehicleList = new Vehicle[4];
            vehicleList[0] = new Vehicle(10, "Grandma's Bike", "Impress all your mothers friends with this bike from 1950.", 500,
                Properties.Resources.bike1, new ItemEffect(0, 15, 0, 10));
            vehicleList[1] = new Vehicle(11, "Pucati Special", "Your mom won't like it, but the girls will.", 5000,
               Properties.Resources.vehicle_level_1, new ItemEffect(20, -5, 30, 0));
            vehicleList[2] = new Vehicle(12, "Gaston Fartin V50", "Flows through the traffic like the wind. Everyone will love it.", 15000,
               Properties.Resources.vehicle_level_2, new ItemEffect(10, 15, 30, 10));
            vehicleList[3] = new Vehicle(13, "P6", "So fly like a P6.", 50000,
               Properties.Resources.vehicle_level_3, new ItemEffect(30, 30, 30, 30));
            return vehicleList;
        }

        // IDs: 20-29
        public static Watch[] createWatches()
        {
            Watch[] watchList = new Watch[4];
            watchList[0] = new Watch(20, "Watch 0", "Watch 0 description.", 100,
               Properties.Resources.watch1, new ItemEffect(0, 0, 0, 0));
            watchList[1] = new Watch(21, "Watch 1", "Watch 1 description.", 500,
               Properties.Resources.watch_level_1, new ItemEffect(0, 0, 0, 0));
            watchList[2] = new Watch(22, "Watch 2", "Watch 2 description.", 5000,
               Properties.Resources.watch_level_2, new ItemEffect(0, 0, 0, 0));
            watchList[3] = new Watch(23, "Watch 3", "Watch 3 description.", 20000,
               Properties.Resources.watch_level_3, new ItemEffect(0, 0, 0, 0));
            return watchList;
        }

        // IDs: 30-39
        public static Phone[] createPhones()
        {
            Phone[] phoneList = new Phone[4];
            phoneList[0] = new Phone(30, "Phone 0", "Phone 0 description", 200,
               Properties.Resources.phone1, new ItemEffect(0, 0, 0, 0));
            phoneList[1] = new Phone(31, "Phone 1", "Phone 1 description", 1000,
               Properties.Resources.phone_level_1, new ItemEffect(0, 0, 0, 0));
            phoneList[2] = new Phone(32, "Phone 2", "Phone 2 description", 10000,
               Properties.Resources.phone_level_2, new ItemEffect(0, 0, 0, 0));
            phoneList[3] = new Phone(33, "Phone 3", "Phone 3 description", 30000,
               Properties.Resources.phone_level_3, new ItemEffect(0, 0, 0, 0));
            return phoneList;
        }
    }
}
