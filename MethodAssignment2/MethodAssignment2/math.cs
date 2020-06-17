using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    public class Math
    {

        public int addition(int num)
        {
            int num1 = num + 24;
            return num1;
        }

        public decimal addition(decimal num)
        {
            decimal num1 = num * 2;
            return num1;
        }

        public int addition(string num)
        {
            int convertNum = Convert.ToInt32(num);
            int num1 = convertNum - 1;
            return num1;
        }


    }
}
