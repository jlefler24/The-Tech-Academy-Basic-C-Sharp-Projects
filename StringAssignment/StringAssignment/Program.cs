using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            string num1 = "I like to play";
            string num2 = " flag football";
            string num3 = " it is my favorite hobby.";

          
            Console.WriteLine(num1 + num2 + num3);
            Console.ReadLine();
            Console.WriteLine(num2.ToUpper());
            Console.ReadLine();
            

        
            StringBuilder sb = new StringBuilder();

           
            sb.Append("Bitcoin is a digital and global money system currency.");
            sb.AppendLine();
            sb.Append("It allows people to send or receive money across the internet, even to someone they don't know or don't trust.").AppendLine();
            sb.Append("The mathematical field of cryptography is the basis for Bitcoin's security.").AppendLine();

           
            string innerString = sb.ToString();
            Console.WriteLine(innerString);
            Console.ReadLine();

        }
    }
}
