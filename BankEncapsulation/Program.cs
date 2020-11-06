using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acct = new BankAccount();
            Console.WriteLine($"Your starting balance is: {acct.GetBalance()}");
            acct.Deposit(55);
            Console.WriteLine($"Your new balance is: {acct.GetBalance()}");
        }
    }
}
