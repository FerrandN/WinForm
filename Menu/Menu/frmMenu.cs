using Emprunt;
using ListBoxOperation;

namespace Menu
{
    public partial class frmMenu : Form
    {

        int additionWindowCount = 0;
        int saisieWindowCount = 0;
        int checkBoxRadioWindowCount = 0;
        int listBoxWindowCount = 0;
        int comboBoxWindowCount = 0;
        int defilementWindowCount = 0;
        int empruntWindowCount = 0;
        public frmMenu()
        {
            InitializeComponent();
            toolStripLabelDate.Text = DateTime.Now.Date.ToString("dd:MM:yyyy");
        }

        private void sIdentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
                    IdentificationWindow.IdentificationWindow identification;
                    identification = new IdentificationWindow.IdentificationWindow();
                    identification.ShowDialog();
                    if (identification.DialogResult == DialogResult.OK)
                    {
                        phase1ToolStripMenuItem.Enabled = true;
                        phase2ToolStripMenuItem.Enabled = true;
                        phase3ToolStripMenuItem.Enabled = true;
                        fenetresToolStripMenuItem.Enabled = true;*/

        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsAppAddition.Form1 addition;
            addition = new WinFormsAppAddition.Form1();
            additionWindowCount++;
            addition.Text += " n� " + additionWindowCount;
            addition.MdiParent = this;
            addition.Show();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputCheck.ControlInput controlInput;
            controlInput = new InputCheck.ControlInput();
            saisieWindowCount++;
            controlInput.Text += " n� " + saisieWindowCount;
            controlInput.MdiParent = this;
            controlInput.Show();
        }

        private void checkBoxRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWindow.TextWindow textWindow = new TextWindow.TextWindow();
            checkBoxRadioWindowCount++;
            textWindow.Text += " n� " + checkBoxRadioWindowCount;
            textWindow.MdiParent = this;
            textWindow.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxEtComboBox.ListBoxComboBox listBox;
            listBox = new ListBoxEtComboBox.ListBoxComboBox();
            listBoxWindowCount++;
            listBox.Text += " n� " + listBoxWindowCount;
            listBox.MdiParent = this;
            listBox.Show();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxOperation.ListBoxOperation listBoxOperation;
            listBoxOperation = new ListBoxOperation.ListBoxOperation();
            comboBoxWindowCount++;
            listBoxOperation.Text += " n� " + comboBoxWindowCount;
            listBoxOperation.MdiParent = this;
            listBoxOperation.Show();
        }

        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComposantDeDefilement.ComposantDeDefilement defilement;
            defilement = new ComposantDeDefilement.ComposantDeDefilement();
            defilementWindowCount++;
            defilement.Text += " n� " + defilementWindowCount;
            defilement.MdiParent = this;
            defilement.Show();
        }

        private void empruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprunt.Emprunt emprunt;
            emprunt = new Emprunt.Emprunt();
            empruntWindowCount++;
            emprunt.Text += " n� " + empruntWindowCount;
            emprunt.MdiParent = this;
            emprunt.Show();
        }

        private void toolStripMenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Defilement_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}