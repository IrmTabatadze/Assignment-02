using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, double amount)
        {
            Withdraw(amount);
            target.Deposit(amount);

        }

    }
}
