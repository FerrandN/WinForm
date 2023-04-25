using ECF_Blanc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF_Blanc
{
    public partial class WindowInfosGamesToAdd : Form
    {
        public WindowInfosGamesToAdd()
        {
            InitializeComponent();
        }


        public WindowInfosGamesToAdd(Game gameAModifier, TestForVisualStudioContext dbContext)
        {
            InitializeComponent();


            foreach (GameType gt in dbContext.GameTypes)
            {
                this.comboBoxGameType.Items.Add(gt.GameTypeName);
            }

            foreach (Develloper dev in dbContext.Devellopers)
            {
                this.comboBoxGameDev.Items.Add(dev.DevName);
            }

            comboBoxGameDev.SelectedIndex = gameAModifier.DevId;
            comboBoxGameType.SelectedIndex = gameAModifier.GameTypeId;
            textBoxGameName.Text = gameAModifier.GameName;

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
