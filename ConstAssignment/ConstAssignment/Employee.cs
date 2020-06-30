using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAssignment
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee()
        {
        }

        public Employee(string name) : this(name, 5)
        {
            this.Name = name;
        }
        public Employee(int id)
        {
            this.Id = id;
        }
        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }


    }
}