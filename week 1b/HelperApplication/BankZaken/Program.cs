using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankZaken
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is: {myAccount.Name}");

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.Name = theName;

            Console.WriteLine($"myAccount's name is: {myAccount.Name}");   
        }
    }
}
