namespace Production
{
    public class CrateGeneration
    {
        int crateProduced = 0;
        int defectiveCrate = 0;
        EnumTypeProduction type;
        int maxCrates;
        private static int EntityCount = 1;
        int numberID;
        Random number = new Random();
        List<DateTime> defectiveTime = new List<DateTime>();
        EnumState actualState;
        public Thread productionThread;
        public enum EnumState
        {
            NotStarted,
            Started,
            Paused,
            Ended,
        }

        public enum EnumTypeProduction
        {
            TYPE_A = 1000,
            TYPE_B = 5000,
            TYPE_C = 10000,
        };

        public EnumTypeProduction Type { get => type;  }
        public EnumState ActualState { get => actualState; private set => ChangeState(value); }

        

        public event StateChanged stateChanged;
        public event OnCrateProduced OnCreateProduced;
        public delegate void StateChanged(CrateGeneration sender);
        public delegate void OnCrateProduced(CrateGeneration sender);


        private void ChangeState(EnumState newState)
        {
            if (newState == actualState)
                return;
            actualState = newState;
            if (stateChanged != null)
                stateChanged(this);
        
            
        }

        public int ID { get => numberID; }
        public CrateGeneration(EnumTypeProduction type)
        {
            ActualState = EnumState.NotStarted;
            this.type = type;
            switch (type)
            {
                case EnumTypeProduction.TYPE_A:
                    maxCrates = 10000;
                    break;
                case EnumTypeProduction.TYPE_B:
                    maxCrates = 25000;
                    break;
                case EnumTypeProduction.TYPE_C:
                    maxCrates = 120000;
                    break;
            }
            numberID = EntityCount;
            EntityCount++;
        }

        public bool Start()
        {
            if (actualState != EnumState.NotStarted)
                return false;
            ActualState = EnumState.Started;
            productionThread = new Thread(new ThreadStart(CreateCrate));
            productionThread.Start();
            return true;
        }

        public bool Stop()
        {
            if (actualState != EnumState.Started)
                return false;
            ActualState = EnumState.Paused;
            return true;
        }

        public bool Continue()
        {
            if (actualState != EnumState.Paused)
                return false;
            ActualState = EnumState.Started;
            return true;
        }

        public int CrateProduced
        {
            get { return crateProduced; }
            private set
            {
                crateProduced = value;
                if (OnCreateProduced != null)
                    OnCreateProduced(this);
            }
        }

        public int DefectiveCrate
        {
            get { return defectiveCrate; }
        }

        public void CreateCrate()
        {
            while (crateProduced < maxCrates)
            {
                if (actualState == EnumState.Started)
                {
                    if (number.Next() == 0)
                    {
                        defectiveCrate++;
                        defectiveTime.Add(DateTime.Now);
                    }
                    else
                    {
                        CrateProduced++;
                    }
                }
                Thread.Sleep(50);
            }
            ActualState = EnumState.Ended;
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