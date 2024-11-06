using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
   
    class Accounts
    {
        // Fields for account details
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        // Constructor to initialize account details
        public Accounts(int accNo, string custName, string accType, double initialBalance)
        {
            accountNo = accNo;
            customerName = custName;
            accountType = accType;
            balance = initialBalance;
        }

        // Method to perform the transaction and update balance
        public void UpdateBalance(char transType, double amt)
        {
            transactionType = transType;
            amount = amt;

            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

        // Method to deposit amount
        private void Credit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Amount Deposited: {amount}");
        }

        // Method to withdraw amount
        private void Debit(double amt)
        {
            if (amt > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amt;
                Console.WriteLine($"Amount Withdrawn: {amt}");
            }
        }

        // Method to display account details
        public void ShowData()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Balance: {balance}");
            Console.Read();
        }
    }

    class Acc
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter Account Number: ");
            int accountNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            string accountType = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            // Create an instance of Accounts
            Accounts account = new Accounts(accountNo, customerName, accountType, initialBalance);

            // Perform transactions
            Console.Write("\nEnter Transaction Type (D for Deposit, W for Withdrawal): ");
            char transactionType = char.Parse(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Update balance based on transaction type
            account.UpdateBalance(transactionType, amount);

            // Show account details
            account.ShowData();
        }
    }
}
