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
            updateAttributes();
        }

        private void updateAttributes()
        {
            updateDay();
            updateAppearance();
            updateReputation();
            updateSchool();
            updateFamily();
            updateMoney();
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
            gameManager.Work();
            updateAttributes();
        }

        private void button_gymActivity_Click(object sender, EventArgs e)
        {
            gameManager.Gym();
            updateAttributes();
        }

        private void button_clubbingActivity_Click(object sender, EventArgs e)
        {
            gameManager.Clubbing();
            updateAttributes();
        }

        private void button_schoolActivity_Click(object sender, EventArgs e)
        {
            gameManager.School();
            updateAttributes();
        }

        private void button_familyActivity_Click(object sender, EventArgs e)
        {
            gameManager.Family();
            updateAttributes();
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
    }
}
