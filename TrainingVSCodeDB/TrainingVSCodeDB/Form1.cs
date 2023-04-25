using Microsoft.EntityFrameworkCore;
using System.Linq;
using TrainingVSCodeDB.Models;

namespace TrainingVSCodeDB
{
    public partial class Form1 : Form
    {
        private TestForVisualStudioContext dbContext;
        Dictionary<TextBox, bool> dictionaryOfTextBoxWithValue = new Dictionary<TextBox, bool>();
        public Form1()
        {
            InitializeComponent();
            dbContext = new TestForVisualStudioContext();
            dbContext.Games.Load();
            this.dataGridView1.DataSource = dbContext.Games.Local.ToBindingList();
            UpdateIHM();

            dictionaryOfTextBoxWithValue.Add(textBoxDevelopperName, false);
            dictionaryOfTextBoxWithValue.Add(textBoxGameToChange, false);
            dictionaryOfTextBoxWithValue.Add(textBoxTypeName, false);
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDevelopperName.Text != String.Empty)
            {

                Develloper devToAdd = new Develloper();
                devToAdd.DevName = textBoxDevelopperName.Text;
                if (!comboBoxDevelloperName.Items.Contains(devToAdd.DevName))
                {
                    dbContext.Devellopers.Add(devToAdd);
                    dbContext.SaveChanges();
                    UpdateDevelloperName();
                }
            }

            if (textBoxTypeName.Text != String.Empty)
            {
                GameType typeToAdd = new GameType();
                typeToAdd.GameTypeName = textBoxTypeName.Text;
                if (!comboBoxGameType.Items.Contains(typeToAdd.GameTypeName))
                {
                    dbContext.GameTypes.Add(typeToAdd);
                    dbContext.SaveChanges();
                    UpdateGameTypeName();
                }

            }

            if(textBoxGameName.Text != string.Empty && 
                comboBoxDevelloperName.SelectedItem != null && 
                comboBoxGameType.SelectedItem != null)
            {
                Game newGame = new Game();
                newGame.GameName = textBoxGameName.Text;

                string devName = (string)comboBoxDevelloperName.SelectedItem;
                Develloper dev = dbContext.Devellopers.First(x => x.DevName == devName);

                string gameType = (string)comboBoxGameType.SelectedItem;
                GameType gt = dbContext.GameTypes.First(x => x.GameTypeName == gameType);

                newGame.DevId = dev.DevId;
                newGame.GameTypeId = gt.GameTypeId;
                newGame.Dev = dev;
                newGame.GameType = gt;
                
                dbContext.Add(newGame);
                dbContext.SaveChanges();
                dataGridView1.Refresh();
            }
        }

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

        private void UpdateIHM()
        {
            UpdateGameTypeName();
            UpdateDevelloperName();
            dataGridView1.Refresh();
        }

        private void ChangeButtonState(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if(t.Text != String.Empty)
            {
                dictionaryOfTextBoxWithValue[t] = true;
                EnableAllButton();
            }
            else if(t.Text == String.Empty)
            {
                dictionaryOfTextBoxWithValue[t] = false;
                bool atLeastOneAsText = false;
                foreach (KeyValuePair<TextBox,bool> textBoxWithValue in dictionaryOfTextBoxWithValue)
                {
                    if(textBoxWithValue.Value == true)
                        atLeastOneAsText = true;
                }
                if(atLeastOneAsText)
                {
                    EnableAllButton();
                }
                else
                {
                    DisableAllButton();
                }
            }
            
        }

        private void EnableAllButton()
        {
            buttonAdd.Enabled = true;
            buttonChange.Enabled = true;
            buttonSup.Enabled = true;
        }
        private void DisableAllButton()
        {
            buttonAdd.Enabled = false;
            buttonChange.Enabled = false;
            buttonSup.Enabled = false;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxGameToChange.Text != String.Empty)
            {
                List<Game> games = dbContext.Games.Where(c => c.GameName == textBoxGameName.Text).ToList();
                foreach (Game game in games)
                {
                    game.GameName = textBoxGameToChange.Text;
                }
                if (games.Count > 0)
                    dbContext.SaveChanges();
            }
            UpdateIHM();
        }

        private void buttonSup_Click(object sender, EventArgs e)
        {
            if (textBoxGameName.Text != String.Empty)
            {
                List<Game> games = dbContext.Games.Where(c => c.GameName == textBoxGameName.Text).ToList();
                foreach (Game game in games)
                {
                    dbContext.Games.Remove(game);
                }
                if (games.Count > 0)
                    dbContext.SaveChanges();
            }
            UpdateIHM();
        }
    }
}