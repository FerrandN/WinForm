using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF_Blanc2
{
    public partial class ModifyWindow : Form
    {
        public ModifyWindow()
        {
            InitializeComponent();
        }

        public ModifyWindow(string x, string y)
        {
            InitializeComponent();
            textBox1.Text = x;
            textBox2.Text = y;
        }

        public string TextBoxX 
        { 
            get { return textBox1.Text; } 
            set { textBox1.Text = value;}
        }

        public string TextBoxY
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
