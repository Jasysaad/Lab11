using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie
    {
		public Movie(string title, string category)
		{
		_title = title;
		_category = category;
		}
		public Movie()
		{

		}
	private string _category;
	private string _title;
		public  void Animated()
		{

			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if(movie._category == "Animated")
                {
					Console.WriteLine(movie._title);
                }
			}
		}
		public void Scifi()
		{

			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Scifi")
				{
					Console.WriteLine(movie._title);
				}
			}
		}
		public void Drama()
		{

			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Drama")
				{
					Console.WriteLine(movie._title);
				}
			}
		}
		public void Horror()
		{

			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Horror")
				{
					Console.WriteLine(movie._title);
				}
			}
		}
		private  List<Movie> InitializeList()
		{
			List<Movie> movies = new List<Movie>();
			movies.Add(new Movie("Terminator", "Scifi"));
			movies.Add(new Movie("2012", "Scifi"));
			movies.Add(new Movie("Alien", "Scifi"));
			movies.Add(new Movie("27 Dresses", "Drama"));
			movies.Add(new Movie("National Treasure", "Drama"));
			movies.Add(new Movie("The Little Mermaid", "Animated"));
			movies.Add(new Movie("The Fox & The Hound", "Animated"));
			movies.Add(new Movie("Chicken Little", "Animated"));
			movies.Add(new Movie("Little Women", "Drama"));
			movies.Add(new Movie("Sinister", "Horror"));

			return movies;
		}
	}

}
