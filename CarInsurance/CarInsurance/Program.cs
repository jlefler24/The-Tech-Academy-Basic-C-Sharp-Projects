using System;

namespace CarInsurance
{

    class Program
    {
        private static bool value;

        static void Main()
        {
            Console.Write("What is your age?: ");
            int age = int.Parse(Console.ReadLine());
   

            Console.WriteLine("Have you ever had a DUI? Enter yes or no: ");
            var inputString = Console.ReadLine();
            if (inputString.ToLower() == "yes")
            {
                value = true;
            }
            else
            {
                value = false;
            }
            _ = ("{0}", value);


            Console.Write("How many speeding tickets do you have?:");
            int ticket = int.Parse(Console.ReadLine());


            bool approve = age > 15 && ticket <= 3 && value == false;
            Console.WriteLine($"Qualified: {approve}");

           

        }
    }
}
