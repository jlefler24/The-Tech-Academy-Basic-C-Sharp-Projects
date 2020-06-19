using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what day of the week it is (hint: capitalize the first letter)");
            try
            {
                DaysOfTheWeek answer = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a day of the week.");
            }
            Console.ReadLine();
        }

    }
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}

