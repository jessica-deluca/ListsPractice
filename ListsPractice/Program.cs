using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>(); // create a list when you don't know the values
            //favNumbers.Add(7); // will add the value of 7 (not the index or the number of elements)
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach (int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine(favNumbers.Count); // with Arrays, use .Length; with Lists, use .Count

            //List<string> books = new List<string> { "Cat in the Hat", "Toad and Frog", "Green Eggs and Ham" }; // create a list when we do know the values

            //Console.WriteLine(books[0]); // "Cat in the Hat" is at index 0
            //books.Insert(0, "Horton Hears a Who"); // "Horton Hears a Who" is inserted at index 0, moving the previous index down
            //Console.WriteLine(books[0]);
            //Console.WriteLine(books[1]); // "Cat in the Hat" is now at index 1

            // Create a list and add 5 animals using the .Add()
            // Print each animal in the list

            //List<string> animals = new List<string>();
            //animals.Add("dog");
            //animals.Add("elephant");
            //animals.Add("bunny");
            //animals.Add("frog");
            //animals.Add("zebra");

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            // you can also do it this way using a for loop:

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    Console.WriteLine(animals[i]);
            //}

            // Create the following list:
            // A bool list {true, false, false, true, false}
            // Loop through each value
            // If the value is true, print "Better bring an umbrella."
            // If the value is false, print "No rain today. Enjoy the sun."

            //List<bool> weather = new List<bool> { true, false, false, true, false };

            //foreach (bool clouds in weather)
            //    if (clouds == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today. Enjoy the sun.");
            //    }

            //List<string> faveFoods = new List<string> { "steak", "fish", "katsudon", "ice cream", "nachos" };

            //if(faveFoods.Contains("fish")) // .Contains returns a boolean; if you are searching for something list.Contains will show you if a value is there
            //{
            //    Console.WriteLine("I like fish, too!");
            //}


        }
    }
}
