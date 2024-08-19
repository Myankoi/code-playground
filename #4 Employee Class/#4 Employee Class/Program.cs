using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Employee_Class
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Muhammad", "Ramadian Ramadhan", 3500000);

            Console.WriteLine($"Employee ID             : {employee.getID()}");
            Console.WriteLine($"Employee First Name     : {employee.getFirstName()}");
            Console.WriteLine($"Employee Last Name      : {employee.getLastName()}");
            Console.WriteLine($"Employee Full Name      : {employee.getName()}");
            Console.WriteLine($"Employee Salary         : {employee.getSalary()}");
            employee.setSalary(4000000);
            Console.WriteLine($"Employee Set Salary To  : {employee.getSalary()}");
            Console.WriteLine($"Employee Annual Salary  : {employee.getAnnualSalary()}");
            Console.WriteLine($"Employee Raise Salary   : {employee.raiseSalary(3)}\n");

            Console.WriteLine(employee.toString());
        }
    }
}
