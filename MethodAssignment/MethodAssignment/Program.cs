using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to do 3 seperate math functions.");
            int Num = Convert.ToInt32(Console.ReadLine());

            int add = Math.Add1(Num);
            Console.WriteLine("\n" + add + " is the new number, and added to your current number");
            

            int sub = Math.Subtract(Num);
            Console.WriteLine("\n" + sub + ": your second vaule is substracted by 7.");
           

            int multiply = Math.Multiply(Num);
            Console.WriteLine("\n" + multiply + ": your final answer by multiplying by 75");

            Console.ReadLine();
        }
    }
}