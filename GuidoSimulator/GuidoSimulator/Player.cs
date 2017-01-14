using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    public class Player
    {
        private string name;
        private string city;

        private decimal money;
        private int appearance;
        private int family;
        private int reputation;
        private int school;

        private System.Drawing.Image clothesImage;
        private System.Drawing.Image phoneImage;
        private System.Drawing.Image vehicleImage;
        private System.Drawing.Image watchImage;

        private const int maxAttributeValue = 100;

        private Vehicle vehicle;
        private Watch watch;
        private Phone phone;
        private Clothing clothing;

        // Property: read-write
        public Vehicle Vehicle 
        {
            get { return this.vehicle; }
            set { this.vehicle = value; }
        }

        // Property: read-write
        public Watch Watch
        {
            get { return this.watch; }
            set { this.watch = value; }
        }

        // Property: read-write
        public Phone Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        // Property: read-write
        public Clothing Clothing
        {
            get { return this.clothing; }
            set { this.clothing = value; }
        }

        // Constructor
        public Player()
        {

            this.Name = "Guido Guidi";
            this.City = "Gothenburg";
            this.Money = 0;
            this.Appearance = 0;
            this.Family = 0;
            this.Reputation = 0;
            this.School = 0;
            this.clothesImage = Properties.Resources.guido;
            this.phoneImage = Properties.Resources.phone1;
            this.vehicleImage = Properties.Resources.bike1;
            this.watchImage = Properties.Resources.watch1;
        }

        public System.Drawing.Image ClothesImage
        {
            get { return clothesImage; }
            set { clothesImage = value; }
        }

        public System.Drawing.Image PhoneImage
        {
            get { return phoneImage; }
            set { phoneImage = value; }
        }

        public System.Drawing.Image VehicleImage
        {
            get { return vehicleImage; }
            set { vehicleImage = value; }
        }

        public System.Drawing.Image WatchImage
        {
            get { return watchImage; }
            set { watchImage = value; }
        }

        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }

        public int Appearance
        {
            get { return appearance; }
            set { appearance = setValue(value); }
        }

        public int Family
        {
            get { return family; }
            set { family = setValue(value); }
        }

        public int Reputation
        {
            get { return reputation; }
            set { reputation = setValue(value); }
        }

        public int School
        {
            get { return school; }
            set { school = setValue(value); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // Returns true if player has 
        public bool HasItem(Item item)
        {
            int itemId = item.Id;

            if (vehicle != null && vehicle.Id == itemId)
                return true;
            else if (clothing != null && clothing.Id == itemId)
                return true;
            else if (watch != null && watch.Id == itemId)
                return true;
            else if (phone != null && phone.Id == itemId)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Returns true, replaces watch with given parameter, updates money and other Player stats.
        /// Returns false if watch is too expensive.
        /// </summary>
        /// <param name="watch">The watch the Player is attempting to buy.</param>
        /// <returns>True if purchase is successful, false otherwise.</returns>
        public bool BuyWatch(Watch watch)
        {
            if (money < watch.Price)
                return false;

            money -= watch.Price;
            this.watch = watch;
            HandleItemUpgrades(watch.ItemEffect);
            return true;
        }

        /// <summary>
        /// Returns true, replaces clothing with given parameter, updates money and other Player stats.
        /// Returns false if clothing is too expensive.
        /// </summary>
        /// <param name="clothing">The phone  the Player is attempting to buy.</param>
        /// <returns>True if purchase is successful, false otherwise.</returns>
        public bool BuyClothing(Clothing clothing)
        {
            if (money < clothing.Price)
                return false;

            money -= clothing.Price;
            this.clothing = clothing;
            HandleItemUpgrades(clothing.ItemEffect);
            return true;
        }

        /// <summary>
        /// Returns true, replaces phone with given parameter, updates money and other Player stats.
        /// Returns false if phone  is too expensive.
        /// </summary>
        /// <param name="phone">The phone  the Player is attempting to buy.</param>
        /// <returns>True if purchase is successful, false otherwise.</returns>
        public bool BuyPhone(Phone phone)
        {
            if (money < phone.Price)
                return false;

            money -= phone.Price;
            this.phone = phone;
            HandleItemUpgrades(phone.ItemEffect);
            return true;
        }

        /// <summary>
        /// Returns true, replaces vehicle with given parameter, updates money and other Player stats.
        /// Returns false if vehicle is too expensive.
        /// </summary>
        /// <param name="vehicle">The vehicle the Player is attempting to buy.</param>
        /// <returns>True if purchase is successful, false otherwise.</returns>
        public bool BuyVehicle(Vehicle vehicle)
        {
            if (money < vehicle.Price)
                return false;

            money -= vehicle.Price;
            this.vehicle = vehicle;
            HandleItemUpgrades(vehicle.ItemEffect);
            return true;
        }

        // Increases/decreases Player stats according to ItemEffect
        private void HandleItemUpgrades(ItemEffect effect)
        {
            this.appearance += effect.Appearance;
            this.school += effect.School;
            this.reputation += effect.Reputation;
            this.family += effect.Family;
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
