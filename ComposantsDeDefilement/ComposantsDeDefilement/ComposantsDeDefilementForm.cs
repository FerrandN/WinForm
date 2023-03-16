namespace ComposantsDeDefilement
{
    public partial class ComposantsDeDefilementForm : Form
    {
        public ComposantsDeDefilementForm()
        {
            InitializeComponent();
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRed.Value = e.NewValue;
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownGreen.Value = e.NewValue;
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBlue.Value = e.NewValue;
        }

        private void ChangeColor()
        {
            Color.FromArgb(255, 255, 255, 255);
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRed.Value = (int)numericUpDownRed.Value;
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarGreen.Value = (int)numericUpDownGreen.Value;
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBlue.Value = (int)numericUpDownBlue.Value;
        }

        private void hScrollBarRed_ValueChanged(object sender, EventArgs e)
        {
            labelRedColor.BackColor = Color.FromArgb(255, hScrollBarRed.Value, 0, 0);
            labelColor.BackColor = Color.FromArgb(255, hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
        }

        private void hScrollBarGreen_ValueChanged(object sender, EventArgs e)
        {
            labelGreenColor.BackColor = Color.FromArgb(255, 0, hScrollBarGreen.Value, 0);
            labelColor.BackColor = Color.FromArgb(255, hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
        }

        private void hScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            labelBlueColor.BackColor = Color.FromArgb(255, 0, 0, hScrollBarBlue.Value);
            labelColor.BackColor = Color.FromArgb(255, hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
        }
    }
}