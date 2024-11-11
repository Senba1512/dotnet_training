using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{

    
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

public BankAccount(string accountNumber, decimal initialBalance = 0.0m)
{
AccountNumber = accountNumber;
Balance = initialBalance;
}

public void Deposit(decimal amount)
{
if (amount <= 0)
{
throw new ArgumentException("Deposit amount must be positive."); 
}

Balance += amount;
Console.WriteLine($"Deposited {amount:C}. New balance is {Balance:C}.");
}

public void Withdraw(decimal amount)
{
    if (amount <= 0)
    {
        throw new ArgumentException("Withdrawal amount must be positive.");
    }

    if (amount > Balance)
{
throw new InsufficientBalanceException("Insufficient balance to complete the withdrawal."); 
}

Balance -= amount;
Console.WriteLine($"Withdrew {amount:C}. New balance is {Balance:C}.");
}

    public decimal CheckBalance()
{
Console.WriteLine($"Current balance: {Balance}");
return Balance;
}
}

public class Program
{
    public static void Main()
    {
        try
        {
            BankAccount account = new BankAccount("12345678", 100.0m);
            account.Deposit(50.0m);
            account.Withdraw(200.0m); 
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Transaction failed: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid transaction: {ex.Message}");
        }
    }
}
}﻿

 
            

     



