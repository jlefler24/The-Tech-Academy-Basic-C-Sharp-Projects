using System;

namespace IncomeComparisionProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Anonymous Income Comparison Program\n");
            Console.ReadLine();

            Console.Write("Person 1\n");
            Console.Write("Hourly Rate:");
            float hourlyRate1 = float.Parse(Console.ReadLine());

            Console.Write("Hours worked per week:");
            float hoursWorked1 = float.Parse(Console.ReadLine());

            Console.Write("Person 2\n");
            Console.Write("Hourly Rate:");
            float hourlyRate2 = float.Parse(Console.ReadLine());

            Console.Write("Hours worked per week:");
            float hoursWorked2 = float.Parse(Console.ReadLine());


            Console.Write("Annual salary of Person 1:\n");
            float person1 = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine($"{person1}");      
            Console.ReadLine();

            Console.Write("Annual salary of Person 2:\n");
            float person2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine($"{person2}");
            Console.ReadLine();


            Console.Write("Does Person 1 make more money than Person 2?\n");
            bool salary = person1 >= person2;
            Console.WriteLine($"{salary}");


        }
    }
}
