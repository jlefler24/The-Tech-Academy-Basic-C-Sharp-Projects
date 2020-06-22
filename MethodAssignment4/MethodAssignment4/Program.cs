using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program
    {
        static void Main()
        {
            Class1 myObject = new Class1();
            Console.WriteLine("Please enter an integer: ");
            string userIn1 = Console.ReadLine();
            int intOne = Convert.ToInt32(userIn1);
            Console.WriteLine("Please enter a second integer: ");
            string userIn2 = Console.ReadLine();
            int intTwo = Convert.ToInt32(userIn2);

            myObject.MyMethod(intOne, intTwo);
            Console.ReadLine();
        }
    }
}