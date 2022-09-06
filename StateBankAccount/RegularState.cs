using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateBankAccount
{
    /// <summary>
    /// Concrete State
    /// </summary>
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;

            if (Balance < 0)
            {
                BankAccount.bankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}