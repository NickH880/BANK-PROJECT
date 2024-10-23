using System;

namespace BANK_PROJECT
{
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(); //Create bank account

            while (true) //Loop to allow transactions
            {
                Console.WriteLine("\nBANK PROJECT - Bank Account Management"); //Different options
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Show Transactions");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine(); //Get choice

                if (choice == "1") //Deposit
                {
                    Console.Write("Enter amount to deposit: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        account.Deposit(depositAmount);
                        Console.WriteLine($"Deposited: ${depositAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else if (choice == "2") //Withdraw
                {
                    Console.Write("Enter amount to withdraw: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine($"Withdrew: ${withdrawAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else if (choice == "3") //Show balance
                {
                    Console.WriteLine($"Current Balance: ${account.Balance:F2}");
                }
                else if (choice == "4") //Show transactions
                {
                    Console.WriteLine("Transaction History:");
                    foreach (var transaction in account.GetTransactions())
                    {
                        Console.WriteLine(transaction);
                    }
                }
                else if (choice == "5") //Exit
                {
                    break; //Exit loop
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }
    }
}
