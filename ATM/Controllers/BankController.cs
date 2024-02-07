using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controllers
{
    public class BankController
    {
        private Account account;
        private PINValidator pinValidator;

        public BankController(Account account, PINValidator pinValidator)
        {
            this.account = account;
            this.pinValidator = pinValidator;
        }

        public bool WithdrawMoney(string enteredPIN, decimal amount)
        {
            if (pinValidator.ValidatePIN(enteredPIN, "1234")) // Assuming correct PIN is "1234"
            {
                if (amount <= account.Balance)
                {
                    account.Withdraw(amount);
                    return true; // Withdrawal successful
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect PIN.");
            }
            return false; // Withdrawal unsuccessful
        }
    }
}
