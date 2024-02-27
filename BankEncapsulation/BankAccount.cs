using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
            
        }

        private double _balance;

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double CheckBalance()
        {
            return _balance;
        }
    }
}
