using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberOne = { 93, 98, 84, 70, 87, 54, 91 };
            int numberThree = 0;

            foreach (int number in numberOne)
            {
                try
                {
                    Console.WriteLine("Pick a number to divide by:");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());
                    numberThree = number / numberTwo;
                    Console.WriteLine(number + " divided by " + numberTwo + " equals " + numberThree);
                    Console.Read();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero.");
                    continue;
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Please use only numbers.");
                    continue;
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
