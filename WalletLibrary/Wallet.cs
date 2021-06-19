using System;
using System.Collections.Generic;

namespace WalletLibrary
{
    public class Wallet
    {
        private double _money;
        private List<Income> _incomes;

        public Wallet()
        {
            _money = 0;
            _incomes = new List<Income>();
        }

        public void Init(double sum)
        {
            _money = sum;
        }

        public void Income(DateTime date, IncomeEnum income, double sum)
        {
            if (sum <= 0)
            {
                _money += 0;
            }
            else
            {
                _money += sum;
                var _income = new Income(date, income, sum);
                _incomes.Add(_income);
                // _incomes.Add(new Income(date, income, sum));
            }
        }

        public void Outgo(double sum,DateTime date)
        {   if (sum <= 0)
        {
            _money -= 0;
        }
        else
        {
            _money -= sum;
            expenditureEnum expenditure = expenditureEnum.Unknown;
            var _expenditure = new expenditure(date, expenditure, sum);
            _expenditure.Add(_expenditure);
        }
    }

    public double Money()
    {
    return _money;
}

public void Outgo(DateTime date, expenditure expenditure, double money)
{
    throw new NotImplementedException();
}
}
    }