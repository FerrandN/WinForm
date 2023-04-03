

using ClassMetier;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class FormToutEmbal : Form
    {
        List<Production> productions = new List<Production>();
        Production A1 = new Production(10000, 0, 0, "A",1);
        Production B1 = new Production(25000, 0, 0, "B",5);
        Production C1 = new Production(120000, 0, 0, "C",10);

        public FormToutEmbal()
        {
            InitializeComponent();
            productions.Add(A1);
            productions.Add(B1);
            productions.Add(C1);

            A1.ProductionStateChanged += Production_ProductionStateChanged;
            B1.ProductionStateChanged += Production_ProductionStateChanged;
            C1.ProductionStateChanged += Production_ProductionStateChanged;

            progressBarTypeA.Maximum = A1.NbCrateToProduce;
            progressBarTypeB.Maximum = B1.NbCrateToProduce;
            progressBarTypeC.Maximum = C1.NbCrateToProduce;
        }

        private void Production_ProductionStateChanged(Production.EnumProductionState state, Production sender)
        {
            if(sender.Type == "A")
            {
                ChangerToolStrip(state,toolstrip_demarrer_a, toolstrip_arreter_a, toolstrip_continuer_a);
            }

            if(sender.Type == "B")
            {
                ChangerToolStrip(state, toolstrip_demarrer_b, toolstrip_arreter_b, toolstrip_continuer_b);
            }

            if(sender.Type == "C")
            {
                ChangerToolStrip(state, toolstrip_demarrer_c, toolstrip_arreter_c, toolstrip_continuer_c);
            }
        }

        private void ChangerToolStrip(Production.EnumProductionState e, ToolStripMenuItem start, ToolStripMenuItem stop, ToolStripMenuItem _continue)
        {
            start.Enabled = e == Production.EnumProductionState.NotStarted;
            _continue.Enabled = e == Production.EnumProductionState.Pause;
            stop.Enabled = e == Production.EnumProductionState.Started;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerProduction_Tick(object sender, EventArgs e)
        {
            foreach (Production prod in productions)
            {
                prod.AddCrate();
            }
            UpdateIHM();
        }

        private void UpdateIHM()
        {
            textBoxTypeANbCrate.Text = A1.NbCrateProduced.ToString();
            textBoxTypeBNbCrate.Text = B1.NbCrateProduced.ToString();
            textBoxTypeCNbCrate.Text = C1.NbCrateProduced.ToString();

            textBoxTypeADefectivePerHour.Text = A1.NbDefectiveSinceLastHour.ToString();
            textBoxTypeBDefectivePerHour.Text = B1.NbDefectiveSinceLastHour.ToString();
            textBoxTypeCDefectivePerHour.Text = C1.NbDefectiveSinceLastHour.ToString();

            textBoxTypeADefectiveTotal.Text = A1.NbDefectiveCrate.ToString();
            textBoxTypeBDefectiveTotal.Text = B1.NbDefectiveCrate.ToString();
            textBoxTypeCDefectiveTotal.Text = C1.NbDefectiveCrate.ToString();

            progressBarTypeA.Value = A1.NbCrateProduced;
            progressBarTypeB.Value = B1.NbCrateProduced;
            progressBarTypeC.Value = C1.NbCrateProduced;
        }

        private void toolstrip_demarrer_a_Click(object sender, EventArgs e)
        {
            A1.Start();
        }
        private void toolstrip_demarrer_b_Click(object sender, EventArgs e)
        {
            B1.Start();
        }
        private void toolstrip_demarrer_c_Click(object sender, EventArgs e)
        {
            C1.Start();
        }

        private void toolstrip_arreter_a_Click(object sender, EventArgs e)
        {
            A1.Pause();
        }
        private void toolstrip_arreter_b_Click(object sender, EventArgs e)
        {
            B1.Pause();
        }
        private void toolstrip_arreter_c_Click(object sender, EventArgs e)
        {
            C1.Pause();
        }

        private void toolstrip_continuer_a_Click(object sender, EventArgs e)
        {
            A1.Continue();
        }
        private void toolstrip_continuer_b_Click(object sender, EventArgs e)
        {
            B1.Continue();
        }
        private void toolstrip_continuer_c_Click(object sender, EventArgs e)
        {
            C1.Continue();
        }
    }
}