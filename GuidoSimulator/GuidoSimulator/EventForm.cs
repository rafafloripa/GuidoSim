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
    public partial class EventForm : Form
    {
        private Event evt;

        public EventForm(Event evt)
        {
            InitializeComponent();

            this.evt = evt;
            InitializeGUI();
        }

        /// <summary>
        /// Initializes GUI controls to display the Event information.
        /// </summary>
        private void InitializeGUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = evt.Title;

            title_label.Text = evt.Title;
            description_label.Text = evt.Description;
            event_pictureBox.Image = evt.EventImage;
            effect_label.Text = evt.Effect.ToString();
        }
    }
}
