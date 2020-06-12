using System;
using System.Activities.Expressions;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.Write("Welcome to Package Express. Please follow the instructions below.\n");


            Console.Write("Package Weight: ");
            int weight = int.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }

            Console.Write("Please enter the package width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            int length = int.Parse(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }


            Console.Write("Your estimated total for shipping this package is:");
            float quote = weight * width * height * length / 100;
            Console.WriteLine($"${quote}");
            Console.ReadLine();
            Console.Write("Thank You:\n");


        }
    }
}
