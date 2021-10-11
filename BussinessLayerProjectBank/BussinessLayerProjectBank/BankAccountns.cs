using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerProjectBank
{
    public class BankAccountns
    {
        public bool Credit(double value)
        {
            if(value>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Debit(double value)
        {
            if(value>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Balance (double valueCredit, double valueDebit)
        {
            double BalanceValue = valueCredit - valueDebit;
            
            return BalanceValue;

        }
    }
}
