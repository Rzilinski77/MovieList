using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        private string title;
        private string category;
        public string categoryCodes;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie()
        {
            
        }
        public Movie(string title, string category, string categoryCodes)
        {
            Title = title;
            Category = category;
            this.categoryCodes = categoryCodes;
        }

        public static string Change(string input)
        {
            bool again = true;
            string category = "";
            while (again == true)
            {
                try
                {
                    if (input == "1")
                    {
                        category = "animated";
                        again = false;
                    }
                    else if (input == "2")
                    {
                        category = "drama";
                        again = false;
                    }
                    else if (input == "3")
                    {
                        category = "horror";
                        again = false;
                    }
                    else if (input == "4")
                    {
                        category = "scifi";
                        again = false;
                    }
                    else if (input.ToLower() == "drama" || input.ToLower() == "animated" || input.ToLower() == "scifi" || input.ToLower() == "horror")
                    {
                        again = false;
                        category = input.ToLower();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid category");
                        input = Console.ReadLine();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                    //again = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                    //again = true;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                }
            }

            return category;
        }
    }
}
