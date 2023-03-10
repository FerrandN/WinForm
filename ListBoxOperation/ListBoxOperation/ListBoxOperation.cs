using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ListBoxOperation
{
    public partial class ListBoxOperation : Form
    {
        public ListBoxOperation()
        {
            InitializeComponent();
        }



        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            controlInputToAddToList();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            ControlIfInputIsValidForButtonIndex();
        }

        private bool ControlOnlyDigit(string toTest)
        {
            Regex onlyDigit = new Regex("[^\\d]+");
            return onlyDigit.IsMatch(toTest);

        }

        private void buttonViderlaListe_Click(object sender, EventArgs e)
        {
            listBoxLstListe.Items.Clear();
        }

        private void textBoxNouvelElement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                controlInputToAddToList();
            }
        }

        private void controlInputToAddToList()
        {
            textBoxNouvelElement.Text = textBoxNouvelElement.Text.Trim();
            if (listBoxLstListe.Items.Contains(textBoxNouvelElement.Text) || textBoxNouvelElement.Text == "")
            {
                textBoxNouvelElement.Clear();
                IndexElementDigitError.SetError(this.textBoxNouvelElement, "C'est pas gentil de faire buguer mon programme Sophie ;-(");
            }
            else
            {
                listBoxLstListe.Items.Add(textBoxNouvelElement.Text);
                textBoxNouvelElement.Clear();
                textBoxNouvelElement.Focus();
                IndexElementDigitError.Clear();
                textBoxItemsCount.Text = Convert.ToString(listBoxLstListe.Items.Count);
            }
        }

        private void listBoxLstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = Convert.ToString(listBoxLstListe.SelectedIndex);
            textBoxText.Text = listBoxLstListe.Text;
        }

        private void textBoxIndexElement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ControlIfInputIsValidForButtonIndex();
            }
        }

        private void ControlIfInputIsValidForButtonIndex()
        {
            if (ControlOnlyDigit(textBoxIndexElement.Text) == true)
            {
                IndexElementDigitError.SetError(this.textBoxIndexElement, "Invalid input, Please enter only digit");
            }
            else
            {
                int textBoxValue = Convert.ToInt32(textBoxIndexElement.Text);
                if (textBoxValue < listBoxLstListe.Items.Count)
                {
                    listBoxLstListe.Focus();
                    listBoxLstListe.SelectedIndex = textBoxValue;
                    IndexElementDigitError.Clear();
                    textBoxIndexElement.Clear();
                    textBoxSelectedIndex.Focus();
                }
                else
                {
                    IndexElementDigitError.SetError(this.textBoxIndexElement, "Invalid input, Please enter a number equals to the index you want to access");
                }
            }
        }
    }
}
