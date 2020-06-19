﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeStr = new Employee<string>();
            employeeStr.things = new List<string>();
            employeeStr.things.Add("printers");
            employeeStr.things.Add("computers");
            employeeStr.things.Add("files");
            employeeStr.things.Add("clients");

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.things = new List<int>();
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(40);
            employeeInt.things.Add(6);

            Console.WriteLine("This employee has:");

            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(employeeInt.things[i] + " " + employeeStr.things[i]);
                i++;
            }

            Console.ReadLine();

        }
    }
}