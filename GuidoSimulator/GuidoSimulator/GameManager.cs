using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoSimulator
{

    /// <summary>
    /// Name:       GameManager.cs
    /// 
    /// Created:    by Rafael da Silva Martins
    /// Purpose:    Handles the game logic.
    /// </summary>
    public class GameManager
    {
        private DateTime startDate = new DateTime(2017, 1, 1);

        private DateTime currentDate;
        private int day;
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
        public Player Player { get { return player; } }

        public int Day
        {
            get { return day; }
            set { this.day = value; }
        }

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
        /// Sets Player Clothing to Item with given Id.
        /// </summary>
        /// <param name="clothingId"></param>
        /// <returns>True if operation is successful, false otherwise.</returns>
        public bool SetPlayerClothingById(int clothingId)
        {
            Clothing defaultClothing = ItemsHolder.CreateDefaultClothes();

            if (defaultClothing.Id == clothingId)
            {
                player.Clothing = defaultClothing;
                return true;
            }
            else
            {
                Clothing[] storeClothes = ItemsHolder.createClothes();

                foreach (Clothing c in storeClothes)
                {
                    if (c.Id == clothingId)
                    {
                        player.Clothing = c;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Sets Player Vehicle to Item with given Id.
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns>True if operation is successful, false otherwise.</returns>
        public bool SetPlayerVehicleById(int vehicleId)
        {
            Vehicle defaultVehicle = ItemsHolder.CreateDefaultVehicle();

            if (defaultVehicle.Id == vehicleId)
            {
                player.Vehicle = defaultVehicle;
                return true;
            }
            else
            {
                Vehicle[] storeVehicles = ItemsHolder.createVehicles();

                foreach (Vehicle v in storeVehicles)
                {
                    if (v.Id == vehicleId)
                    {
                        player.Vehicle = v;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Sets Player Phone to Item with given Id.
        /// </summary>
        /// <param name="phoneId"></param>
        /// <returns>True if operation is successful, false otherwise.</returns>
        public bool SetPlayerPhoneById(int phoneId)
        {
            Phone defaultPhone = ItemsHolder.CreateDefaultPhone();

            if (defaultPhone.Id == phoneId)
            {
                player.Phone = defaultPhone;
                return true;
            }
            else
            {
                Phone[] storePhones = ItemsHolder.createPhones();

                foreach (Phone p in storePhones)
                {
                    if (p.Id == phoneId)
                    {
                        player.Phone = p;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Sets Player Watch to Item with given Id.
        /// </summary>
        /// <param name="watchId"></param>
        /// <returns>True if operation is successful, false otherwise.</returns>
        public bool SetPlayerWatchById(int watchId)
        {
            Watch defaultWatch= ItemsHolder.CreateDefaultWatch();

            if (defaultWatch.Id == watchId)
            {
                player.Watch = defaultWatch;
                return true;
            }
            else
            {
                Watch[] storeWatches = ItemsHolder.createWatches();

                foreach (Watch w in storeWatches)
                {
                    if (w.Id == watchId)
                    {
                        player.Watch = w;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Sets the current date to the date equal to 'startDate' plus the
        /// number of days given by 'dayCounter' parameter.
        /// </summary>
        /// <param name="dayCounter"></param>
        public void SetDateByCounter(int dayCounter)
        {
            currentDate = startDate.AddDays(dayCounter);
        }

        /// <summary>
        /// Handles the logic for a Work-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public ActivityResult Work()
        {
            ActivityResult activityRes;

            // Check if holiday
            if (IsHoliday())
            {
                activityRes = new ActivityResult(false, "You can't work on a holiday.", null);
                //SkipToNextDay();
                return activityRes;
            }
            
            // Update player's stats
            player.Money += 100 + (player.School * 5);
            player.School -= 3;
            player.Reputation -= 3;
            player.Family -= 3;
            player.Appearance -= 3;

            activityRes = new ActivityResult(true, string.Empty, null);

            Event randomWorkEvent = eventManager.RandomWorkEvent();

            if (randomWorkEvent != null && randomWorkEvent.GetType() == typeof(Event))
            {
                activityRes.ActivityEvent = randomWorkEvent;
                EventEffect evtEffect = randomWorkEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return activityRes;
        }

        /// <summary>
        /// Handles the logic for a Gym-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public ActivityResult Gym()
        {
            player.School -= 3;
            player.Reputation += 2;
            player.Family -= 3;
            player.Appearance += 4;

            ActivityResult activityRes = new ActivityResult(true, string.Empty, null);

            Event randomGymEvent = eventManager.RandomGymEvent();

            if (randomGymEvent != null)
            {
                activityRes.ActivityEvent = randomGymEvent;
                EventEffect evtEffect = randomGymEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return activityRes;
        }

        /// <summary>
        /// Handles the logic for a Family-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public ActivityResult Family()
        {
            player.School -= 3;
            player.Reputation -= 3;
            player.Family += 9;
            player.Appearance -= 3;

            ActivityResult activityRes = new ActivityResult(true, string.Empty, null);

            Event randomFamilyEvent = eventManager.RandomFamilyEvent();

            if (randomFamilyEvent != null)
            {
                activityRes.ActivityEvent = randomFamilyEvent;
                EventEffect evtEffect = randomFamilyEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return activityRes;
        }

        /// <summary>
        /// Handles the logic for a School-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public ActivityResult School()
        {
            ActivityResult activityRes;

            // Check if holiday
            if (IsHoliday())
            {
                activityRes = new ActivityResult(false, "You can't go to school on a holiday.", null);
                //SkipToNextDay();
                return activityRes;
            }

            player.School += 4;
            player.Reputation -= 3;
            player.Family += 2;
            player.Appearance -= 3;

            activityRes = new ActivityResult(true, string.Empty, null);

            Event randomSchoolEvent = eventManager.RandomSchoolEvent();

            if (randomSchoolEvent != null)
            {
                activityRes.ActivityEvent = randomSchoolEvent;
                EventEffect evtEffect = randomSchoolEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return activityRes;
        }

        /// <summary>
        /// Handles the logic for a Clubbing-activity. Returns the Event that is generated
        /// by the EventManager. Returns null if no event is generated.
        /// </summary>
        /// <returns>The generated Event if generated, null otherwise.</returns>
        public ActivityResult Clubbing()
        {
            ActivityResult clubbingRes;

            if (IsMonday())
            {
                clubbingRes = new ActivityResult(false, "All clubs are closed on Monday.", null);
                //SkipToNextDay();
                return clubbingRes;
            }

            player.School -= 3;
            player.Reputation += 4;
            player.Family -= 3;
            player.Appearance += 2;

            clubbingRes = new ActivityResult(true, string.Empty, null);
            Event randomClubbingEvent = eventManager.RandomClubbingEvent();

            if (randomClubbingEvent != null)
            {
                clubbingRes.ActivityEvent = randomClubbingEvent;
                EventEffect evtEffect = randomClubbingEvent.Effect;
                HandleEventEffect(evtEffect);
            }

            SkipToNextDay();

            return clubbingRes;
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
        /// Returns true if current date is either a Sunday or Christmas, false otherwise.
        /// </summary>
        /// <returns>True if current date is either a Sunday or Christmas, false otherwise.</returns>
        private bool IsHoliday()
        {
            if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                return true;

            DateTime christmasDay = new DateTime(2017, 12, 25);

            if (currentDate.Day.Equals(christmasDay.Day) && currentDate.Month.Equals(christmasDay.Month))
                return true;

            return false;
        }

        /// <summary>
        /// Returns true if current date is either a Monday, false otherwise.
        /// </summary>
        /// <returns>True if current date is either a Monday, false otherwise.</returns>
        private bool IsMonday()
        {
            if (currentDate.DayOfWeek == DayOfWeek.Monday)
                return true;
            else
                return false;
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
