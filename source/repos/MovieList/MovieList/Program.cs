using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie M = new Movie();

            List<Movie> movieList = new List<Movie>()
            {
                {new Movie("Toy Story", "animated", "1") },
                {new Movie("Coco", "animated", "1") },
                {new Movie("Wall-E", "animated", "1") },
                {new Movie("Antz", "animated", "1") },
                {new Movie("Balto", "animated", "1") },
                {new Movie("John Q", "drama", "2") },
                {new Movie("The Shawshank Redemption", "drama", "2") },
                {new Movie("Forest Gump", "drama", "2") },
                {new Movie("Cast Away", "drama", "2") },
                {new Movie("Memiors of a Geisha", "drama", "2") },
                {new Movie("Get Out", "horror", "3") },
                {new Movie("Anabelle", "horror", "3") },
                {new Movie("The Grudge", "horror", "3") },
                {new Movie("Us", "horror", "3") },
                {new Movie("IT", "horror", "3") },
                {new Movie("Interstellar", "scifi", "4") },
                {new Movie("Alien", "scifi", "4") },
                {new Movie("Back to the Future", "scifi", "4") },
                {new Movie("Star Wars", "scifi", "4") }
            };

            movieList.Sort((x, y) => x.Title.CompareTo(y.Title));
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("What category are you interested in?)");
            Console.WriteLine("1) Animated");
            Console.WriteLine("2) Drama");
            Console.WriteLine("3) Horror");
            Console.WriteLine("4) Scifi");
            Console.WriteLine();
            string input = Console.ReadLine();
            string ans = Movie.Change(input);
            Console.WriteLine();
            foreach (Movie m in movieList)
            {
                //input = m.Category.ToLower();

                if (m.Category == ans)
                {
                    Console.WriteLine($"{m.Title}");
                }
            }

        }

        //public static string Validate(string input)
        //{
        //    //bool again = true;
        //    while (true)
        //    {
        //        try
        //        {
        //            if (input.ToLower() == "drama" || input.ToLower() == "animated" || input.ToLower() == "scifi" || input.ToLower() == "horror")
        //            {
        //                //again = false;
        //                return input.ToLower();

        //            }
        //            else
        //            {
        //                Console.WriteLine("Please enter a valid category");
        //                input = Console.ReadLine();
        //            }
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.WriteLine("Please enter a valid category");
        //            input = Console.ReadLine();
        //            //again = true;
        //        }
        //        catch (ArgumentNullException ex)
        //        {
        //            Console.WriteLine("Please enter a valid category");
        //            input = Console.ReadLine();
        //            //again = true;
        //        }
        //        catch (NullReferenceException ex)
        //        {
        //            Console.WriteLine("Please enter a valid category");
        //            input = Console.ReadLine();
        //        }
        //    }
            //again = true;
        }
    }
}
