using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            While();
            Console.ReadLine();
            DoWhile();
            Console.ReadLine();
            For();
            Console.ReadLine();
            ForEach();
            Console.ReadLine();
        }

        static void While()
        {
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        static void DoWhile()
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 5);
        }

        static void For()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
        }
        static void ForEach()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Grape");
            fruits.Add("Pineapple");
            fruits.Add("Melon");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            string[] names = { "Rara", "Ninu", "Wawan" };
            foreach(string name in names )
            {
                Console.WriteLine(name);
            }
        }
    }
}
