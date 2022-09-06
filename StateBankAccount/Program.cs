using StateBankAccount;

Console.Title = "Bank Account(s)";

BankAccount bankAccount = new();

bankAccount.Deposit(100);
bankAccount.Withdraw(500);
bankAccount.Withdraw(100);

Console.ReadLine();
