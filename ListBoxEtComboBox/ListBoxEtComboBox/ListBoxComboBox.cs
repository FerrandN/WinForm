using ClassLibrarySelectedList;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace ListBoxEtComboBox
{
    public partial class ListBoxComboBox : Form
    {
        Countries countries = new Countries();
        
        public ListBoxComboBox()
        {
            InitializeComponent();
            foreach(string country in countries.country.Keys)
            {
                comboBoxCountries.Items.Add(country);
            }
        }

        private void comboBoxCountries_KeyDown(object sender, KeyEventArgs e)
        {
            if (StringControl(comboBoxCountries.Text))
            {
                if (e.KeyCode == Keys.Enter && !countries.CheckIfCountryIsAlreadyInList(comboBoxCountries.Text) && comboBoxCountries.Text != null)
                {
                    countries.AddCountry(comboBoxCountries.Text);
                    comboBoxCountries.Items.Add(comboBoxCountries.Text);
                    comboBoxCountries.SelectedIndex = comboBoxCountries.Items.Count - 1;
                    comboBoxCountries.Text = null;
                }
            }
        }

        private void comboBoxCountries_DropDown(object sender, EventArgs e)
        {
            if (StringControl(comboBoxCountries.Text))
            {
                if (!countries.CheckIfCountryIsAlreadyInList(comboBoxCountries.Text) && comboBoxCountries.Text != null)
                {
                    countries.AddCountry(comboBoxCountries.Text);
                    comboBoxCountries.Items.Add(comboBoxCountries.Text);
                    comboBoxCountries.SelectedIndex = comboBoxCountries.Items.Count -1;
                    comboBoxCountries.Text = null;
                }
            }
            comboBoxCountries.Text = null;
        }

        private void buttonToRight_Click(object sender, EventArgs e)
        {
            if (StringControl(comboBoxCountries.Text))
            {
                countries.SelectCountry(comboBoxCountries.Text);
                if (!listBoxSelectedCountries.Items.Contains(comboBoxCountries.Text))
                {
                    listBoxSelectedCountries.Items.Add(comboBoxCountries.Text);
                    comboBoxCountries.Items.Remove(comboBoxCountries.Text);
                    buttonToRight.Enabled = false;
                    if(comboBoxCountries.Items.Count <= 0)
                    {
                        buttonAllToRight.Enabled = false;
                    }
                }
                if(listBoxSelectedCountries.Items.Count >= 2)
                {
                    buttonNextUp.Enabled = true;
                    buttonNextDown.Enabled = true;
                }
            }
            comboBoxCountries.Text = null;
            buttonAllToLeft.Enabled = true;
        }

        private void buttonAllToRight_Click(object sender, EventArgs e)
        {
            countries.SelectAllCountry();
            foreach (string countryName in countries.country.Keys)
            {
                if (!listBoxSelectedCountries.Items.Contains(countryName) && StringControl(countryName))
                {
                    listBoxSelectedCountries.Items.Add(countryName);
                }
            }
            if (listBoxSelectedCountries.Items.Count <= 0)
            {
                buttonAllToRight.Enabled = false;
            }
            comboBoxCountries.Items.Clear();
            buttonAllToRight.Enabled = false;
            buttonAllToLeft.Enabled = true;
        }

        
        private void buttonToLeft_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCountries.SelectedItem != null && StringControl(listBoxSelectedCountries.SelectedItem.ToString()))
            {
                countries.UnSelectCountry(comboBoxCountries.Text);
                if (!comboBoxCountries.Items.Contains(listBoxSelectedCountries.Text))
                {
                    comboBoxCountries.Items.Add(listBoxSelectedCountries.Text);
                    listBoxSelectedCountries.Items.Remove(listBoxSelectedCountries.Text);
                    buttonToLeft.Enabled = false;
                    if (listBoxSelectedCountries.Items.Count <= 0)
                    {
                        buttonAllToLeft.Enabled = false;
                    }
                }
            }
            buttonAllToRight.Enabled = true;
            if (listBoxSelectedCountries.Items.Count > 0)
            {
                listBoxSelectedCountries.SelectedItem = listBoxSelectedCountries.Items[0];
            }
        }

        private void buttonAllToLeft_Click(object sender, EventArgs e)
        {
            countries.UnSelectAllCountry();
            foreach (string countryName in countries.country.Keys)
            {
                if (!comboBoxCountries.Items.Contains(countryName) && StringControl(countryName))
                {
                    comboBoxCountries.Items.Add(countryName);
                }
            }
            listBoxSelectedCountries.Items.Clear();
            buttonAllToLeft.Enabled = false;
            buttonToLeft.Enabled = false;
            buttonAllToRight.Enabled = true;
            buttonNextUp.Enabled = false;
            buttonNextDown.Enabled = false;
        }

        private bool StringControl(string s)
        {
            s = s.Trim();
            Regex rx = new Regex("^[A-z]+(?:[-][A-z]+)?$");
            MatchCollection matches = rx.Matches(s);
            return (matches.Count > 0);
        }

        private void buttonNextUp_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(listBoxSelectedCountries ,- 1);
        }

        private void buttonNextDown_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(listBoxSelectedCountries ,1);
        }

        public void MoveSelectedItem(ListBox listbox ,int direction)
        {
            if(listbox.SelectedItem == null || listbox.SelectedIndex <0)
            {
                return;
            }

            int newIndex = listbox.SelectedIndex + direction;

            if(newIndex < 0 || newIndex >= listbox.Items.Count)
            {
                return;
            }

            object selected = listbox.SelectedItem;

            listbox.Items.Remove(selected);
            listbox.Items.Insert(newIndex, selected);
            listbox.SetSelected(newIndex, true);
        }

        private void comboBoxCountries_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxCountries.Text.Count() > 0)
            {
                buttonToRight.Enabled = true;
            }
            else
            {
                buttonToRight.Enabled = false;
            }
        }

        private void listBoxSelectedCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxSelectedCountries.SelectedIndex != null)
            {
                buttonToLeft.Enabled = true;
            }
            if (listBoxSelectedCountries.Items.Count >= 2)
            {
                buttonNextUp.Enabled = true;
                buttonNextDown.Enabled = true;
            }
        }

        private void listBoxSelectedCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxSelectedCountries.Items.Count >= 2)
            {
                buttonNextUp.Enabled = true;
                buttonNextDown.Enabled = true;
            }
            else
            {
                buttonNextUp.Enabled = false;
                buttonNextDown.Enabled = false;
            }
        }
    }
}