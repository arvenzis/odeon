using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankZaken
{
    /**
     * Convert attributes to properties, paragraph 4.6, p158
     * Implement class diagram fig 4.14, p172
     * Add the ToString method
     */ 
    class Account
    {
        private string name;
        private decimal balance;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetBalance(decimal balance)
        {
            this.balance = balance;
        }


    }
}
