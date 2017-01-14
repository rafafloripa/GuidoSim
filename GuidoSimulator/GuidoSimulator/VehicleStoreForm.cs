using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuidoSimulator
{
    public partial class VehicleStoreForm : GuidoSimulator.BaseStoreForm
    {

        public VehicleStoreForm(GameManager gameManager, StoreManager storeManager) : base(gameManager, storeManager)
        {
        }

        protected override void buy_btn_item_0_Click(object sender, EventArgs e)
        {
            base.
        }

        protected override void buy_btn_item_1_Click(object sender, EventArgs e)
        {
            if (Player.Money < 1000)
            {
                MessageBox.Show("Sorry, you don't have enough money for this!");
                return;
            }
            Player.Money -= 1000;
            Player.CurrentItemLevels[1] = 1;
            Player.VehicleImage = Properties.Resources.vehicle_level_1;
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
            Player.CurrentItemLevels[1] = 2;
            Player.VehicleImage = Properties.Resources.vehicle_level_2;
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
            Player.CurrentItemLevels[1] = 3;
            Player.VehicleImage = Properties.Resources.vehicle_level_3;
            MessageBox.Show("Purchase successful!");
            updateMoney();
            disableButtons();
            enableButtons();
        }
    }
}
