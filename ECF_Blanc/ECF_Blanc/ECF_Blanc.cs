using ECF_Blanc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ECF_Blanc
{
    public partial class ECF_Blanc : Form
    {
        private TestForVisualStudioContext dbContext = new TestForVisualStudioContext();
        public ECF_Blanc()
        {
            InitializeComponent();
            dbContext.Games.Load();
            this.dataGridView1.DataSource = dbContext.Games.Local.ToBindingList();
        }

        public DbContext DbContext { get { return dbContext; } }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            WindowInfosGamesToAdd toAdd = new WindowInfosGamesToAdd();

            foreach(GameType gt in dbContext.GameTypes)
            {
                toAdd.comboBoxGameType.Items.Add(gt.GameTypeName);
            }

            foreach (Develloper dev in dbContext.Devellopers)
            {
                toAdd.comboBoxGameDev.Items.Add(dev.DevName);
            }

            toAdd.ShowDialog();
            // -- A LA FERMETURE DE LA FENETRE
            game.GameName = toAdd.textBoxGameName.Text;

            string devName = (string)toAdd.comboBoxGameDev.SelectedItem;
            Develloper devnew = dbContext.Devellopers.First(x => x.DevName == devName);

            string gameType = (string)toAdd.comboBoxGameType.SelectedItem;
            GameType gtnew = dbContext.GameTypes.First(x => x.GameTypeName == gameType);

            game.GameType = gtnew;
            game.Dev = devnew;

            dbContext.Games.Add(game);
            dbContext.SaveChanges();

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)this.dataGridView1.CurrentRow.Cells[0].Value;

            Game game = dbContext.Games.Find(id);
            WindowInfosGamesToAdd toAdd = new WindowInfosGamesToAdd(game, dbContext);

            toAdd.ShowDialog();
            // -- A LA FERMETURE DE LA FENETRE
            game.GameName = toAdd.textBoxGameName.Text;

            string devName = (string)toAdd.comboBoxGameDev.SelectedItem;
            Develloper devnew = dbContext.Devellopers.First(x => x.DevName == devName);

            string gameType = (string)toAdd.comboBoxGameType.SelectedItem;
            GameType gtnew = dbContext.GameTypes.First(x => x.GameTypeName == gameType);

            game.GameType = gtnew;
            game.Dev = devnew;

            dbContext.Games.Update(game);
            dbContext.SaveChanges();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}