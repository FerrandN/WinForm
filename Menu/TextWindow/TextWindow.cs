namespace TextWindow
{
    public partial class TextWindow : Form
    {
        int radioButtonWindowCount = 0;
        public TextWindow()
        {
            InitializeComponent();
            
        }

        private void buttonTextWindowValidate_Click(object sender, EventArgs e)
        {
            Graphics_Object_Radio.CheckBox_RadioButon radioButon;
            radioButon = new Graphics_Object_Radio.CheckBox_RadioButon();
            radioButon.MdiParent = this.MdiParent;
            radioButtonWindowCount++;
            radioButon.textBoxTypeText.Text = textBox.Text;
            radioButon.Text += " n° " +radioButtonWindowCount;
            radioButon.Show();
        }
    }
}