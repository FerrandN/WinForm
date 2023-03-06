namespace WinFormsAppAddition
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThatAdd0_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "0");
            numbers.Add(0);
            
        }

        private void buttonThatAdd1_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "1");
            numbers.Add(1);
        }

        private void buttonThatAdd2_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "2");
            numbers.Add(2);
        }

        private void buttonThatAdd3_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "3");
            numbers.Add(3);
        }

        private void buttonThatAdd4_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "4");
            numbers.Add(4);
        }

        private void buttonThatAdd5_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "5");
            numbers.Add(5);
        }

        private void buttonThatAdd6_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "6");
            numbers.Add(6);
        }

        private void buttonThatAdd7_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "7");
            numbers.Add(7);
        }

        private void buttonThatAdd8_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "8");
            numbers.Add(8);
        }

        private void buttonThatAdd9_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text += ((this.displayNumbersToAdd.Text != "" ? "+" : "") + "9");
            numbers.Add(9);
        }

        private void buttonThatCalculate_Click(object sender, EventArgs e)
        {
            int result = 0;
            foreach (int number in numbers)
            { result += number; }
            this.displayNumbersToAdd.Text += " = " + result;
            delete();
        }

        private void buttonThatClear_Click(object sender, EventArgs e)
        {
            this.displayNumbersToAdd.Text = "";
            delete();
        }

        private void delete()
        {
          numbers.Clear();
        }
    }
}