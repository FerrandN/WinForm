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
    public partial class ProductionLights : UserControl
    {
        public ProductionLights(string name)
        {
            InitializeComponent();
            labelChangeStateName.Text = name;
        }
        
    }
}
