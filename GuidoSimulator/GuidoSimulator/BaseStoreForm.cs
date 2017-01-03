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
        Player player;
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        private BaseStoreForm()
        {
            player = null;
        }

        public BaseStoreForm(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        protected virtual void buy_btn_item_1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void buy_btn_item_2_Click(object sender, EventArgs e)
        {

        }

        protected virtual void buy_btn_item_3_Click(object sender, EventArgs e)
        {

        }

        protected virtual void buy_btn_item_0_Click(object sender, EventArgs e)
        {

        }
    }
}
