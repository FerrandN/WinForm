namespace UserControleProduction
{
    public partial class ProductionProgressBar : UserControl
    {
        public ProductionProgressBar(string labelName, int count)
        {
            InitializeComponent();
            this.Name=this.labelType.Text = labelName + count.ToString(); ;
        }
    }
}