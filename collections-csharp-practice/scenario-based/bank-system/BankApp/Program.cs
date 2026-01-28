using System;

public class Program
{
    public decimal Balance { get; private set; }

    public Program(decimal initialBalance)
    {
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new Exception("Deposit amount cannot be negative");
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new Exception("Insufficient funds.");
        Balance -= amount;
    }
    // Main method required for a Console App to compile
    static void Main(string[] args) 
    {
        Console.WriteLine("Bank System Running...");
    }
}
