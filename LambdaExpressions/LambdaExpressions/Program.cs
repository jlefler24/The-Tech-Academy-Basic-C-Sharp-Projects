using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {FirstName="Jordan", LastName="L", ID=1},
                new Employee {FirstName="Austin", LastName="L", ID=2},
                new Employee {FirstName="Aaron", LastName="B", ID=3},
                new Employee {FirstName="Dusty", LastName="H", ID=4},
                new Employee {FirstName="Henry", LastName="K", ID=5},
                new Employee {FirstName="Cody", LastName="I", ID=6 },
        
            };

            List<Employee> names = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Jordan")
                {
                    names.Add(employee);
                }
            }

            List<Employee> names2 = employees.FindAll(x => x.FirstName == "Austin").ToList();

            List<Employee> ids = employees.FindAll(x => x.ID > 5).ToList();

            Console.WriteLine("Employee list of names generated from foreach loop:");
            foreach (Employee employee in names)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();

            Console.WriteLine("Employee list of names generated from lambda expression:");
            foreach (Employee employee in names2)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();

            Console.WriteLine("Employee list with id greather than 5 generated from lambda expression:");
            foreach (Employee employee in ids)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();
        }
    }

}