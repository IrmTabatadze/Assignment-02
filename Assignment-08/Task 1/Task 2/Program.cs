using System.Threading.Channels;
using Task_2;

Currency currency = new Currency();
currency.CurrencyString = "USD";
currency.Amount = 80000;

BankAccount MyBankAccount = new BankAccount("GEO012345698745663211", "irma", currency); //
MyBankAccount.AccountHolderName = "irma";
MyBankAccount.AccountNumber = "GEO012345698745663211";
MyBankAccount.Balance = currency;


BankAccount MyBankAccount2 = new BankAccount("GEO012345698745663211", "irma", currency); //
MyBankAccount2.AccountHolderName = "erma";
MyBankAccount2.AccountNumber = "GEO01234569874566985";
MyBankAccount2.Balance = currency;


MyBankAccount.Deposit(30000);

MyBankAccount.TransferFunds(MyBankAccount2, 10000);

Console.WriteLine(MyBankAccount.AccountNumber + " / " + MyBankAccount.AccountHolderName + " / " + MyBankAccount.Balance.Amount + " / Currency : " + MyBankAccount.Balance.CurrencyString);
Console.WriteLine(MyBankAccount2.AccountNumber + " / " + MyBankAccount2.AccountHolderName + " / " + MyBankAccount2.Balance.Amount + " / Currency : " + MyBankAccount2.Balance.CurrencyString);