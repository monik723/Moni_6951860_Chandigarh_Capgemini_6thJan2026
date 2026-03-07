using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public interface IBankAccountOperation
{
    void Deposit(decimal d);
    void Withdraw(decimal d);
    decimal ProcessOperation(string message);
}

class BankOperations : IBankAccountOperation
{
    private decimal balance = 0;

    public void Deposit(decimal d)
    {
        balance += d;
    }

    public void Withdraw(decimal d)
    {
        if (balance >= d)
        {
            balance -= d;
        }
    }

    public decimal ProcessOperation(string message)
    {
        message = message.ToLower();

        decimal amount = 0;

        Match match = Regex.Match(message, @"\d+");
        if (match.Success)
        {
            amount = Convert.ToDecimal(match.Value);
        }

        if (message.Contains("deposit") || 
            message.Contains("invest") || 
            message.Contains("transfer"))
        {
            Deposit(amount);
        }
        else if (message.Contains("withdraw") || 
                 message.Contains("pull"))
        {
            Withdraw(amount);
        }

        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        BankOperations operations = new BankOperations();

        for (int i = 0; i < n; i++)
        {
            string message = Console.ReadLine();
            decimal result = operations.ProcessOperation(message);
            Console.WriteLine(result);
        }
    }
}