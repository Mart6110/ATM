using ATM.Controllers;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000); // Creating an account with initial balance of 1000
            PINValidator pinValidator = new PINValidator();
            BankController bankController = new BankController(account, pinValidator);

            Console.WriteLine("Enter your PIN:");
            string enteredPIN = Console.ReadLine();

            Console.WriteLine("Enter the amount to withdraw:");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (bankController.WithdrawMoney(enteredPIN, amount))
            {
                Console.WriteLine("Withdrawal successful. Remaining balance: " + account.Balance);
            }
            else
            {
                Console.WriteLine("Withdrawal unsuccessful.");
            }
        }
    }
}
