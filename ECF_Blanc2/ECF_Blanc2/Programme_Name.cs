using ECF_Blanc2.Models;
using Microsoft.EntityFrameworkCore;

namespace ECF_Blanc2
{
    public partial class Programme_Name : Form
    {
        private RobotContext dbContext = new RobotContext();
        public Programme_Name()
        {
            InitializeComponent();
            dbContext.Positions.Load();
            this.dataGridView1.DataSource = dbContext.Positions.Local.ToBindingList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!RobotAlreadyExist())
            {
                Position positionToAdd = new Position();
                positionToAdd.X = Int32.Parse(textBoxX.Text);
                positionToAdd.Y = Int32.Parse(textBoxY.Text);
                dbContext.Add(positionToAdd);
                dbContext.SaveChanges();
            }

            dataGridView1.Refresh();
        }

        private bool RobotAlreadyExist()
        {
            bool exist = false;
            foreach(Position p in dbContext.Positions)
            {
                if(textBoxX.Text == p.X.ToString() && textBoxY.Text == p.Y.ToString())
                {
                    exist = true;
                    return exist;
                }
            }
            return exist;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (RobotAlreadyExist())
            {
                int id = 0;
                foreach (Position p in dbContext.Positions)
                {
                    if (textBoxX.Text == p.X.ToString() && textBoxY.Text == p.Y.ToString())
                    {
                        id = p.RobotId;
                    }
                }
                ModifyWindow modifyWindow = new ModifyWindow(textBoxX.Text, textBoxY.Text);
                Position positionToModify = dbContext.Positions.Find(id);
                modifyWindow.ShowDialog();

                positionToModify.X = Int32.Parse(modifyWindow.TextBoxX);
                positionToModify.Y = Int32.Parse(modifyWindow.TextBoxY);

                dbContext.Update(positionToModify);
                dbContext.SaveChanges();
                dataGridView1.Refresh();
            }
        }
    }
}