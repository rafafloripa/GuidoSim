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
        protected MainForm mainForm;
        protected GameManager gameManager;
        protected StoreManager storeManager;

        /// <summary>
        /// Constructor. Sets the instances of the GameManager and StoreManager objects.
        /// </summary>
        /// <param name="gameManager">The instance of the GameManager.</param>
        /// <param name="storeManager">The instance of the StoreManager</param>
        public BaseStoreForm(MainForm mainForm, GameManager gameManager, StoreManager storeManager)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.gameManager = gameManager;
            this.storeManager = storeManager;

            initializeGUI();

            updateBudgetLabel();        
        }

        /// <summary>
        /// Sets GUI controls to their initial state.
        /// </summary>
        private void initializeGUI()
        {
            fillItemsInformation();
            updateBudgetLabel();
            enableButtons();
        }

        private void updateGUI()
        {
            updateBudgetLabel();
            enableButtons();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void updateBudgetLabel()
        {
            label_money.Text = gameManager.Player.Money.ToString();
        }

        /// <summary>
        /// Fills GUI controls with items information.
        /// </summary>
        private void fillItemsInformation()
        {
            Item item_0 = storeManager.getItem(0);
            picture_box_item_0.Image = item_0.ItemImage;
            price_item_0.Text = item_0.Price.ToString();
            description_item_0.Text = item_0.Description;

            Item item_1 = storeManager.getItem(1);
            picture_box_item_1.Image = item_1.ItemImage;
            price_item_1.Text = item_1.Price.ToString();
            description_item_1.Text = item_1.Description;

            Item item_2 = storeManager.getItem(2);
            picture_box_item_2.Image = item_2.ItemImage;
            price_item_2.Text = item_2.Price.ToString();
            description_item_2.Text = item_2.Description;

            Item item_3 = storeManager.getItem(3);
            picture_box_item_3.Image = item_3.ItemImage;
            price_item_3.Text = item_3.Price.ToString();
            description_item_3.Text = item_3.Description;
        }

        /// <summary>
        /// Disables all button controls.
        /// </summary>
        protected void disableButtons()
        {
            buy_btn_item_0.Enabled = false;
            buy_btn_item_1.Enabled = false;
            buy_btn_item_2.Enabled = false;
            buy_btn_item_3.Enabled = false;
        }

        /// <summary>
        /// Enables all button controls.
        /// </summary>
        protected void enableButtons()
        {
            buy_btn_item_0.Enabled = true;
            buy_btn_item_1.Enabled = true;
            buy_btn_item_2.Enabled = true;
            buy_btn_item_3.Enabled = true;
        }

        /// <summary>
        /// Event Handler. Handles 'buy item 0' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void buy_btn_item_0_Click(object sender, EventArgs e)
        {
            int itemIndex = 0;

            if (storeManager.playerHasItem(gameManager.Player, itemIndex))
            {
                MessageBox.Show("You already have this item!", storeManager.getItem(itemIndex).Name);
                return;
            }

            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased)
                MessageBox.Show("Sorry, you don't have enough money to buy this article.", storeManager.getItem(itemIndex).Name + " purchase failed");
            else
            {
                MessageBox.Show("Congratulations on your new purchase!", storeManager.getItem(itemIndex).Name);
            }

            updateGUI();
            mainForm.UpdateGUI();
        }

        /// <summary>
        /// Event Handler. Handles 'buy item 1' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void buy_btn_item_1_Click(object sender, EventArgs e)
        {
            int itemIndex = 1;

            if (storeManager.playerHasItem(gameManager.Player, itemIndex))
            {
                MessageBox.Show("You already have this item!", storeManager.getItem(itemIndex).Name);
                return;
            }

            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);

            if (!isPurchased)
                MessageBox.Show("Sorry, you don't have enough money to buy this article.", storeManager.getItem(itemIndex).Name + " purchase failed");
            else
                MessageBox.Show("Congratulations on your new purchase!", storeManager.getItem(itemIndex).Name);

            updateGUI();
            mainForm.UpdateGUI();
        }

        /// <summary>
        /// Event Handler.Handles 'buy item 2' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void buy_btn_item_2_Click(object sender, EventArgs e)
        {
            int itemIndex = 2;

            if (storeManager.playerHasItem(gameManager.Player, itemIndex))
            {
                MessageBox.Show("You already have this item!", storeManager.getItem(itemIndex).Name);
                return;
            }

            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased)
                MessageBox.Show("Sorry, you don't have enough money to buy this article.", storeManager.getItem(itemIndex).Name + " purchase failed");
            else
                MessageBox.Show("Congratulations on your new purchase!", storeManager.getItem(itemIndex).Name);

            updateGUI();
            mainForm.UpdateGUI();
        }

        /// <summary>
        /// Event Handler.Handles 'buy item 3' button-click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void buy_btn_item_3_Click(object sender, EventArgs e)
        {
            int itemIndex = 3;

            if (storeManager.playerHasItem(gameManager.Player, itemIndex))
            {
                MessageBox.Show("You already have this item!", storeManager.getItem(itemIndex).Name);
                return;
            }

            bool isPurchased = storeManager.attemptPurchase(gameManager.Player, itemIndex);
            if (!isPurchased)
                MessageBox.Show("Sorry, you don't have enough money to buy this article.", storeManager.getItem(itemIndex).Name + " purchase failed");
            else
                MessageBox.Show("Congratulations on your new purchase!", storeManager.getItem(itemIndex).Name);

            updateGUI();
            mainForm.UpdateGUI();
        }
    }
}
