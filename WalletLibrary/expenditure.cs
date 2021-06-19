using System;

namespace WalletLibrary
{
    public class expenditure
    {
        public DateTime Date { get; set; }
        public IncomeEnum IncomeEnum { get; set; }
        public double Dif { get; set; }

        public expenditure()
        {
            Date = new DateTime();
        }

        public expenditure(DateTime date, expenditureEnum incomeEnum, double sum)
        {
            Date = date;
            var expenditureEnum = typeof(expenditureEnum);
            Dif = sum;
        }

        public void Add(expenditure expenditure1)
        {
            throw new NotImplementedException();
        }
    }
}