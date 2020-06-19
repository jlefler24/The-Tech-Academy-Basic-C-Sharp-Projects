using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ1 = new Employee() { ID = 1 };
            Employee employ2 = new Employee() { ID = 2 };

            bool isEqual = employ1.ID == employ2.ID;

            if (isEqual == true)
            {
                Console.WriteLine("The employees are equal");
            }
            else
            {
                Console.WriteLine("The empoloyees are not equal.");
            }

            Console.ReadLine();

        }
    }
}
