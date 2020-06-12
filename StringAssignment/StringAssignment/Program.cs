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
            //string name = "Jordan";
            //string quote = "The man said, \\Hello\", Jordan. \n How are you doing? \n \t How is your c# course?";

            //name = name.ToUpper();
            


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
