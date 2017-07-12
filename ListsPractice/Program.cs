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

            // Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            // Use the contains method with the following values: 23 77 15
            // Remove these elements: 23 77 32 6
            // Use Contains() again on these values: 23 77 15

            //List<int> numberList = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            //if (numberList.Contains(23) || numberList.Contains(77) || numberList.Contains(15))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //// or you can do this to see if its true:
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));

            //numberList.Remove(23); // numberList.RemoveAt() will remove numbers at specific indexes
            //numberList.Remove(77);
            //numberList.Remove(32);
            //numberList.Remove(6);

            //if (numberList.Contains(23) || numberList.Contains(77) || numberList.Contains(15))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //// or you can do this to see if its true:
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));

            // Ask user for a movie
            // Check list to see if movie is contained in list
            // If movie is not in list, add it & inform the user that the movie has been added
            // If movie is in the list, let them know that the movie is on the way

            // The user should be able to add as many movies as they want
            // If the user enter quit, the program should exit & show full list

            List<string> movies = new List<string> { "MINIONS", "ALADIN", "CARS" };
            string userMovie;

            do
            {
                Console.WriteLine("Please enter a movie.");
                userMovie = Console.ReadLine().ToUpper();

                if (userMovie == "QUIT")
                {
                    foreach (string movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else if (movies.Contains(userMovie))
                {
                    Console.WriteLine("Movie is on it's way.");
                }
                else
                {
                    movies.Add(userMovie);
                    Console.WriteLine("Movie has been added.");
                }
            }
            while (userMovie != "QUIT");

        }
    }
}
