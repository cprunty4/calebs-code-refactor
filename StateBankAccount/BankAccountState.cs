using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateBankAccount
{
    /// <summary>
    /// State
    /// </summary>
    public abstract class BankAccountState
    {
        public BankAccount BankAccount { get; set; } = null!;

        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);        
    }
}