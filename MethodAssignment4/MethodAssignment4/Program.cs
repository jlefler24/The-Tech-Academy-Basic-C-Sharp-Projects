using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myObject = new Class1();
            Console.WriteLine("Please enter an integer: ");
            int intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer: ");
            int intTwo = Convert.ToInt32(Console.ReadLine());

            myObject.MyMethod(intOne, intTwo);
            Console.ReadLine();
        }
    }
}
