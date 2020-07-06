using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program
    {
        private static int result;

        static void Main()
        {

            Console.WriteLine("Please enter an integer: ");
            int intOne = Convert.ToInt32(Console.ReadLine());
            Class1.MyMethod(intOne, out result);
            

            Console.WriteLine("Please enter a second integer: ");
            string userIn2 = Console.ReadLine();
            int intTwo = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }
    }
}