namespace Graphics_Object_Radio
{
    public partial class CheckBox_RadioButon : Form
    {
        public CheckBox_RadioButon()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTextTyped_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTypeText_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscules.Checked)
                labelToCopyTo.Text = textBoxTypeText.Text.ToUpper();

            else if (radioButtonMinuscules.Checked)
                labelToCopyTo.Text = textBoxTypeText.Text.ToLower();

            else
                labelToCopyTo.Text = textBoxTypeText.Text;

            if(textBoxTypeText.Text == "")
            {
                checkBoxCasse.Checked = false;
                checkBoxCouleurDuFond.Checked = false;
                checkBoxCouleurDesCaracteres.Checked = false;
            }
        }

        private void checkBoxCouleurDuFond_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckBoxCouleurFond();
        }

        private void checkBoxCouleurDesCaractères_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckBoxCouleurDesCaracteres();
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            changeCheckBoxCasse();
        }

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.BackColor = Color.Red;
        }

        private void CheckBox_RadioButon_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.BackColor = Color.Green;
        }

        private void radioButtonBleu_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.BackColor = Color.Blue;
        }

        private void radioButtonChoixRouge_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.ForeColor = Color.Red;
        }

        private void radioButtonBlanc_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.ForeColor = Color.White;
        }

        private void radioButtonNoir_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.ForeColor = Color.Black;
        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.Text = textBoxTypeText.Text.ToLower();
        }

        private void radioButtonMajuscules_CheckedChanged(object sender, EventArgs e)
        {
            labelToCopyTo.Text = textBoxTypeText.Text.ToUpper();
        }

        private void changeCheckBoxCouleurFond()
        {
            if (checkBoxCouleurDuFond.Checked)
            {
                this.flowLayoutPanel1.Enabled = true;
            }
            else
            {
                this.flowLayoutPanel1.Enabled = false;
                this.radioButtonFondRouge.Checked = false;
                this.radioButtonVert.Checked = false;
                this.radioButtonBleu.Checked = false;
                this.labelToCopyTo.BackColor = Color.Transparent;
            }
        }

        private void changeCheckBoxCouleurDesCaracteres()
        {
            if (checkBoxCouleurDesCaracteres.Checked)
            {
                this.flowLayoutPanel2.Enabled = true;
            }
            else
            {
                this.flowLayoutPanel2.Enabled = false;
                this.radioButtonChoixRouge.Checked = false;
                this.radioButtonBlanc.Checked = false;
                this.radioButtonNoir.Checked = false;
                this.labelToCopyTo.ForeColor = Color.Black;
            }
        }

        private void changeCheckBoxCasse()
        {
            if (checkBoxCasse.Checked)
            {
                this.flowLayoutPanel3.Enabled = true;
            }
            else
            {
                this.flowLayoutPanel3.Enabled = false;
                if (radioButtonMajuscules.Checked)
                {
                    radioButtonMajuscules.Checked = false;
                }
                if (radioButtonMinuscules.Checked)
                {
                    radioButtonMinuscules.Checked = false;
                }
                labelToCopyTo.Text = textBoxTypeText.Text;
            }
        }
    }
}