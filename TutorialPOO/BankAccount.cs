using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPOO
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var transaction = new Transaction(amount, date, note);
            allTransactions.Add(transaction);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient fund for this withdrawal");
            }
            var transaction = new Transaction(-amount, date, note);
            allTransactions.Add(transaction);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
