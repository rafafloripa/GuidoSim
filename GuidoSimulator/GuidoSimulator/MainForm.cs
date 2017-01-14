﻿using System;
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

        private void button_workActivity_Click(object sender, EventArgs e)
        {
            Event workEvent = gameManager.Work();

            if (workEvent != null) {
                displayEvent(workEvent);
            }

            UpdateGUI();
        }

        // Displays the event in a MessageBox
        private void displayEvent(Event evt)
        {

            if (!evt.HasPlayerChoice)
            {
                MessageBox.Show(evt.Description, evt.Title);
            }
            else
            {
                // to-do....
            }
        }

        private void button_gymActivity_Click(object sender, EventArgs e)
        {
            Event gymEvent = gameManager.Gym();

            if (gymEvent != null)
            {
                displayEvent(gymEvent);
            }

            UpdateGUI();
        }

        private void button_clubbingActivity_Click(object sender, EventArgs e)
        {
            Event clubbingEvent = gameManager.Clubbing();

            if (clubbingEvent != null)
            {
                displayEvent(clubbingEvent);
            }

            UpdateGUI();
        }

        private void button_schoolActivity_Click(object sender, EventArgs e)
        {
            Event schoolEvent = gameManager.School();

            if (schoolEvent != null)
            {
                displayEvent(schoolEvent);
            }

            UpdateGUI();
        }

        private void button_familyActivity_Click(object sender, EventArgs e)
        {
            Event familyEvent = gameManager.Family();

            if (familyEvent  != null)
            {
                displayEvent(familyEvent);
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
            BaseStoreForm clothesStore = new BaseStoreForm(this, gameManager, gameManager.ClothingStore);
            clothesStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
            };
            clothesStore.Show();
        }

        private void button_scooterStore_Click(object sender, EventArgs e)
        {
            BaseStoreForm vehicleStore = new BaseStoreForm(this, gameManager, gameManager.VehicleStore);
            vehicleStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
            };
            vehicleStore.Show();
        }

        private void button_phoneStore_Click(object sender, EventArgs e)
        {
            BaseStoreForm phoneStore = new BaseStoreForm(this, gameManager, gameManager.PhoneStore);
            phoneStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
            };
            phoneStore.Show();
        }

        private void button_watchStore_Click(object sender, EventArgs e)
        {
            BaseStoreForm watchStore = new BaseStoreForm(this, gameManager, gameManager.WatchStore);
            watchStore.FormClosed += (newsender, newe) =>
            {
                UpdateGUI();
            };
            watchStore.Show();
        }
    }
}
