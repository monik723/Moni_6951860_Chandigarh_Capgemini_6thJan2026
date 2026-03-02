using System;

namespace BankCaseStudy
{
    // ================= BASE CLASS =================
    class BankAccount
    {
        // Encapsulation: private data members
        private int accountNumber;
        private string accountHolder;
        protected double balance;

        // Constructor
        public BankAccount(int accNo, string name, double bal)
        {
            accountNumber = accNo;
            accountHolder = name;
            balance = bal;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit successful!");
            }
        }

        // Withdraw method (virtual so child classes can override)
        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        // Display method
        public virtual void Display()
        {
            Console.WriteLine("\n--- Account Summary ---");
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Balance        : " + balance);
        }
    }

    // ================= SAVINGS ACCOUNT =================
    class SavingsAccount : BankAccount
    {
        private double interestRate = 5; // 5%

        public SavingsAccount(int accNo, string name, double bal)
            : base(accNo, name, bal)
        {
        }

        // Interest calculation
        public void AddInterest()
        {
            double interest = (balance * interestRate) / 100;
            balance += interest;
            Console.WriteLine("Interest added: " + interest);
        }
    }

    // ================= CHECKING ACCOUNT =================
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accNo, string name, double bal)
            : base(accNo, name, bal)
        {
        }

        // Override withdraw if needed
        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Checking account withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Insufficient balance in checking account!");
            }
        }
    }

    // ================= MAIN CLASS =================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Account Type:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Checking Account");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double bal = Convert.ToDouble(Console.ReadLine());

            BankAccount account;

            if (choice == 1)
                account = new SavingsAccount(accNo, name, bal);
            else
                account = new CheckingAccount(accNo, name, bal);

            int ch;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Add Interest (Savings only)");
                Console.WriteLine("5. Exit");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.Write("Enter amount: ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(d);
                        break;

                    case 2:
                        Console.Write("Enter amount: ");
                        double w = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(w);
                        break;

                    case 3:
                        account.Display();
                        break;

                    case 4:
                        if (account is SavingsAccount)
                        {
                            ((SavingsAccount)account).AddInterest();
                        }
                        else
                        {
                            Console.WriteLine("Interest only for Savings Account!");
                        }
                        break;
                }

            } while (ch != 5);
        }
    }
}
