using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       FileManager.cs
    /// 
    /// Created:    by Marco Trifance, Jan 15th 2017
    /// Purpose:    This class contains the logic to save/load the game state 
    ///             to/from a .txt file.
    /// </summary>
    class FileManager
    {

        /// <summary>
        /// Saves the game state to a txt file
        /// </summary>
        /// <param name="gameManager">The gameManager to save to a txt file.</param>
        /// <param name="message">The message to update to provide information to user.</param>
        /// <returns></returns>
        public bool SaveGameToFile(GameManager gameManager, string fileName, out string message)
        {
            StreamWriter writer = null;

            // Try writing the game-state to a file
            try
            {
                // Set writer instance prividing fileName string
                writer = new StreamWriter(fileName);

                // Player Name
                writer.WriteLine(gameManager.GetPlayerName());
                // Player City
                writer.WriteLine(gameManager.GetPlayerCity());
                // Day counter
                writer.WriteLine(gameManager.Day.ToString());
                

                // Money
                writer.WriteLine(gameManager.Player.Money.ToString());
                // Appearance
                writer.WriteLine(gameManager.Player.Appearance.ToString());
                // Reputation
                writer.WriteLine(gameManager.Player.Reputation.ToString());
                // School
                writer.WriteLine(gameManager.Player.School.ToString());
                // Family
                writer.WriteLine(gameManager.Player.Family.ToString());

                // Clothing
                writer.WriteLine(gameManager.Player.Clothing.Id.ToString());
                // Vehicle
                writer.WriteLine(gameManager.Player.Vehicle.Id.ToString());
                // Phone
                writer.WriteLine(gameManager.Player.Phone.Id.ToString());
                // Watch
                writer.WriteLine(gameManager.Player.Watch.Id.ToString());
                
            }
            catch (Exception e)
            {
                // Close writer if not null
                if (writer != null)
                    writer.Close();

                // Update string message
                message = "ERROR: " + e.Message;

                return false;
            }
            finally
            {
                // Close writer if not null
                if (writer != null)
                    writer.Close();
            }

            // Update string message
            message = "Game saved";

            // Return true
            return true;
        }

        /// <summary>
        /// Loads game from txt file. Returns a new instance of the GameManager if 
        /// the operation is succesful, false otherwise.
        /// </summary>
        /// <param name="fileName">The string name of the file to load.</param>
        /// <param name="message">The string message to update to provide info to the user.</param>
        /// <returns></returns>
        public GameManager LoadGameFromFile(string fileName, out string message)
        {
            GameManager manager = new GameManager();

            // Declare a StreamReader object
            StreamReader reader = null;

            try
            {
                // Set reader instance providing fileName string
                reader = new StreamReader(fileName);

                // Player Name
                manager.Player.Name = reader.ReadLine();
                // Player City
                manager.Player.City = reader.ReadLine();

                // Day
                int day = 0;
                int.TryParse(reader.ReadLine(), out day);
                manager.SetDateByCounter(day);

                // Money
                decimal money = 0;
                decimal.TryParse(reader.ReadLine(), out money);
                manager.Player.Money = money;

                // Appearance
                int appearance = 0;
                int.TryParse(reader.ReadLine(), out appearance);
                manager.Player.Appearance = appearance;

                // Reputation
                int reputation = 0;
                int.TryParse(reader.ReadLine(), out reputation);
                manager.Player.Reputation = reputation;

                // School
                int school = 0;
                int.TryParse(reader.ReadLine(), out school);
                manager.Player.School = school;


                // Family
                int family = 0;
                int.TryParse(reader.ReadLine(), out family);
                manager.Player.Family = family;

                // Clothing 
                int clothingId = 0;
                int.TryParse(reader.ReadLine(), out clothingId);
                manager.SetPlayerClothingById(clothingId);

                // Vehicle
                int vehicleId = 0;
                int.TryParse(reader.ReadLine(), out vehicleId);
                manager.SetPlayerVehicleById(vehicleId);

                // Phone
                int phoneId = 0;
                int.TryParse(reader.ReadLine(), out phoneId);
                manager.SetPlayerPhoneById(phoneId);

                // Watch
                int watchId = 0;
                int.TryParse(reader.ReadLine(), out watchId);
                manager.SetPlayerWatchById(watchId);

            }
            catch (Exception e)
            {
                // Update message 
                message = "ERROR:" + e.Message;

                // Return null 
                return null;
            }
            finally
            {
                // Close reader if not-null
                if (reader != null)
                    reader.Close();
            }

            message = string.Empty;

            return manager;
        }
    }
}
