using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class ItemsHolder
    {
        // Clothing IDs: 0-9

        // Creates Default watch
        public static Clothing CreateDefaultClothes()
        {
            // Change Icon!!!
            return new Clothing(0, "Default Clothes", "default clothes", 0, Properties.Resources.guido, new ItemEffect(0, 0, 0, 0));
        }

        public static Clothing[] createClothes()
        {
            Clothing[] clothingList = new Clothing[4];
            clothingList[0] = new Clothing(1, "Basic Guido", "With this basic outfit, you can hit any club and party with anyone in the line.", 500,
                Properties.Resources.guido, new ItemEffect(10, 0, 10, 0));
            clothingList[1] = new Clothing(2, "Sporty Guido", "This tracksuit allows you to run away fast when the bouncers rush to throw you out.", 1500,
               Properties.Resources.clothes_level_1, new ItemEffect(25, 0, 15, 0));
            clothingList[2] = new Clothing(3, "Party boy", "This outfit makes you look like Jonah Hill and John Travolta", 6000,
               Properties.Resources.clothes_level_2, new ItemEffect(35, 0, 20, 0));
            clothingList[3] = new Clothing(4, "Livin' La Vida Loca", "With this basic outfit, you can hit any club and party with anyone.", 12000,
               Properties.Resources.clothes_level_3, new ItemEffect(15, 0, 10, 0));
            return clothingList;
        }

        // Vehicle IDs: 10-19

        // Creates Default watch
        public static Vehicle CreateDefaultVehicle()
        {
            // Change Icon!!!
            return new Vehicle(10, "Default Vehicle", "default vehicle", 0, Properties.Resources.bike1, new ItemEffect(0, 0, 0, 0));
        }

        // Creates watches for stores
        public static Vehicle[] createVehicles()
        {
            Vehicle[] vehicleList = new Vehicle[4];
            vehicleList[0] = new Vehicle(11, "Grandma's Bike", "Impress all your mothers friends with this bike from 1950.", 500,
                Properties.Resources.bike1, new ItemEffect(0, 15, 0, 10));
            vehicleList[1] = new Vehicle(12, "Pucati Special", "Your mom won't like it, but the girls will.", 5000,
               Properties.Resources.vehicle_level_1, new ItemEffect(20, -5, 30, 0));
            vehicleList[2] = new Vehicle(13, "Gaston Fartin V50", "Flows through the traffic like the wind. Everyone will love it.", 15000,
               Properties.Resources.vehicle_level_2, new ItemEffect(10, 15, 30, 10));
            vehicleList[3] = new Vehicle(14, "P6", "So fly like a P6.", 50000,
               Properties.Resources.vehicle_level_3, new ItemEffect(30, 30, 30, 30));
            return vehicleList;
        }

        // Watch IDs: 20-29

        // Creates Default watch
        public static Watch CreateDefaultWatch()
        {
            // Change Icon!!!
            return new Watch(20, "Default Watch", "default watch", 0, Properties.Resources.watch1, new ItemEffect(0, 0, 0, 0));
        }

        // Creates watches for stores
        public static Watch[] createWatches()
        {
            Watch[] watchList = new Watch[4];
            watchList[0] = new Watch(21, "Watch 0", "Watch 0 description.", 100,
               Properties.Resources.watch1, new ItemEffect(0, 0, 0, 0));
            watchList[1] = new Watch(22, "Watch 1", "Watch 1 description.", 500,
               Properties.Resources.watch_level_1, new ItemEffect(0, 0, 0, 0));
            watchList[2] = new Watch(23, "Watch 2", "Watch 2 description.", 5000,
               Properties.Resources.watch_level_2, new ItemEffect(0, 0, 0, 0));
            watchList[3] = new Watch(24, "Watch 3", "Watch 3 description.", 20000,
               Properties.Resources.watch_level_3, new ItemEffect(0, 0, 0, 0));
            return watchList;
        }

        // *** Phones IDs: 30-39

        // Creates Default phone
        public static Phone CreateDefaultPhone()
        {
            // Change Icon!!!
            return new Phone(30, "Default Phone", "default phone", 0, Properties.Resources.phone1, new ItemEffect(0, 0, 0, 0));
        }

        // Creates Stores phones
        public static Phone[] createPhones()
        {
            Phone[] phoneList = new Phone[4];
            phoneList[0] = new Phone(31, "Phone 0", "Phone 0 description", 200,
               Properties.Resources.phone1, new ItemEffect(0, 0, 0, 0));
            phoneList[1] = new Phone(32, "Phone 1", "Phone 1 description", 1000,
               Properties.Resources.phone_level_1, new ItemEffect(0, 0, 0, 0));
            phoneList[2] = new Phone(33, "Phone 2", "Phone 2 description", 10000,
               Properties.Resources.phone_level_2, new ItemEffect(0, 0, 0, 0));
            phoneList[3] = new Phone(34, "Phone 3", "Phone 3 description", 30000,
               Properties.Resources.phone_level_3, new ItemEffect(0, 0, 0, 0));
            return phoneList;
        }
    }
}
