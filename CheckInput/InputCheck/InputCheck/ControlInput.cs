using static InputCheck.VerifierSaisie;

namespace InputCheck
{
    public partial class ControlInput : Form
    {
        public ControlInput()
        {
            InitializeComponent();
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
                if(TextBoxNomMax30CHARAndOnlyAlphabetique(this.textBoxNom.Text) == false)
                {
                    errorProviderTextBoxName.SetError(textBoxNom, "Merci d'entr�e un nom de moin de 30 characteres");
                }
                else
                {
                    errorProviderTextBoxName.SetError(textBoxNom, "");
                }
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxDateTimeControleValidDateFromFormatProvider(this.textBoxDateTime.Text) == false)
            {
                errorProviderTextBoxDate.SetError(textBoxDateTime, "Merci d'entr�e une Date");
            }
            else
            {
                errorProviderTextBoxDate.SetError(textBoxDateTime, "");
            }
        }

        private void TextBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxMontantDigitDotMaxTwoDigit(this.textBoxMontant.Text) == false)
            {
                errorProviderTextBoxMontant.SetError(textBoxMontant, "Merci d'entr�e une valeur et de s�parer les centimes avec une virgule");
            }
            else
            {
                errorProviderTextBoxMontant.SetError(textBoxMontant, "");
            }
        }

        private void TextBoxCodePostale_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxCodePostaleMax5Digit(this.textBoxCodePostale.Text) == false)
            {
                errorProviderCodePostale.SetError(textBoxCodePostale, "Merci d'entr�e un code postale compos� de 5 chiffres");
            }
            else
            {
                errorProviderCodePostale.SetError(textBoxCodePostale, "");
            }
        }

        private void ClearAllText(object sender, EventArgs e)
        {
            textBoxCodePostale.Clear();
            textBoxDateTime.Clear();
            textBoxMontant.Clear();
            textBoxNom.Clear();
        }

        private void ValidateAll(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (TextBoxCodePostaleMax5Digit(this.textBoxCodePostale.Text)
         && TextBoxMontantDigitDotMaxTwoDigit(this.textBoxMontant.Text)
         && TextBoxDateTimeControleValidDateFromFormatProvider(this.textBoxDateTime.Text)
         && TextBoxNomMax30CHARAndOnlyAlphabetique(this.textBoxNom.Text))
            {
                ValidationWindow w = new ValidationWindow(this.textBoxNom.Text, this.textBoxCodePostale.Text, this.textBoxDateTime.Text, this.textBoxMontant.Text);
                w.ShowDialog();
            }
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent.Equals(null))
            {
                DialogResult msgbx = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (msgbx == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}