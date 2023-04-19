using Production;
using UserControleProduction;
using static Production.CrateGeneration;

namespace ToutEmbalV3Dynamique
{
    public partial class ToutEmbal : Form
    {
        UserControleProduction.ProductionProgressBar productionProgressBar;
        Dictionary<CrateGeneration.EnumTypeProduction, int> nbProductions;
        List<CrateGeneration> productions = new List<CrateGeneration>();
        public ToutEmbal()
        {
            InitializeComponent();
            nbProductions = new Dictionary<CrateGeneration.EnumTypeProduction, int>();
            List<CrateGeneration.EnumTypeProduction> vitessesPossibles = Enum.GetValues(typeof(CrateGeneration.EnumTypeProduction)).Cast<CrateGeneration.EnumTypeProduction>().ToList();
            foreach (CrateGeneration.EnumTypeProduction v in vitessesPossibles)
            {
                nbProductions.Add(v, 0);
            }
        }

        private void StateChanged(CrateGeneration sender)
        {
            foreach (ProductionLights c in flowLayoutPanelChangeState.Controls.OfType<ProductionLights>())
            {
                if (((CrateGeneration)c.Tag).ID == sender.ID)
                {
                    if (InvokeRequired)
                    {
                        this.Invoke(() =>
                        {
                            c.StartButtonEnable = sender.ActualState == CrateGeneration.EnumState.NotStarted;
                            c.ContinueButonEnable = sender.ActualState == CrateGeneration.EnumState.Paused;
                            c.StopButtonEnable = sender.ActualState == CrateGeneration.EnumState.Started;
                        });
                    }
                    else
                    {
                        c.StartButtonEnable = sender.ActualState == CrateGeneration.EnumState.NotStarted;
                        c.ContinueButonEnable = sender.ActualState == CrateGeneration.EnumState.Paused;
                        c.StopButtonEnable = sender.ActualState == CrateGeneration.EnumState.Started;
                    }
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductionChanged(CrateGeneration sender)
        {
            foreach (TabPage t in tabControlProduction.Controls.OfType<TabPage>())
            {
                foreach (ProductionTabControle c in t.Controls.OfType<ProductionTabControle>())
                {
                    if (((CrateGeneration)c.Tag).ID == sender.ID)
                    {
                        this.Invoke(() =>
                        {
                            c.CrateProducedText = sender.CrateProduced.ToString();
                        });
                    }
                }
            }
        }

        private void buttonAddTypeA_Click(object sender, EventArgs e)
        {
            CreateNewProduction(CrateGeneration.EnumTypeProduction.TYPE_A);
        }

        private void buttonAddTypeB_Click(object sender, EventArgs e)
        {
            CreateNewProduction(CrateGeneration.EnumTypeProduction.TYPE_B);
        }

        private void buttonAddTypeC_Click(object sender, EventArgs e)
        {
            CreateNewProduction(CrateGeneration.EnumTypeProduction.TYPE_C);
        }


        private void AddItemInToolStrip(string s, int i, ToolStripMenuItem t)
        {
            ToolStripTextBox td = new ToolStripTextBox();
            td.Text = s + " " + i.ToString();
            t.DropDownItems.Add(td);
        }

        private void CreateNewProduction(CrateGeneration.EnumTypeProduction type)
        {
            CrateGeneration cg = new CrateGeneration(type);
            productions.Add(cg);
            nbProductions[type]++;
            cg.stateChanged += StateChanged;
            cg.OnCreateProduced += ProductionChanged;
            AddProgressBar(cg);
            AddToolStripItem(cg);
            AddUserControlTabControl(cg);
            AddUserControlLight(cg);
        }

        private void AddProgressBar(CrateGeneration cg)
        {
            ProductionProgressBar u = new UserControleProduction.ProductionProgressBar(cg.Type.ToString(), nbProductions[cg.Type]);
            u.Dock = DockStyle.Top;
            panelDisplayProductionProgressBar.Controls.Add(u);
            u.BringToFront();
        }

        private void AddToolStripItem(CrateGeneration cg)
        {
            string type = cg.Type.ToString();
            int count = nbProductions[cg.Type];
            AddItemInToolStrip(type, count, demarrerToolStripMenuItem);
            AddItemInToolStrip(type, count, arreterToolStripMenuItem);
            AddItemInToolStrip(type, count, continuerToolStripMenuItem);
        }

        private void AddUserControlTabControl(CrateGeneration cg)
        {
            ProductionTabControle p = new ProductionTabControle();
            p.Tag = cg;
            TabPage tp = new TabPage();
            tp.Controls.Add(p);
            tp.Text = cg.Type.ToString() + " " + nbProductions[cg.Type].ToString();
            tabControlProduction.Controls.Add(tp);
        }

        private void AddUserControlLight(CrateGeneration cg)
        {
            ProductionLights pr = new ProductionLights(cg.Type.ToString() + " " + nbProductions[cg.Type].ToString());
            pr.Tag = cg;
            pr.StartButtonClick += new EventHandler((s, e) => cg.Start());
            pr.StopButtonClick += new EventHandler((s, e) => cg.Stop());
            pr.ContinueButtonClick += new EventHandler((s, e) => cg.Continue());
            flowLayoutPanelChangeState.Controls.Add(pr);
        }
    }
}