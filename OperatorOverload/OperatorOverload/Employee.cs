using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }


        public static bool operator == (Employee employ1, Employee employ2)
        {
            bool isEqual = (employ1.ID == employ2.ID);
            return isEqual;
        }

        public static bool operator != (Employee employ1, Employee employ2)
        {
            bool notEqual = (employ1.ID != employ2.ID);
            return notEqual;
        }
    }
}
