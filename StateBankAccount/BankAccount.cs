using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateBankAccount
{
    /// <summary>
    /// Context
    /// </summary>
    public class BankAccount
    {
        public BankAccount()
        {
            bankAccountState = new RegularState(200, this);
        }

        public BankAccountState bankAccountState { get; set; }

        public decimal Balance { get { return bankAccountState.Balance; } }


        public void Deposit(decimal amount)
        {
            bankAccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            bankAccountState.Withdraw(amount);
        }

    }
}