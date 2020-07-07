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
            Console.WriteLine("Enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\lefle\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\FileIOAssignment\FileIOAssignment\log.txt", true))
            {
                file.WriteLine(userNum);
            }

            string text = File.ReadAllText(@"C:\Users\lefle\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\FileIOAssignment\FileIOAssignment\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}