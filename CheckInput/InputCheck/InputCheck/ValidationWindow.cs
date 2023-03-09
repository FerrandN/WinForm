using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputCheck
{
    public partial class ValidationWindow : Form
    {
        string nom;
        string cp;
        string dateTime;
        string montant;
        public ValidationWindow(string boxNom, string boxCP, string boxDateTime, string boxMontant)
        {
            InitializeComponent();
            nom = boxNom;
            cp = boxCP;
            dateTime = boxDateTime;
            montant = boxMontant;
            this.labelMontant.Text += boxMontant;
            this.labelNom.Text += boxNom;
            this.labelDate.Text += boxDateTime;
            this.labelCodePostale.Text += boxCP;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
