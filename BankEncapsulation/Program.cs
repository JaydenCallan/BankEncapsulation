using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            string input = "";
            bool deposited = false;
            do
            {
                Console.WriteLine("How much do you want to deposit?");
                try
                {
                    input = Console.ReadLine();
                    account.Deposit(double.Parse(input));
                    deposited = true;
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            } while (deposited == false);

            Console.WriteLine($"You have ${account.GetBalance()} in your account");
        }
    }
}