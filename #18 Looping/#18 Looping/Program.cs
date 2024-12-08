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
            Console.WriteLine("Muhammad Ramadian Ramadhan");
            Console.WriteLine("X RPL I\n");
            Console.WriteLine("Pilih program berikut: ");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {
                    Ascending();
                } else if (choice == 2)
                {
                    Descending();
                } else
                {
                    Console.Write("Ngulang Klik Enter");
                    Console.Read();
                    Console.Clear();
                    Main(args);
                }
            }
            Console.ReadLine();
        }

        static void Ascending()
        {
            // Muhammad Ramadian Ramadhan
            // X RPL I
            int tinggi;
            Console.Write("Masukan tinggi segitiga: ");

            if (int.TryParse(Console.ReadLine(), out tinggi))
            {
                int formattedTinggi = Math.Abs(tinggi);

                for (int i = 0; i <= formattedTinggi; i++)
                {
                    for (int o = 0; o < i; o++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Ngulang Klik Enter");
                Console.Read();
                Console.Clear();
                Ascending();
            }
        }

        static void Descending()
        {
            // Muhammad Ramadian Ramadhan
            // X RPL I
            int tinggi;
            Console.Write("Masukan tinggi segitiga: ");

            if (int.TryParse(Console.ReadLine(), out tinggi))
            {
                int formattedTinggi = Math.Abs(tinggi);
                for (int i = 1; i <= formattedTinggi; i++)
                {
                    for (int o = formattedTinggi; o >= i; o--)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Ngulang Klik Enter");
                Console.Read();
                Descending();
            }
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
                if ( x == 2 )
                {
                    break;
                }
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
