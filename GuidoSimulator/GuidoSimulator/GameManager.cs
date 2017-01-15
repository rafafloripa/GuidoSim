using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoSimulator
{
    public class GameManager
    {
        private DateTime startDate = new DateTime(2017, 1, 1);

        private DateTime currentDate;
        private int day;
        private DateTime date;
        private Player player;

        private EventManager eventManager;
        private StoreManager vehicleStore;
        private StoreManager watchStore;
        private StoreManager clothingStore;
        private StoreManager phoneStore;

        // Properties: read-only
        public StoreManager VehicleStore { get { return vehicleStore; } }
        public StoreManager WatchStore { get { return watchStore; } }
        public StoreManager ClothingStore { get { return clothingStore; } }
        public StoreManager PhoneStore { get { return phoneStore; } }
        public string DateString { get { return currentDate.ToLongDateString(); } }
        public int Day { get { return day; } }
        public Player Player { get { return player; } }

        /// <summary>
        /// Constructor.
        /// </summary>
        public GameManager()
        {
            currentDate = startDate;
            day = 0;
            player = new Player();
            eventManager = new EventManager();

            vehicleStore = new StoreManager(ItemsHolder.createVehicles());
            watchStore = new StoreManager(ItemsHolder.createWatches());
            clothingStore = new StoreManager(ItemsHolder.createClothes());
            phoneStore = new StoreManager(ItemsHolder.createPhones());
        }
        
        /// <summary>
        /// Updates player name to given parameter value.
        /// </summary>
        public bool ChangePlayerName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                player.Name = name;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the string name of the player.
        /// </summary>
        /// <returns>The string name of the player</returns>
        public string GetPlayerName()
        {
            return player.Name;
        }

        /// <summary>
        /// Sets the city of the player to the given parameter value.
        /// </summary>
        /// <param name="city">The string city to set in the Player object.</param>
        /// <returns></returns>
        public bool ChangeCity(string city)
        {
            if (!string.IsNullOrEmpty(city))
            {
                player.City = city;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns the string name of the city of player.
        /// </summary>
        /// <returns>The string name of the city of the player.</returns>
        public string GetPlayerCity()
        {
            return player.City;
        }

        /// <summary>
        /// Handles the logic for a Work-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public Event Work()
        {
            player.Money += 100 + (player.School * 5);
            player.School -= 3;
            player.Reputation -= 3;
            player.Family -= 3;
            player.Appearance -= 3;

            Event randomWorkEvent = eventManager.RandomWorkEvent();

            if (randomWorkEvent != null && randomWorkEvent.GetType() == typeof(Event))
            {
                EventEffect evtEffect = randomWorkEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return randomWorkEvent;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Event Gym()
        {
            player.School -= 3;
            player.Reputation += 2;
            player.Family -= 3;
            player.Appearance += 4;

            Event randomGymEvent = eventManager.RandomGymEvent();

            if (randomGymEvent != null)
            {
                EventEffect evtEffect = randomGymEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return randomGymEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Event Family()
        {
            player.School -= 3;
            player.Reputation -= 3;
            player.Family += 9;
            player.Appearance -= 3;

            Event randomFamilyEvent = eventManager.RandomFamilyEvent();

            if (randomFamilyEvent != null)
            {
                EventEffect evtEffect = randomFamilyEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return randomFamilyEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Event School()
        {
            player.School += 4;
            player.Reputation -= 3;
            player.Family += 2;
            player.Appearance -= 3;

            Event randomSchoolEvent = eventManager.RandomSchoolEvent();

            if (randomSchoolEvent != null)
            {
                EventEffect evtEffect = randomSchoolEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return randomSchoolEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Event Clubbing()
        {
            player.School -= 3;
            player.Reputation += 4;
            player.Family -= 3;
            player.Appearance += 2;

            Event randomClubbingEvent = eventManager.RandomClubbingEvent();

            if (randomClubbingEvent != null)
            {
                EventEffect evtEffect = randomClubbingEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return randomClubbingEvent;
        }


        /// <summary>
        /// Updates the day counter and the currentDate of the game.
        /// </summary>
        private void SkipToNextDay()
        {
            day++;
            currentDate = currentDate.AddDays(1);
        }


        /// <summary>
        /// Applies the effect of an event to the Player.
        /// </summary>
        /// <param name="evtEffect">The EventEffect that affects the player's stats.</param>
        private void HandleEventEffect(EventEffect evtEffect)
        {
            player.Money += evtEffect.Money;
            player.School += evtEffect.School;
            player.Reputation += evtEffect.Reputation;
            player.Family += evtEffect.Family;
            player.Appearance += evtEffect.Appearance;
        }

        /// <summary>
        /// Applies the effect of an item to the Player.
        /// </summary>
        /// <param name="itemEffect">The ItemEffect that affects the player's stats.</param>
        private void ApplyItemEffect(ItemEffect itemEffect)
        {
            Player.Appearance += itemEffect.Appearance;
            Player.Family += itemEffect.Family;
            Player.Reputation += itemEffect.Reputation;
            Player.School += itemEffect.School;
        }
    }
}
