using MyClassTest;

namespace WinFormsAppAddition
{
    public partial class Form1 : Form
    {
        Addition a;

        public Form1()
        {
            InitializeComponent();
            a = new Addition();
        }

        private void buttonThatAddNumber_Click(object sender, EventArgs e)
        {
            // add number from button, use tag as reference
            Button btn = sender as Button;
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + btn.Tag);
            a.AddNumbers(int.Parse((string)btn.Tag));
        }

        private void buttonThatAdd0_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThatAdd1_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd2_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd3_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd4_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd5_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd6_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd7_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd8_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatAdd9_Click(object sender, EventArgs e)
        {

        }

        private void buttonThatCalculate_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += "=" + a.CalculateResults();
            a.Reset();
        }

        private void buttonThatClear_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text = "";
            a.Reset();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}