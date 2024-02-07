using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class Account
    {
        public decimal Balance { get; private set; }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
