using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Account_Bank
{
    public class AskUser
    {
        private int amount;

        public int AskCredit()
        {
            Console.WriteLine("Credit Amount    : ");
            amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }
        public int AskDebit()
        {
            Console.WriteLine("Debit Amount    : ");
            amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }
        public int AskTransferTo()
        {
            Console.WriteLine("Transfer Amount    : ");
            amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }

    }
}
