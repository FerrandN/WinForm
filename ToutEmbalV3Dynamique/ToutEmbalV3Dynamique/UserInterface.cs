using UserControleProduction;

namespace ToutEmbalV3Dynamique
{
    public partial class ToutEmbal : Form
    {
        UserControleProduction.ProductionProgressBar productionProgressBar;
        int typeACount = 0;
        int typeBCount = 0;
        int typeCCount = 0;

        public ToutEmbal()
        {
            InitializeComponent();
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddTypeA_Click(object sender, EventArgs e)
        {
            ButtonClick("TypeA",typeACount++);
        }

        private void buttonAddTypeB_Click(object sender, EventArgs e)
        {
            ButtonClick("TypeB",typeBCount++);
        }

        private void buttonAddTypeC_Click(object sender, EventArgs e)
        {
            ButtonClick("TypeC",typeCCount++);
        }

        private void ButtonClick(string type, int count)
        {
            ProductionProgressBar u = new UserControleProduction.ProductionProgressBar(type, count);
            u.Dock = DockStyle.Top;
            panelDisplayProductionProgressBar.Controls.Add(u);
            u.BringToFront();

            AddItemInToolStrip(type, count, demarrerToolStripMenuItem);
            AddItemInToolStrip(type, count, arreterToolStripMenuItem);
            AddItemInToolStrip(type, count, continuerToolStripMenuItem);

            ProductionTabControle p = new ProductionTabControle();
            TabPage tp = new TabPage();
            tp.Controls.Add(p);
            tp.Text = type + " " + count.ToString();
            tabControlProduction.Controls.Add(tp);

            ProductionLights pr = new ProductionLights(type + " " + count.ToString());
            flowLayoutPanelChangeState.Controls.Add(pr);
        }

        private void AddItemInToolStrip(string s, int i, ToolStripMenuItem t)
        {
            ToolStripTextBox td = new ToolStripTextBox();
            td.Text = s + " " + i.ToString();
            t.DropDownItems.Add(td);
        }
    }
}