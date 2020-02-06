using System;
using System.Collections.Generic;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Sicario", "Action"));
            movies.Add(new Movie("The Martian", "Sci-fi"));
            movies.Add(new Movie("Interstellar", "Sci-fi"));
            movies.Add(new Movie("Avengers: Endgame", "Action"));
            movies.Add(new Movie("Anchorman", "Comedy"));
            movies.Add(new Movie("Step Brothers", "Comedy"));
            movies.Add(new Movie("Spider-Man: Into the Spider-Verse", "Animated"));
            movies.Add(new Movie("Shrek", "Animated"));
            movies.Add(new Movie("Baby Driver", "Action"));
            movies.Add(new Movie("The Lion King", "Animated"));

            
            bool flag = true;
            while (flag == true) 
            {
                
                    Console.Write("What category do you want to look up? (Action, Sci-fi, Comedy, Animated): ");
                    string input = Console.ReadLine();
                
                int ctr = 0;
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Category == input)
                    {
                        ctr++;
                    }
                }

                if (ctr > 0)
                {

                    foreach (Movie movie in movies)
                    {
                        if (movie.Category.Contains(input))
                        {

                            Console.WriteLine(movie);
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid category");
                }

               flag = RunAgainBool("Do you want to search again? ");
                
            } 
        }

        static bool RunAgainBool(string message)
        {
            Console.Write(message);
            char key = Console.ReadKey().KeyChar;

            while (key != 'y')
            {
                if (key == 'n')
                {
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.Write("\nThat is an invalid entry. Please enter y or n: ");
                    key = Console.ReadKey().KeyChar;
                }
            }
            Console.WriteLine();
            return true;
        }
    }
}
