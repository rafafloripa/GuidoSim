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
        private int day;
        private Player player;
        private EventManager eventManager;

        public GameManager()
        {
            this.Day = 1;
            this.Player = new Player();
            this.eventManager = new EventManager();
        }

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public void ChangeName()
        {
            DialogResult nameDialog = new DialogResult();
            NameCityForm nameForm = new NameCityForm("Change name", "What is your name?", player.Name);
            nameDialog = nameForm.ShowDialog();
            if (nameDialog == DialogResult.OK)
            {
                player.Name = nameForm.Value;
            }
        }

        public void ChangeCity()
        {
            DialogResult cityDialog = new DialogResult();
            NameCityForm cityForm = new NameCityForm("Change city", "Where do you live?", player.City);
            cityDialog = cityForm.ShowDialog();
            if (cityDialog == DialogResult.OK)
            {
                player.City = cityForm.Value;
            }
        }

        public Event Work()
        {
            player.Money += 500 + (player.School * 5);
            player.School -= 3;
            player.Reputation -= 3;
            player.Family -= 3;
            player.Appearance -= 3;

            //**** Insert logic when to generate event here!!! ***
            Event randomWorkEvent = eventManager.RandomWorkEvent();

            if (randomWorkEvent != null)
            {
                EventEffect evtEffect = randomWorkEvent.Effect;
                HandleEventEffect(evtEffect);
            }
                
            Day++;

            return randomWorkEvent;
        }

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
            
            Day++;

            return randomGymEvent;
        }

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

            Day++;

            return randomFamilyEvent;
        }

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

            Day++;

            return randomSchoolEvent;
        }


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
            
            Day++;

            return randomClubbingEvent;
        }

        // Updates Player stats according to event-effect
        private void HandleEventEffect(EventEffect evtEffect)
        {
            player.Money += evtEffect.Money;
            player.School -= evtEffect.School;
            player.Reputation -= evtEffect.Reputation;
            player.Family -= evtEffect.Family;
            player.Appearance -= evtEffect.Appearance;
        }

        // Accounts for item level for the different stats
        public void regulateAttributes() 
        {
            int base_appearance = 0;
            int base_rep = 0;
            int base_school = 0;
            int base_family = 0;

            if(Player.CurrentItemLevels[0] != -1)
            {
                base_appearance += 5 * (Player.CurrentItemLevels[0] + 1);
                base_rep += 5 * (Player.CurrentItemLevels[0] + 1);
            }

            if(Player.CurrentItemLevels[1] != -1)
            {
                base_appearance += 5 * (Player.CurrentItemLevels[1] + 1);
                base_rep += 5 * (Player.CurrentItemLevels[1] + 1);
            }

            if (Player.CurrentItemLevels[2] != -1)
            {
                base_school += 5 * (Player.CurrentItemLevels[2] + 1);
                base_family += 5 * (Player.CurrentItemLevels[2] + 1);
            }

            if (Player.CurrentItemLevels[3] != -1)
            {
                base_school += 5 * (Player.CurrentItemLevels[3] + 1);
                base_family += 5 * (Player.CurrentItemLevels[3] + 1);
            }

            // Ensure stats don't fall below base-level.
            if (Player.Appearance < base_appearance) Player.Appearance = base_appearance;
            if (Player.Reputation < base_rep) Player.Reputation = base_rep;
            if (Player.School < base_school) Player.School = base_school;
            if (Player.Family < base_family) Player.Family = base_family;
        }
    }
}
