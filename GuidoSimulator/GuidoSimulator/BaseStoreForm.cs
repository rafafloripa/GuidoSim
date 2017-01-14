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
    public partial class BaseStoreForm : Form
    {
        // **** Remove Player *****
        protected GameManager gameManager;
        protected StoreManager storeManager;

        public BaseStoreForm(GameManager gameManager, StoreManager storeManager)
        {
            InitializeComponent();
            this.gameManager = gameManager;
            this.storeManager = storeManager;
            fillPictures();
            disableButton();
            updateMoney();
        }

        protected void updateMoney()
        {
            label_money.Text = gameManager.Player.Money.ToString();
        }

        protected void fillPictures()
        {
            picture_box_item_0.Image = storeManager.getItem(0).ItemImage;
            picture_box_item_1.Image = storeManager.getItem(1).ItemImage;
            picture_box_item_2.Image = storeManager.getItem(2).ItemImage;
            picture_box_item_3.Image = storeManager.getItem(3).ItemImage;
        }

        protected void disableButton()
        {

        }

        protected virtual void buy_btn_item_1_Click(object sender, EventArgs e)
        {
            int itemIndex = 0;
            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased) MessageBox.Show("Sorry, your purchase for " + storeManager.getItem(itemIndex).Name + "  was not procssed.");
            else
            {

                MessageBox.Show("Congratulations on your new purchase!");
            }
        }

        protected virtual void buy_btn_item_2_Click(object sender, EventArgs e)
        {
            int itemIndex = 1;
            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased) MessageBox.Show("Sorry, your purchase for " + storeManager.getItem(itemIndex).Name + " was not procssed.");
            else
            {
                MessageBox.Show("Congratulations on your new purchase!");
            }
        }

        protected virtual void buy_btn_item_3_Click(object sender, EventArgs e)
        {
            int itemIndex = 2;
            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased) MessageBox.Show("Sorry, your purchase for " + storeManager.getItem(itemIndex).Name + " was not procssed.");
            else
            {
                MessageBox.Show("Congratulations on your new purchase!");
            }
        }

        protected virtual void buy_btn_item_0_Click(object sender, EventArgs e)
        {
            int itemIndex = 3;
            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased) MessageBox.Show("Sorry, your purchase for " + storeManager.getItem(itemIndex).Name + " was not procssed.");
            else
            {
                MessageBox.Show("Congratulations on your new purchase!");
            }
        }
    }
}
