﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateBankAccount
{
    /// <summary>
    /// Concrete State
    /// </summary>
    public class GoldState : BankAccountState
    {
        public GoldState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing " +
                $"{amount} + 10% bonus: {amount / 10}"
                );
            Balance += amount + (amount / 10);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;

            if (Balance < 1000 && Balance >= 0)
            {
                BankAccount.bankAccountState = new RegularState(Balance, BankAccount);
            }
            else if (Balance < 0)
            {
                BankAccount.bankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
