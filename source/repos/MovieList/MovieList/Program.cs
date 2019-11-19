using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Movie> movieList = new List<Movie>()
            {
                {new Movie("Toy Story", "animated") },
                {new Movie("Coco", "animated") },
                {new Movie("Wall-E", "animated") },
                {new Movie("John Q", "drama") },
                {new Movie("Memiors of a Geisha", "drama") },
                {new Movie("Get Out", "horror") },
                {new Movie("Us", "horror") },
                {new Movie("IT", "horror") },
                {new Movie("Interstellar", "scifi") },
                {new Movie("Star Wars", "scifi") }
            };

                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("- Animated");
                Console.WriteLine("- Drama");
                Console.WriteLine("- Horror");
                Console.WriteLine("- Scifi");

                string input = Validate(Console.ReadLine().ToLower());

                foreach (Movie m in movieList)
                {

                    if (m.Category == input)
                    {
                        Console.WriteLine($"{m.Title}");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid category");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Please enter a valid category");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Please enter a valid category");
            }
        }
        public static string Validate(string input)
        {
            bool again = true;
            while (true)
            {

                if (input == "drama" || input == "animated" || input == "scifi" || input == "horror")
                {
                    again = false;
                    return input;

                }
                else
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                }
            }
            again = true;
        }
    }
}
