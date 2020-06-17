using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string[] people = { "jordan", "sally", "genevieve", "kenzie" };
            Console.WriteLine("Write an action");
            string verb = Console.ReadLine();

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i] + ' ' + verb);
            }
            Console.ReadLine();

            /*Infinite Loop; and Comparisons*/
            int[] gradeScores = { 87, 96, 67, 45, 70, 78, 50 };

            for (int i = 0; i < gradeScores.Length; i++) 
            {
                if (gradeScores[i] <= 60) 
                {
                    Console.WriteLine("Failing grades are: " + gradeScores[i]);
                }
            }
            Console.ReadLine();

            /*Assignment 6,7,8 List*/
            bool Fruits = false;
            List<string> fruitList = new List<string>() { "oranges", "grapes", "apples", "watermelon", "mango" };

            while (Fruits == false) 
            {
                Console.WriteLine("Name a random fruit and see if its in the list!");
                string userFruit = Console.ReadLine().ToLower();
                foreach (string fruit in fruitList)
                {
                    if (userFruit == fruit)
                    {
                        Console.WriteLine("You found a fruit in the list with an index of: " + fruitList.IndexOf(fruit));
                        Fruits = true;
                        break;
                    }
                }
                if (Fruits == false)
                {
                    Console.WriteLine("That fruit was not in the list.");
                }
            }
            Console.ReadLine();


            /*=Assignment 9-10==*/
            bool rightColor = false;
            List<string> colorsList = new List<string>() { "red", "blue", "orange", "purple", "yellow", "white" };

            while (!rightColor) 
            {
                Console.WriteLine("Pick a color");
                string userColor = Console.ReadLine().ToLower();

                for (int i = 0; i < colorsList.Count; i++) 
                {
                    if (userColor == colorsList[i])
                    {
                        Console.WriteLine("Your color has an index of: " + i + " and a great color.");
                        rightColor = true;  
                    }
                }

                if (rightColor == false)
                {
                    Console.WriteLine("That color is not in this list, please pick again.");
                }


            }
            Console.ReadLine();

            /*======================================Assignment 11==================================*/
            List<string> friendsNames = new List<string>() { "austin", "aaron", "jose", "tyler", "henry", "cody", "dusty" };

            List<string> namesSeen = new List<string>();

            foreach (string name in friendsNames)
            {
                Console.WriteLine(name); // print name to user
                if (namesSeen.Contains(name)) // if the list of names we've already seen Contains the current name
                {
                    Console.WriteLine("We have seen this!"); // print 'we've already seen this'
                }
                else //else
                {
                    namesSeen.Add(name); // Add name to the list of names we've already seen
                }
            }
            Console.ReadLine();

          

        }
    }
}
