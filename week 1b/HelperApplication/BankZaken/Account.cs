using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankZaken
{
    public class Account
    {
        public string Name { get; set; }
        private decimal Balance { get; set; }

        public Account()
        {
        }

        public Account(string name, decimal initialBalance)
        {
            Name = name;
            Balance = initialBalance;
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0)
            {
                Balance += depositAmount;
            }
        }
    }

}
