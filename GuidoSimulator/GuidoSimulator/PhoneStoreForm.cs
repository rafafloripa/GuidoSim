using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuidoSimulator
{
    public partial class PhoneStoreForm : GuidoSimulator.BaseStoreForm
    {
        public PhoneStoreForm(Player player) : base(player)
        {
            InitializeComponent();
            fillPictures();
            setPrices();
            updateMoney();
            enableButtons();
        }

        private void disableButtons()
        {
            this.buy_btn_item_0.Enabled = false;
            this.buy_btn_item_1.Enabled = false;
            this.buy_btn_item_2.Enabled = false;
            this.buy_btn_item_3.Enabled = false;
        }

        private void enableButtons()
        {
            Button[] buttons = new Button[] { this.buy_btn_item_0, this.buy_btn_item_1, this.buy_btn_item_2, this.buy_btn_item_3 };
            if(Player.CurrentItemLevels[2] == -1)
            {
                this.buy_btn_item_0.Enabled = true;
            }
            else if (Player.CurrentItemLevels[2] == 3)
            {
                MessageBox.Show("You have already purchased everything from this shop!");
            }
            else
            {
                buttons[Player.CurrentItemLevels[2] + 1].Enabled = true;
            }
        }

        private void fillPictures()
        {
            this.picture_box_item_0.Image = Properties.Resources.phone1;
            this.picture_box_item_0.Refresh();
            this.picture_box_item_0.Visible = true;

            this.picture_box_item_1.Image = Properties.Resources.phone_level_1;
            this.picture_box_item_1.Refresh();
            this.picture_box_item_1.Visible = true;

            this.picture_box_item_2.Image = Properties.Resources.phone_level_2;
            this.picture_box_item_2.Refresh();
            this.picture_box_item_2.Visible = true;

            this.picture_box_item_3.Image = Properties.Resources.phone_level_3;
            this.picture_box_item_3.Refresh();
            this.picture_box_item_3.Visible = true;
        }

        private void setPrices()
        {
            label_price_item_0.Text = "Price: $500";
            label_price_item_1.Text = "Price: $1000";
            label_price_item_2.Text = "Price: $1500";
            label_price_item_3.Text = "Price: $2000";
        }

        private void updateMoney()
        {
            this.label_money.Text = "$" + Player.Money.ToString();
        }

        protected override void buy_btn_item_0_Click(object sender, EventArgs e)
        {
            if(Player.Money < 500)
            {
                MessageBox.Show("Sorry, you don't have enough money for this!");
                return;
            }
            Player.Money -= 500;
            Player.CurrentItemLevels[2] = 0;
            MessageBox.Show("Purchase successful!");
            updateMoney();
            disableButtons();
            enableButtons();
        }

        protected override void buy_btn_item_1_Click(object sender, EventArgs e)
        {
            if (Player.Money < 1000)
            {
                MessageBox.Show("Sorry, you don't have enough money for this!");
                return;
            }
            Player.Money -= 1000;
            Player.CurrentItemLevels[2] = 1;
            Player.PhoneImage = Properties.Resources.phone_level_1;
            MessageBox.Show("Purchase successful!");
            updateMoney();
            disableButtons();
            enableButtons();
        }

        protected override void buy_btn_item_2_Click(object sender, EventArgs e)
        {
            if (Player.Money < 1500)
            {
                MessageBox.Show("Sorry, you don't have enough money for this!");
                return;
            }
            Player.Money -= 1500;
            Player.CurrentItemLevels[2] = 2;
            Player.PhoneImage = Properties.Resources.phone_level_2;
            MessageBox.Show("Purchase successful!");
            updateMoney();
            disableButtons();
            enableButtons();
        }

        protected override void buy_btn_item_3_Click(object sender, EventArgs e)
        {
            if (Player.Money < 2000)
            {
                MessageBox.Show("Sorry, you don't have enough money for this!");
                return;
            }
            Player.Money -= 2000;
            Player.CurrentItemLevels[2] = 3;
            Player.PhoneImage = Properties.Resources.phone_level_3;
            MessageBox.Show("Purchase successful!");
            updateMoney();
            disableButtons();
            enableButtons();
        }
    }
}
