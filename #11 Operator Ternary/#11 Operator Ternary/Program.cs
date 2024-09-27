using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11_Operator_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool boyIsJomblo = true;

            // if else biasa
            if (boyIsJomblo == true)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Stress");
            }

            // if else dengan ternary opetor
            string output = (boyIsJomblo == true) ? "Happy" : "Stress";

            Console.WriteLine(output);
        }
    }
}
