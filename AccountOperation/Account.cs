using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperation
{
    public class Account
    {
        public string customerName;
        public string accountNumber;
        public double balance;
        public double amount;


        public double Diposit(double amount)
        {
            return balance+= amount;
        }

        public double withdraw(double amount)
        {
            return balance -= amount;
        }


    }
}
