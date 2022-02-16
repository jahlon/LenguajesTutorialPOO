using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPOO
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            var account = new BankAccount("Jesus", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"Balance {account.Balance}");
            account.MakeDeposit(100, DateTime.Now, "Friend pay me back");
            Console.WriteLine($"Balance {account.Balance}");

            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", 55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }

            try
            {
                account.MakeWithdrawal(400, DateTime.Now, "Attempt to withdrawal");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }

            Console.WriteLine(account.GetAccountHistory());
            Console.ReadLine();

        }
        */
        
    }
}
