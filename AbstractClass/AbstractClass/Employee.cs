using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee<T> : Person/*, IQuittable*/
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

        public void Print()
        {
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }

        }
    }
}
