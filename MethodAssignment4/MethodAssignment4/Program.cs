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
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Math1 myMath = new Math1();
            myMath.MathMethod(num1, num2);

            Console.ReadLine();
        }
    }
}