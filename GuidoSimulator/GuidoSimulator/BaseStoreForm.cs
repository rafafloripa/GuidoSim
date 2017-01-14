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

        Player player;
        public Player Player
            //**************
        {
            get { return player; }
            set { player = value; }
        }

        // *** Do we need to InitializeComponent() here??? ***
        private BaseStoreForm()
        {
            player = null;
        }

        // *** Deprecated ****
        public BaseStoreForm(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        public BaseStoreForm(GameManager gameManager)
        {
            InitializeComponent();
            this.gameManager = gameManager;
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
