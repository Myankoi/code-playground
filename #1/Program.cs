using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace whoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserServices userService = new UserServices();
            userService.UserInput();
            userService.OutputDisplay();
            Console.ReadLine();
        }
    }
}
