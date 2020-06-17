using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Object1 = new Class1(); // Instantiating an object

            Console.WriteLine("Enter a number: ");
            string user = Console.ReadLine();
            int x = Convert.ToInt32(user);

            Object1.MyMethod(x); // Calling the method
            Console.ReadLine();


            Class1 Object2 = new Class1();
            // local variable defintion
            int a, b;

            // Calling a method to get the values
            Object2.GetValue(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.ReadLine();
        }

    }
}
