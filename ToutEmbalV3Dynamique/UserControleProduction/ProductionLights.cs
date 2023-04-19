using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControleProduction
{
    public partial class ProductionLights : UserControl
    {
        public event EventHandler StartButtonClick;
        public event EventHandler StopButtonClick;
        public event EventHandler ContinueButtonClick;

        public bool StartButtonEnable { get => button1.Enabled; set => button1.Enabled = value; }
        public bool ContinueButonEnable { get => button2.Enabled; set => button2.Enabled = value; }
        public bool StopButtonEnable { get => button3.Enabled; set => button3.Enabled = value; }
        public ProductionLights(string name)
        {
            InitializeComponent();
            labelChangeStateName.Text = name;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button send = sender as Button;
            string tagName = (string)send.Tag;
            switch (tagName)
            {
                case "Demarrer":
                    if (StartButtonClick != null)
                        StartButtonClick(sender, e);
                    break;
                case "Arreter":
                    if (StopButtonClick != null)
                        StopButtonClick(sender, e);
                    break;
                case "Continuer":
                    if (ContinueButtonClick != null)
                        ContinueButtonClick(sender, e);
                    break;
            }
        }
    }
}
