using System.Drawing;

namespace ComposantDeDefilement
{
    public partial class ComposantDeDefilement : Form
    {
        Color myColor;
        public ComposantDeDefilement()
        {
            InitializeComponent();
            myColor = Color.FromArgb(50, 50, 50);
            UpdateHUD();
        }

        private void UpdateHUD()
        {
            hScrollBarRed.Value = myColor.R;
            hScrollBarGreen.Value = myColor.G;
            hScrollBarBlue.Value = myColor.B;
            labelBlueColor.BackColor = Color.FromArgb(0, 0, myColor.B);
            labelGreenColor.BackColor = Color.FromArgb(0, myColor.G, 0);
            labelRedColor.BackColor = Color.FromArgb(myColor.R, 0, 0);
            labelFinalColor.BackColor = myColor;
            numericUpDownBlue.Value = hScrollBarBlue.Value;
            numericUpDownGreen.Value = hScrollBarGreen.Value;
            numericUpDownRed.Value = hScrollBarRed.Value;
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            UpdateHUD();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            UpdateHUD();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            UpdateHUD();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            UpdateHUD();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            UpdateHUD();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);
            UpdateHUD();
        }
    }
}