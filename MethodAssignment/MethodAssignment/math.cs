using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Math
    {
        public static int Add1(int num)
        {
            int newNum = num + 10;
            return newNum;
        }

        public static int Subtract(int num)
        {
            int newNum = num - 2;
            return newNum;
        }

        public static int Multiply(int num)
        {
            int newNum = num * 100;
            return newNum;
        }

    }
}