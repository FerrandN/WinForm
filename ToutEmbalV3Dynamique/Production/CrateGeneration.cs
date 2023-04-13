namespace Production
{
    public class CrateGeneration
    {
        int crateProduced = 0;
        int defectiveCrate = 0;
        Random number = new Random();
        List<DateTime> defectiveTime = new List<DateTime>();

        public CrateGeneration()
        {

        }
        public int CrateProduced
        {
            get { return crateProduced; }
        }

        public int DefectiveCrate
        {
            get { return defectiveCrate; }
        }

        public void CreateCrate()
        {
            if(number.Next() == 0)
            {
                defectiveCrate++;
                defectiveTime.Add(DateTime.Now);
            }
            else
            {
                crateProduced++;
            }
        }

        public void DeleteOldDefectiveTime()
        {
            foreach(DateTime t in defectiveTime)
            {
                if(t > DateTime.Now.AddHours(-1))
                {
                    defectiveTime.Remove(t);
                }
                else
                {
                    return;
                }
            }
        }
    }
}