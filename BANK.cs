using System;
using System.Collections.Generic;

namespace BANK_PROJECT
{
    public class BankAccount
    {
        private List<string> transactions; //History
        public decimal Balance { get; private set; } //Balance

        public BankAccount()
        {
            transactions = new List<string>(); //Initialize the transaction 
            Balance = 0; //Start with zero 
        }
        public void Deposit(decimal amount) //Deposit money
        {
            Balance += amount; //Increase the balance
            transactions.Add($"Deposited: ${amount:F2}"); //F2 fixes for 2 decimal places
        }
        public void Withdraw(decimal amount) //Withdraw
        {
            if (amount <= Balance) //Check balance 
            {
                Balance -= amount; //Decrease the balance
                transactions.Add($"Withdrew: ${amount:F2}"); //Record transaction two decimals
            }
            else
            {
                Console.WriteLine("Insufficient funds"); //Print error 
            }
        }
        public List<string> GetTransactions() //List of transactions
        {
            return transactions;
        }
    }
}
