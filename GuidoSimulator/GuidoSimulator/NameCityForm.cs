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
    public partial class NameCityForm : Form
    {
        public NameCityForm(string title, string question, string content)
        {
            InitializeComponent();
            this.Text = title;
            this.label_question.Text = question;
            this.textBox_nameCity.Text = content;
        }

        public string Value
        {
            get { return textBox_nameCity.Text; }
        }

    }
}
