using BankovniUcet;
using System;
using System.Security.Cryptography;

namespace BankovniUcet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Zdenka", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"zůstatek na účtu {account.Number} majitele {account.Owner} je {account.Balance}");
            var account2 = new BankAccount("Petr", 1500);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"zůstatek na účtu {account.Number} majitele {account.Owner} je {account.Balance}");
            account.MakeDeposit(300, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"zůstatek na účtu {account.Number} majitele {account.Owner} je {account.Balance}");
            account2.MakeDeposit(200, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"zůstatek na účtu {account2.Number} majitele {account2.Owner} je {account2.Balance}");
            Console.WriteLine($"historie transakcí pro účet {account.Number} majitele {account.Owner} je ");
            Console.WriteLine(account.GetAccountHistory());
        }
    } 
}
