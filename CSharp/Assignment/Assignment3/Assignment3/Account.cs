using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
   
    class account
    {
        
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        
        public account(int accNo, string custName, string accType, double initialBalance)
        {
            accountNo = accNo;
            customerName = custName;
            accountType = accType;
            balance = initialBalance;
        }

        
        public void update(char transType, double amt)
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

        
        private void Credit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Amount Deposited: {amount}");
        }

       
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

        
        public void ShowData()
        {
            Console.WriteLine("----------------------------Account Details-------------------------");
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
          
            Console.Write("Enter Account Number: ");
            int accountNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            string accountType = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

           
            account account = new account(accountNo, customerName, accountType, initialBalance);

            
            Console.Write("Enter Transaction Type (D - Deposit, W - Withdrawal): ");
            char transactionType = char.Parse(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            
            account.update(transactionType, amount);

            
            account.ShowData();
        }
    }
}
