using Microsoft.EntityFrameworkCore;
using TrainingVSCodeDB.Models;

namespace TrainingVSCodeDB
{
    public partial class Form1 : Form
    {
        private TestForVisualStudioContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new TestForVisualStudioContext();
            dbContext.Games.Load();
            this.dataGridView1.DataSource = dbContext.Games.Local.ToBindingList();
            /*
            UpdateDevelloperName();
            UpdateGameTypeName();
            */
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Develloper gameToAdd = new Develloper();
            gameToAdd.DevName = textBoxDevelopperName.Text;
            dbContext.Devellopers.Add(gameToAdd);
            dbContext.SaveChanges();
            //UpdateDevelloperName();

            GameType typeToAdd = new GameType();
            typeToAdd.GameTypeName = textBoxTypeName.Text;
            dbContext.GameTypes.Add(typeToAdd);
            dbContext.SaveChanges();
            //UpdateGameTypeName();
        }
        /*
        private void UpdateDevelloperName()
        {
            comboBoxDevelloperName.Items.Clear();
            foreach (Develloper develloper in dbContext.Devellopers)
            {
                comboBoxDevelloperName.Items.Add(develloper.DevName);
            }
        }

        private void UpdateGameTypeName()
        {
            comboBoxGameType.Items.Clear();
            foreach (GameType gameType in dbContext.GameTypes)
            {
                comboBoxGameType.Items.Add(gameType.GameTypeName);
            }
        }
        */
    }
}