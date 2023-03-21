using EmpruntLibrairies;
using System.Text.RegularExpressions;

namespace Emprunt
{
    public partial class Emprunt : Form
    {
        EmpruntCalcul calcul;
        EmpruntRegex regex = new EmpruntRegex();
        public Emprunt()
        {
            InitializeComponent();
            radioButtonSeven.Padding = new Padding((flowLayoutPanelRadioButtonPercent.Width / 2) - radioButtonSeven.Width/2, 0, 0, 0);
            radioButtonEight.Padding = new Padding((flowLayoutPanelRadioButtonPercent.Width / 2) - radioButtonEight.Width / 2, 0, 0, 0);
            radioButtonNine.Padding = new Padding((flowLayoutPanelRadioButtonPercent.Width / 2) - radioButtonNine.Width/ 2, 0, 0, 0);
            textBoxName.Focus();
            calcul = new EmpruntCalcul(1, 0.07, 0, 1);
        }

        private void listBoxMonthlyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = 0;
            switch (listBoxMonthlyType.SelectedIndex)
            {
                case 0:
                    val = 1;
                    break;

                case 1:
                    val = 2;
                    break;

                case 2:
                    val = 3;
                    break;

                case 3:
                    val = 6;
                    break;

                case 4:
                    val = 12;
                    break;
            }
            hScrollBarLoanDuration.SmallChange = val;
            calcul.MonthPeriod = val;
            RefreshHUD();
        }



        private void RefreshHUD()
        {
            labelNumberOfMonth.Text = calcul.CalculTotalRefundMonth().ToString();
            calcul.LoanPeriod = hScrollBarLoanDuration.Value;
            labelValue.Text = calcul.CalculLoanToRefund().ToString() + " €";
        }

        private void hScrollBarLoanDuration_Scroll(object sender, ScrollEventArgs e)
        {
            labelMonthDuration.Text = hScrollBarLoanDuration.Value.ToString();
            RefreshHUD();
        }

        private void radioButtonSeven_CheckedChanged(object sender, EventArgs e)
        {
            calcul.Interest = 0.07;
            RefreshHUD();
        }

        private void radioButtonEight_CheckedChanged(object sender, EventArgs e)
        {
            calcul.Interest = 0.08;
            RefreshHUD();
        }

        private void radioButtonNine_CheckedChanged(object sender, EventArgs e)
        {
            calcul.Interest = 0.09;
            RefreshHUD();
        }

        private string ControlOnlyDigit(string toControl)
        {
            Match match = Regex.Match(toControl, regex.patternOnlyDigit);
            if (Regex.IsMatch(toControl, regex.patternOnlyDigit))
            {
                return match.Value;
            }
            else
            {
                return "";
            }
        }

        private void numericUpDownLoanValue_ValueChanged(object sender, EventArgs e)
        {
            calcul.Loan = (double)numericUpDownLoanValue.Value;
            RefreshHUD();
        }
    }
}