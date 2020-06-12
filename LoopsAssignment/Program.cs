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
            Console.WriteLine("Guess a number?");
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

                    case 26:
                        Console.WriteLine("You guessed 26. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 19:
                        Console.WriteLine("You guessed 19. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 88:
                        Console.WriteLine("You guessed 88. That's incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
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
