namespace Form_AddNewGameToDB
{
    public partial class WindowInfosGamesToAdd : Form
    {
        public WindowInfosGamesToAdd()
        {
            InitializeComponent();
        }

        public WindowInfosGamesToAdd(int typeID, int devID, string gameName)
        {
            InitializeComponent();
            comboBoxGameDev.SelectedIndex = devID;
            comboBoxGameType.SelectedIndex = typeID;
            textBoxGameName.Text = gameName;

        }


        public WindowInfosGamesToAdd(Game gameAModifier )
        {
            InitializeComponent();
            comboBoxGameDev.SelectedIndex = devID;
            comboBoxGameType.SelectedIndex = typeID;
            textBoxGameName.Text = gameName;

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}