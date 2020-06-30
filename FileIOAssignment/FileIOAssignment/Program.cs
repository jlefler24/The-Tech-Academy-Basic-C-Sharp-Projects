using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\lefle\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\FileIOAssignment\log.txt", true))
            {
                file.WriteLine(userInput);
            }

            using (StreamReader readFile = new StreamReader(@"C:\Users\lefle\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\FileIOAssignmentlog.txt"))
            {
                string line = readFile.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = readFile.ReadLine();
                }
                readFile.Close();
            }
            Console.ReadLine();

        }
    }
}
