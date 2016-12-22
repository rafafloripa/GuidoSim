using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    class GameManager
    {
        private int day;
        private Player player;

        public GameManager()
        {
            this.Day = 1;
            this.Player = new Player();
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

        public void Work()
        {
            player.Money += 500 + (player.School * 5);
            player.School -= 3;
            player.Reputation -= 3;
            player.Family -= 3;
            player.Appearance -= 3;
            Day++;
        }

        public void Gym()
        {
            player.School -= 3;
            player.Reputation += 2;
            player.Family -= 3;
            player.Appearance += 4;
            Day++;
        }

        public void Family()
        {
            player.School -= 3;
            player.Reputation -= 3;
            player.Family += 9;
            player.Appearance -= 3;
            Day++;
        }

        public void School()
        {
            player.School += 4;
            player.Reputation -= 3;
            player.Family += 2;
            player.Appearance -= 3;
            Day++;
        }

        public void Clubbing()
        {
            player.School -= 3;
            player.Reputation += 4;
            player.Family -= 3;
            player.Appearance += 2;
            Day++;
        }
    }
}
