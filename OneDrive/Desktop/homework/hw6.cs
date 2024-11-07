using System;

namespace Assignment3Solving
{
    class Accounts
    {
        // Data members
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string AccountType { get; set; }
        public char TransactionType { get; set; } // 'D' for Deposit, 'W' for Withdrawal
        public double Amount { get; set; }
        public double Balance { get; private set; }

        // Constructor to initialize account details
        public Accounts(int accountNo, string customerName, string accountType, double initialBalance)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
            AccountType = accountType;
            Balance = initialBalance;
        }

        // Method to process transactions
        public void ProcessTransaction(char transactionType, double amount)
        {
            TransactionType = transactionType;
            Amount = amount;

            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Use 'D' for Deposit or 'W' for Withdrawal.");
            }
        }

        // Method to deposit amount
        private void Credit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Amount Deposited: {amount}. Updated Balance: {Balance}");
        }

        // Method to withdraw amount
        private void Debit(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Amount Withdrawn: {amount}. Updated Balance: {Balance}");
            }
        }

        // Method to display account details
        public void ShowData()
        {
            Console.WriteLine($"Account No: {AccountNo}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an account object
            Accounts account = new Accounts(12345, "John Doe", "Savings", 1000);

            // Display account details
            account.ShowData();

            // Perform transactions
            Console.WriteLine("\nProcessing Deposit Transaction:");
            account.ProcessTransaction('D', 500); // Deposit 500

            Console.WriteLine("\nProcessing Withdrawal Transaction:");
            account.ProcessTransaction('W', 300); // Withdraw 300

            // Display updated account details
            Console.WriteLine("\nUpdated Account Details:");
            account.ShowData();

            Console.ReadKey();
        }
    }
}