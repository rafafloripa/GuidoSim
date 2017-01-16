using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoSimulator
{
    /// <summary>
    /// Name:       MainForm.cs
    /// 
    /// Created:    by Rafael da Silva Martins
    /// 
    /// Purpose:    This module handles the user interactions with the 
    ///             GUI elements and displays the information from the GameManager.
    /// </summary>
    public partial class MainForm : Form
    {
        GameManager gameManager = new GameManager();
        FileManager fileManager = new FileManager();

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initialize GUI control elements.
        /// </summary>
        private void InitializeGUI()
        {            
            UpdateGUI();

            updateName();
            updateCity();
        }

        /// <summary>
        /// Updates info in the GUI controls. 
        /// </summary>
        public void UpdateGUI()
        {
            updateDay();
            updateAppearance();
            updateReputation();
            updateSchool();
            updateFamily();
            updateMoney();
            updateImages();
        }

        /// <summary>
        /// Update picture-box images.
        /// </summary>
        private void updateImages()
        {
            pictureBox_phone.Image = gameManager.Player.PhoneImage;
            pictureBox_vehicle.Image = gameManager.Player.VehicleImage;
            pictureBox_watch.Image = gameManager.Player.WatchImage;
            pictureBox_playerPicture.Image = gameManager.Player.ClothesImage;
        }

        /// <summary>
        /// Update family score and progress bar.
        /// </summary>
        private void updateFamily()
        {
            label_familyValue.Text = (gameManager.Player.Family).ToString();
            progressBar_family.Value = gameManager.Player.Family;
        }

        /// <summary>
        /// Update school score and progress bar.
        /// </summary>
        private void updateSchool()
        {
            label_schoolValue.Text = (gameManager.Player.School).ToString();
            progressBar_school.Value = gameManager.Player.School;
        }

        /// <summary>
        /// Update reputation score and progress bar.
        /// </summary>
        private void updateReputation()
        {
            label_reputationValue.Text = (gameManager.Player.Reputation).ToString();
            progressBar_reputation.Value = gameManager.Player.Reputation;
        }

        /// <summary>
        /// Update appearance score and progress bar.
        /// </summary>
        private void updateAppearance()
        {
            label_appearanceValue.Text = (gameManager.Player.Appearance).ToString();
            progressBar_appearance.Value = gameManager.Player.Appearance;
        }

        /// <summary>
        /// Update money GUI label to display current budget.
        /// </summary>
        private void updateMoney()
        {
            label_money.Text = "$" + gameManager.Player.Money.ToString();
        }

        /// <summary>
        /// Update info in day label to display current day.
        /// </summary>
        private void updateDay()
        {
            label_day.Text = gameManager.DateString;
        }

        /// <summary>
        /// Update player name label to display current player name.
        /// </summary>
        private void updateName()
        {
            label_playerName.Text = gameManager.Player.Name;
        }

        /// <summary>
        /// Update city label to display current city name.
        /// </summary>
        private void updateCity()
        {
            label_playerCity.Text = gameManager.Player.City;
        }

        /// <summary>
        /// Enables all button controls.
        /// </summary>
        private void EnableButtons()
        {
            button_clothesStore.Enabled = true;
            button_scooterStore.Enabled = true;
            button_watchStore.Enabled = true;
            button_phoneStore.Enabled = true;
            button_gymActivity.Enabled = true;
            button_familyActivity.Enabled = true;
            button_workActivity.Enabled = true;
            button_clubbingActivity.Enabled = true;
            button_schoolActivity.Enabled = true;
        }

        /// <summary>
        /// Disables all button controls.
        /// </summary>
        private void DisableButtons()
        {
            button_clothesStore.Enabled = false;
            button_scooterStore.Enabled = false;
            button_watchStore.Enabled = false;
            button_phoneStore.Enabled = false;
            button_gymActivity.Enabled = false;
            button_familyActivity.Enabled = false;
            button_workActivity.Enabled = false;
            button_clubbingActivity.Enabled = false;
            button_schoolActivity.Enabled = false;
        }

        /// <summary>
        /// Displays given string message in a Message box. Returns true if user selects 'YES', false if user selects 'NO'.
        /// </summary>
        /// <param name="message">The message to display in the MessageBox</param>
        /// <returns>True if user selects 'YES', false if user selects 'NO'</returns>
        private bool ReadConfirmation(string message)
        {
            // Show confirmation MessageBox displaying 'message' and read user input. If user selected yes...
            if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else   // ... else user selected 'NO'
                return false;
        }

        /// <summary>
        /// Event holder. Handles 'work' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_workActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ActivityResult workResult = gameManager.Work();

            // Check if activity was completed
            if (!workResult.Completed)
            {
                MessageBox.Show(workResult.Description, "On the 7th day you shall rest.");
                UpdateGUI();
                EnableButtons();
                return;
            }
                
            Event workEvent = workResult.ActivityEvent;

            if (workEvent != null)
            {
                displayEvent(workEvent);
            }
            else
            {
                EnableButtons();
            }

            UpdateGUI();
        }

        /// <summary>
        /// Displays an Event in an EventForm.
        /// </summary>
        /// <param name="evt"></param>
        private void displayEvent(Event evt)
        {
            EventForm eventForm = new EventForm(evt);

            eventForm.FormClosed += (newsender, newe) =>
            {
                 UpdateGUI();
                EnableButtons();
            };

            eventForm.Show();
        }

        /// <summary>
        /// Event Handler. Handles click on gym button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gymActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ActivityResult gymResult = gameManager.Gym();
            Event gymEvent = gymResult.ActivityEvent;

            if (gymEvent != null)
            {
                displayEvent(gymEvent);
            }
            else
            {
                EnableButtons();
            }

            UpdateGUI();
        }

        /// <summary>
        /// Event Handler. Handles click on clubbing button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clubbingActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ActivityResult clubbingRes = gameManager.Clubbing();

            if (!clubbingRes.Completed)
            {
                MessageBox.Show(clubbingRes.Description, "All clubs are closed on Monday.");
                UpdateGUI();
                EnableButtons();
                return;
            }

            Event clubbingEvent = clubbingRes.ActivityEvent;

            if (clubbingEvent != null)
            {
                displayEvent(clubbingEvent);
            }
            else 
            {
                EnableButtons();
            }

            UpdateGUI();
        }

        /// <summary>
        /// Event Handler. Handles click on shool button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_schoolActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();

            ActivityResult schoolResult = gameManager.School();

            // Check if activity was completed
            if (!schoolResult.Completed)
            {
                MessageBox.Show(schoolResult.Description, "On the 7th day you shall rest.");
                UpdateGUI();
                EnableButtons();
                return;
            }

            Event schoolEvent = schoolResult.ActivityEvent;

            if (schoolEvent != null)
            {
                displayEvent(schoolEvent);
            }
            else
            {
                EnableButtons();
            }

            UpdateGUI();
        }

        /// <summary>
        /// Event Handler.Handles the click event on the family activity button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_familyActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ActivityResult familyRes = gameManager.Family();
            Event familyEvent = familyRes.ActivityEvent;

            if (familyEvent != null)
            {
                displayEvent(familyEvent);
            }
            else
            {
                EnableButtons();
            }

            UpdateGUI();
        }

        /// <summary>
        /// Event Handler.Handles the click event on the player name label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_playerName_DoubleClick(object sender, EventArgs e)
        {
            DialogResult nameDialog = new DialogResult();
            NameCityForm nameForm = new NameCityForm("Change name", "What is your name?", gameManager.GetPlayerName());
            nameDialog = nameForm.ShowDialog();
            if (nameDialog == DialogResult.OK)
            {
                gameManager.ChangePlayerName(nameForm.Value);
            }

            updateName();
        }

        /// <summary>
        /// Event Handler.Handles the click event on the City label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_playerCity_DoubleClick(object sender, EventArgs e)
        {
            DialogResult cityDialog = new DialogResult();
            NameCityForm cityForm = new NameCityForm("Change city", "Where do you live?", gameManager.GetPlayerCity());
            cityDialog = cityForm.ShowDialog();
            if (cityDialog == DialogResult.OK)
            {
                gameManager.ChangeCity(cityForm.Value);
            }

            updateCity();
        }

        /// <summary>
        /// Event Handler.Handles the click event on the clothes store button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clothesStore_Click(object sender, EventArgs e)
        {
            DisableButtons();
            BaseStoreForm clothesStore = new BaseStoreForm(this, gameManager, gameManager.ClothingStore);
            clothesStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
                EnableButtons();
            };
            clothesStore.Show();
        }

        /// <summary>
        /// Event Handler.Handles the click event on the vehicle store button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_scooterStore_Click(object sender, EventArgs e)
        {
            DisableButtons();
            BaseStoreForm vehicleStore = new BaseStoreForm(this, gameManager, gameManager.VehicleStore);
            vehicleStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
                EnableButtons();
            };
            vehicleStore.Show();
        }

        /// <summary>
        /// Event Handler. Handles the click event on the phone store button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_phoneStore_Click(object sender, EventArgs e)
        {
            DisableButtons();
            BaseStoreForm phoneStore = new BaseStoreForm(this, gameManager, gameManager.PhoneStore);
            phoneStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
                EnableButtons();
            };
            phoneStore.Show();
        }

        /// <summary>
        /// Event Handler. Handles the click event on the watch store button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_watchStore_Click(object sender, EventArgs e)
        {
            DisableButtons();
            BaseStoreForm watchStore = new BaseStoreForm(this, gameManager, gameManager.WatchStore);
            watchStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
                EnableButtons();
            };
            watchStore.Show();
        }

        /// <summary>
        /// Event Handler. Handles click on 'About' in Help menu. 
        /// Opens the About Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGuido aboutBox = new AboutGuido();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Event Handler. Handles click on 'exit' option in File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void on_exit_fileMenu_click(object sender, EventArgs e)
        {
            if (ReadConfirmation("Are you sure you want to exit 'Guido Manager'? All the unsaved data will be lost."))
                Application.Exit();
        }

        /// <summary>
        /// Event Handler. Handles click on 'save game' option in File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void on_save_fileMenu_click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "Guido.txt";
            saveFileDialog.Filter = "Text files (*.txt) |*.txt";

            // If user selected OK in dialog...
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Declare user-info message 
                string message = string.Empty;

                // Save file and display message to user
                if (fileManager.SaveGameToFile(gameManager, saveFileDialog.FileName, out message))
                {
                    MessageBox.Show(message, "Save file", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Event Handler. Handles click on 'Load game' option in File Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void on_load_fileMenu_click(object sender, EventArgs e)
        {
            if (ReadConfirmation("Are you sure you want to load a saved game? All the unsaved data will be lost."))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files () (*.txt) | *.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Declare user-info message 
                    string message = string.Empty;
                    GameManager newManager = fileManager.LoadGameFromFile(openFileDialog.FileName, out message);

                    if (newManager != null)
                    {
                        gameManager = newManager;
                        InitializeGUI();
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Event Handler. Handles click on 'New game' option in File Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void on_new_fileMenu_click(object sender, EventArgs e)
        {
            if (ReadConfirmation("Are you sure you want to start a new game? All the unsaved data will be lost."))
            {
                gameManager = new GameManager();
                InitializeGUI();
            }
        }
    }
}
