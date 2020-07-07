using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iQuite = new Employee() { firstName = "Jordan", lastName = "Lefler" };

            iQuite.Quit();
            Console.ReadLine();

        }
    }
}
