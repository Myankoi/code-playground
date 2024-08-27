using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Account_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nACCOUNTING\n");

            AskUser askUser = new AskUser();
            Account acc1 = new Account("1", "ASEP", 5000000);
            Account acc2 = new Account("2", "YUSEP", 3500000);

            Console.WriteLine(acc1.toString());
            Console.WriteLine("ID               : " + acc1.getID());
            Console.WriteLine("Name             : " + acc1.getName());
            Console.WriteLine("Current Balance  : " + acc1.getBalance());

            Console.WriteLine();

            Console.WriteLine(acc2.toString());
            Console.WriteLine("ID               : " + acc2.getID());
            Console.WriteLine("Name             : " + acc2.getName());
            Console.WriteLine("Current Balance  : " + acc2.getBalance());

            Console.WriteLine();
            Console.WriteLine("Debit/Transfer? (1/2)");
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                int dAmount = askUser.AskDebit();
                acc1.debit(dAmount);
                Console.WriteLine($"Saldo sekarang: {acc1.getBalance()}");
            }
            else if (choice == 2)
            {
                int tAmount = askUser.AskTransferTo();
                acc1.transferTo( acc2, tAmount);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
