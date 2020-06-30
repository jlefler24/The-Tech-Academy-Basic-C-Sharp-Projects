using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var newEmployee = Console.ReadLine();
            const string myName = "Jordan";
            Console.WriteLine("Hello, {0}, my name is {1}, welcome to The Tech Academy!", newEmployee, myName);
            Console.ReadLine();

            Employee employee = new Employee("Austin Linel");

            Console.WriteLine(employee.Name + " " + employee.Id);

            Console.ReadLine();


        }
    }
}