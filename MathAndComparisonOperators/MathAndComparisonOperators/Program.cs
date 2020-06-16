using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            int num1, num2 = 50;
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            int multiply = num1 * num2;
            Console.WriteLine("Output: {0} x {1} = {2}",
                                num1, num2, multiply);



            int num3, num4 = 25;
            Console.Write("Enter a number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int add = num3 + num4;
            Console.WriteLine("Output: {0} + {1} = {2}",
                                num3, num4, add);



            float num5, num6 = (float)12.5d;
            Console.Write("Enter a number: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            float divide = num5 / num6;
            Console.WriteLine("Output: {0} / {1} = {2}",
                                num5, num6, divide);



            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            bool test = x >= 50;
            Console.WriteLine($"Result: {test}");



            int num7, num8 = 7;
            Console.Write("Enter a number: ");
            num7 = Convert.ToInt32(Console.ReadLine());

            int remainder = num7 % num8;
            Console.WriteLine("Output: {0} % {1} = {2}",
                               num7, num8, remainder);


        }
    }
}
