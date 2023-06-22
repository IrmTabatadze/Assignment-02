using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public partial class BankAccount
    {
        //public readonly string AccountNumber;
        public BankAccount()
        {
        }
        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public Currency _balance;

        public Currency Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
             
        public void Deposit(double amount)
        {
            _balance.Amount += amount;
        }

        public void Withdraw(double amount)
        {
            _balance.Amount -= amount;
        }

        public string BalanceCheck()
        {
            return Balance.Amount + " " + Balance.CurrencyString;

        }
    }  
}
