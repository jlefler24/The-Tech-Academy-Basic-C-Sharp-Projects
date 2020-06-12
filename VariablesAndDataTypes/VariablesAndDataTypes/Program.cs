using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string NeedHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            


            Console.WriteLine(yourCourse);
            Console.WriteLine(pageNumber);
            Console.WriteLine(NeedHelp);
            Console.WriteLine(experiences);
            Console.WriteLine(feedback);
            Console.WriteLine(studyHours);
            Console.ReadLine();




        }
    }
}
