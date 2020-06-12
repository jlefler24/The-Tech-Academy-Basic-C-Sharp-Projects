using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-10?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = number == 4;


            do
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guessed 4. You're Correct!");
                        isCorrect = true;
                        break;

                    default:
                        Console.WriteLine("You guessed wrong. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrect) ;
        
            Console.Read();
        }
    }
}
