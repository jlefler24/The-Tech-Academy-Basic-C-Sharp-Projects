using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //**********One dimensional array of strings**********//
            string[] strArray = { "Jordan", "Sally", "Austin", "Lois", "Alisha", "Aaron", "Jose" };

            Console.WriteLine("Pick a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 7 || num < 0)
            {
                Console.WriteLine("Please pick a number between 0 and 7");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You picked: " + num + ", with a value of: " + strArray[num]);
            Console.ReadLine();

            //**********One dimensional array of integers**********//
            int[] intArray = { 5, 10, 15, 37, 71, 1024, 4000, 24000, };

            Console.WriteLine("Pick another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num2 > 8 || num2 < 0)
            {
                Console.WriteLine("Please pick a number between 0 and 8");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You picked: " + num2 + ", with an array value of: " + intArray[num2]);
            Console.ReadLine();

            //**********List of strings**********//

            List<string> strList = new List<string>();

            strList.Add("BYU");
            strList.Add("UTAH");
            strList.Add("USU");
            strList.Add("WSU");

            // player one will choose a character
            Console.WriteLine("Select a number between 0 and 4 to pick your team:");
            int team = Convert.ToInt32(Console.ReadLine());

            //if they pick a number outside of the list length, they pick again
            while (team > 4 || team < 0)
            {
                Console.WriteLine("Please pick a number between 0 and 4");
                team = Convert.ToInt32(Console.ReadLine());
            }

            //player two picks a character
            Console.WriteLine("Select a number between 0 and 4 to pick your team:");
            int team2 = Convert.ToInt32(Console.ReadLine());

            //if they pick a number outside of the list length, or the pick the same number, they pick again
            while (team2 > 4 || team2 < 0 || team2 == team)
            {
                if (team2 == team)
                {
                    Console.WriteLine("You may not pick the same team, Please Pick again:");
                    team2 = Convert.ToInt32(Console.ReadLine());

                }
                if (team2 > 4 || team2 < 0)
                {
                    Console.WriteLine("Please pick a number between 0 and 4");
                    team2 = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Team one chose " + strList[team] + "!");
            Console.WriteLine("Team two chose " + strList[team2] + "!.....\n Play!");
            Console.ReadLine();
        }
    }
}
