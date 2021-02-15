using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp = true;
            Console.WriteLine("Welcome to the Movie List Application!\nThere are 10 movies in this list.");
            while(resp == true)
            {
                Console.WriteLine("The category choices are Animated, Horror, Scifi, or Drama.Please pick one of the 4 choices and enter it below:");
                string response = Console.ReadLine();
                Movie movie = new Movie();

                if (response == "Animated")
                {
                    movie.Animated();
                }
                if (response == "SciFi")
                {
                    movie.Scifi();
                }
                if (response == "Horror")
                {
                    movie.Horror();
                }
                if (response == "Drama")
                {
                    movie.Drama();
                }

                Console.WriteLine("Do you wish to continue? (y/n)");
                string respstr = Console.ReadLine();
                if(respstr =="y")
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }

            }


        }
    }
}
