using Menu;
using System.Configuration;

namespace IdentificationWindow
{
    public partial class IdentificationWindow : Form
    {
        public IdentificationWindow()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Pizza" && textBoxPassWord.Text == "Castle")
            {
                /*this.DialogResult = DialogResult.Abort;*/
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}