using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();

            employee.Things.Add("desk");
            employee.Things.Add("table");
            employee.Things.Add("book");

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>();

            employee1.Things.Add(4);
            employee1.Things.Add(416);
            employee1.Things.Add(7);

            employee.Print();
            employee1.Print();
            Console.ReadLine();

        }
    }
}
