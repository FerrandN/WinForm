using ECF_SPA.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace ECF_SPA
{
    public partial class FormChat : Form
    {
        private EcfSpaContext dbContext = new EcfSpaContext();
        Chat chatToModify;
        public FormChat()
        {
            InitializeComponent();
            dbContext.Chats.Load();

            foreach (Race race in dbContext.Races)
            {
                this.comboBoxRace.Items.Add(race.Race1);
            }
            chatToModify = dbContext.Chats.First();
            textBoxName.Text = chatToModify.Nom.ToString();
            textBoxPuce.Text = chatToModify.NumeroPuce.ToString();
            numericUpDownAge.Text = chatToModify.Age.ToString();
            comboBoxRace.SelectedIndex = chatToModify.Race-1;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            List<string> listRace = new List<string>();
            foreach(string s in comboBoxRace.Items)
            {
                listRace.Add(s);
            }
            if (CheckPuceIsCorrect() && NameIsCorrect() && AgeIsCorrect() && RaceDoesExist(listRace)
                && numericUpDownAge != null && textBoxName != null && textBoxPuce != null)
            {
                
                ClassChats copy = new ClassChats(chatToModify);

                foreach (string s in listRace)
                {
                    if (comboBoxRace.Text == s)
                    {
                        comboBoxRace.SelectedIndex = comboBoxRace.FindString(s);
                    }
                }

                copy.Age = Int32.Parse(numericUpDownAge.Text.ToString());
                copy.Nom = textBoxName.Text.ToString();
                copy.Race = comboBoxRace.SelectedIndex + 1;
                copy.hisRace = (ClassChats.EnumRaceDuChat)comboBoxRace.SelectedIndex;
                
                chatToModify.Age = copy.Age;
                chatToModify.Nom = copy.Nom;
                chatToModify.Race = copy.Race;
                


                dbContext.Chats.Update(chatToModify);
                dbContext.SaveChanges();
            }
        }

        private bool CheckPuceIsCorrect()
        {
            Regex rg = new Regex(@"^25026[\d]{2}[\d]{8}$");
            Match match = rg.Match(textBoxPuce.Text);

            if(match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NameIsCorrect()
        {
            Regex rg = new Regex(@"^[A-z]*$");
            Match match = rg.Match(textBoxName.Text);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AgeIsCorrect()
        {
            Regex rg = new Regex(@"^[0-9]*$");
            Match match = rg.Match(numericUpDownAge.Text);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RaceDoesExist(List<string> race)
        {
            foreach(string s in race)
            {
                if(comboBoxRace.Text == s)
                {
                    return true;
                }
            }
            return false;
        }
    }
}