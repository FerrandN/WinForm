using BDDTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BDDTest
{
    public partial class Form1 : Form
    {
        private CitiesContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new CitiesContext();
            dbContext.Cities.Load();
            this.dataGridView1.DataSource = dbContext.Cities.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityName = "test";
            city.CountryCode = "FR";

            dbContext.Cities.Add(city);

            dbContext.SaveChanges();
        }
    }
}