using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Peter", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} dollars");

            account.MakeWithdrawal(120, DateTime.Now, "Vacuum");
            account.MakeWithdrawal(50, DateTime.Now, "Game");

            Console.WriteLine(account.GetAccountHistory());


            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            //}

            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("exception caught tryong to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
            

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}