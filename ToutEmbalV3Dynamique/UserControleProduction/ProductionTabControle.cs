using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControleProduction
{
    public partial class ProductionTabControle : UserControl
    {

        public String CrateProducedText { get => textBoxCrateProduced.Text; set => textBoxCrateProduced.Text = value; }
        public ProductionTabControle()
        {
            InitializeComponent();
        }
    }
}
