using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    // casting content to be of type Show. It had been type StreamingContent - which can be either Show or Movie.  This one is a Show (not a Movie)
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                // "content is Movie" is the same as "content.GetType() == typeof(Movie)"
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        // Get all Shows method
        public List<Show> GetAllShows()
        {
            // Declare a List of type Show as a new instance of list of type Show. Name it allShows
            List<Show> allShows = new List<Show>();
            // For each element of _contentDirectory, capture the element in the variable content (of type StreamingContent)
            foreach(StreamingContent content in _contentDirectory)
            {
                // if content (the current element from the _contentDirectory) is of type Show
                if(content is Show)
                {
                    // Cast the value of the content variable from type 'StreamingContent' to type 'Show'  Add the value of (the recast variable) content to the list allShows
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        // Get all Movies method
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        // Afternoon Challenge
        // Get by RunTime/AverageRunTime
        // Get Shows with over x episodes
        // Get Shows/Movie By Rating

    }
}
