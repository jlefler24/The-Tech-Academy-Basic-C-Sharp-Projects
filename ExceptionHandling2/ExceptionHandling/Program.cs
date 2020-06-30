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

            try
            {
                Console.WriteLine("What is your current age?");
                string userAge = Console.ReadLine();
                int age = Convert.ToInt32(userAge);

                if (age <= 0)
                {
                    throw new ArgumentException("Age cannot be 0 or lower");
                }

                DateTime current = DateTime.Now;
                DateTime yearBorn = current.AddYears(-age);
                int year = yearBorn.Year;
                Console.WriteLine("You were born in the year " + year);
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
                Console.ReadLine();
            }
        }
    }
}