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
    public partial class MainForm : Form
    {
        GameManager gameManager = new GameManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {            
            UpdateGUI();
        }

        // Public: called by store forms at purchase
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

        private void updateImages()
        {
            pictureBox_phone.Image = gameManager.Player.PhoneImage;
            pictureBox_vehicle.Image = gameManager.Player.VehicleImage;
            pictureBox_watch.Image = gameManager.Player.WatchImage;
            pictureBox_playerPicture.Image = gameManager.Player.ClothesImage;
        }

        private void updateFamily()
        {
            label_familyValue.Text = (gameManager.Player.Family / 10).ToString();
            progressBar_family.Value = gameManager.Player.Family;
        }

        private void updateSchool()
        {
            label_schoolValue.Text = (gameManager.Player.School / 10).ToString();
            progressBar_school.Value = gameManager.Player.School;
        }

        private void updateReputation()
        {
            label_reputationValue.Text = (gameManager.Player.Reputation / 10).ToString();
            progressBar_reputation.Value = gameManager.Player.Reputation;
        }

        private void updateAppearance()
        {
            label_appearanceValue.Text = (gameManager.Player.Appearance / 10).ToString();
            progressBar_appearance.Value = gameManager.Player.Appearance;
        }

        private void updateMoney()
        {
            label_money.Text = "$" + gameManager.Player.Money.ToString();
        }

        private void updateDay()
        {
            label_day.Text = "Day " + gameManager.Day.ToString();
        }

        private void updateName()
        {
            label_playerName.Text = gameManager.Player.Name;
        }

        private void updateCity()
        {
            label_playerCity.Text = gameManager.Player.City;
        }


        /// <summary>
        /// 
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
        /// 
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
        /// Event holder. Handles 'work' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_workActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Event workEvent = gameManager.Work();

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

        // Displays the event in a MessageBox
        private void displayEvent(Event evt)
        {
            // Display choice-event...
            if (evt.GetType() == typeof(ChoiceEvent))
            {
                MessageBox.Show("Choice event detected!!");
            }
            // ...else display base-event...
            else
            {
                //MessageBox.Show(evt.Description, evt.Title);
                EventForm eventForm = new EventForm(evt);

                eventForm.FormClosed += (newsender, newe) =>
                {
                    EnableButtons();
                    UpdateGUI();
                };

                eventForm.Show();
            }
        }

        private void button_gymActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Event gymEvent = gameManager.Gym();

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

        private void button_clubbingActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Event clubbingEvent = gameManager.Clubbing();

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

        private void button_schoolActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Event schoolEvent = gameManager.School();

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

        private void button_familyActivity_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Event familyEvent = gameManager.Family();

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

        private void label_playerName_DoubleClick(object sender, EventArgs e)
        {
            gameManager.ChangeName();
            updateName();
        }

        private void label_playerCity_DoubleClick(object sender, EventArgs e)
        {
            gameManager.ChangeCity();
            updateCity();
        }

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
    }
}
