using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number to add by 24:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int Answer1 = math.addition(num1);
            Console.WriteLine("The first answer is: " + Answer1);

            Console.WriteLine("Please enter a decimal number:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            decimal Answer2 = math.addition(num2);
            Console.WriteLine(Answer2 + ": is your number times 2.");

            Console.WriteLine("Please write the last number:");
            string num3 = Console.ReadLine();
            int Answer3 = math.addition(num3);
            Console.WriteLine(Answer3 + ": is your final number.");

            Console.ReadLine();



        }
    }
}
