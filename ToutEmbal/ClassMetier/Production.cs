using System.Transactions;

namespace ClassMetier
{
    public class Production
    {
        private int nbCrateToProduce;
        private int nbCrateProduced;
        private int nbDefectiveCrate;
        private int nbDefectiveSinceLastHour = 0;
        private int nbCrateBySecond;
        private string type;
        private List<DateTime> defectiveTime = new List<DateTime>();

        public int NbDefectiveSinceLastHour
        {
            get { return nbDefectiveSinceLastHour; }
            set { nbDefectiveSinceLastHour = value; }
        }

        public List<DateTime> DefectiveTime
        {
            get { return defectiveTime; }
            set { defectiveTime = value; }
        }
        public enum EnumProductionState
        {
            NotStarted,
            Started,
            Pause,
            Finished
        }

        EnumProductionState currentState = EnumProductionState.NotStarted;

        //Event that do report when production state changed.
        public event ProductionStateChangedEventHandler ProductionStateChanged;

        //Delegate that return void
        public delegate void ProductionStateChangedEventHandler(EnumProductionState state, Production sender);

        public int NbCrateToProduce
        {
            get { return nbCrateToProduce; }
            set { nbCrateToProduce = value; }
        }

        public int NbCrateProduced
        {
            get { return nbCrateProduced; }
            set { nbCrateProduced = value; }
        }

        public int NbDefectiveCrate
        {
            get { return nbDefectiveCrate; }
            set { nbDefectiveCrate = value; }
        }

        public string Type
        {
            get { return type; }
        }
        public EnumProductionState CurrentState 
        { get => currentState;
          private set 
          { 
                currentState = value;
                if (ProductionStateChanged != null)
                {
                    ProductionStateChanged(CurrentState, this);
                }
          } 
        }

        public Production(int nbCrateToProduce, int nbCrateProduced, int nbDefectiveCrate, string type, int nbCrateBySecond)
        {
            this.nbCrateToProduce = nbCrateToProduce;
            this.nbCrateProduced = nbCrateProduced;
            this.nbDefectiveCrate = nbDefectiveCrate;
            this.type = type;
            this.nbCrateBySecond = nbCrateBySecond;
        }

        public bool RandomIsDefective()
        {
            Random rnd = new Random();
            return rnd.Next(0,10) == 0;
        }

        public void AddCrate()
        {
            if (nbCrateProduced == nbCrateToProduce)
            {
                CurrentState = EnumProductionState.Finished;
            }
            else
            {
                if (currentState == EnumProductionState.Started)
                {
                    if (RandomIsDefective() == false)
                        nbCrateProduced+=nbCrateBySecond;
                    else
                    {
                        nbDefectiveCrate+=nbCrateBySecond;
                        for(int i = 0; i < nbCrateBySecond; i++)
                        {
                            defectiveTime.Add(DateTime.Now);
                        }
                        RemoveOldDefective();
                        NbDefectiveSinceLastHour = defectiveTime.Count();
                    }
                }
            }
        }

        public bool Start()
        {
            if(CurrentState == EnumProductionState.NotStarted)
            {
                CurrentState = EnumProductionState.Started;
                return true;
            }
            return false;
        }

        public bool Pause()
        {
            if (CurrentState == EnumProductionState.Started)
            {
                CurrentState = EnumProductionState.Pause;
                return true;
            }
            return false;
        }

        public bool Continue()
        {
            if (CurrentState == EnumProductionState.Pause)
            {
                CurrentState = EnumProductionState.Started;
                return true;
            }
            return false;
        }

        public void RemoveOldDefective()
        {
            foreach(DateTime d in defectiveTime.ToList())
            {
                if(d.AddSeconds(5) < DateTime.Now)
                {
                    defectiveTime.Remove(d);
                }
                else
                {
                    return;
                }
            }
        }
    }
}