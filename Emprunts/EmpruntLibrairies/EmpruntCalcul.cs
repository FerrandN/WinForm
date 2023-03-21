using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpruntLibrairies
{
    public class EmpruntCalcul
    {
        int loanPeriod; // nombre de mois de l'emprunts
        double interest;
        double loan;
        int monthPeriod;
        public EmpruntCalcul(int _loanPeriod, double _interest, double _loan, int _monthPeriod)
        {
            loanPeriod = _loanPeriod;
            interest = _interest;
            loan = _loan;
            monthPeriod = _monthPeriod;
        }
           
        public int LoanPeriod
        {
            get { return loanPeriod; }
            set { loanPeriod = value; }
        }

        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public double Loan
        {
            get { return loan; }
            set { loan = value; }
        }

        public int MonthPeriod
        {
            get { return monthPeriod; }
            set { monthPeriod = value; }
        }

        public int CalculTotalRefundMonth()
        {
            return LoanPeriod/monthPeriod;
        }
        public double CalculLoanToRefund()
        {
            double t = interest/12 * monthPeriod;
            return loan * (t/(1-(Math.Pow((1+t),(CalculTotalRefundMonth ()* -1)))));
        }
    }
}
