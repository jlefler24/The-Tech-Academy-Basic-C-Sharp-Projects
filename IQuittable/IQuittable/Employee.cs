using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    public class Employee : Person, IQuittable
    {
        public override void Name1()
        {
            string fullName = $"{firstName} {lastName} ";
            Console.WriteLine(fullName);
        }
        public void Quit()
        {
            string iQuit = $"{firstName} {lastName} has Quit";
            Console.WriteLine(iQuit);
        }
    }
}
