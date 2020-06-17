using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            int y = Convert.ToInt32(userInput);
            Console.WriteLine("(Optional)Please enter another number: ");
            string userInput2 = Console.ReadLine();

            if (userInput2 != "")
            {
                int x = Convert.ToInt32(userInput2);
                Console.WriteLine(Class1.Method1(y, x));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Class1.Method1(y));
                Console.ReadLine();
            }

        }
    }
}