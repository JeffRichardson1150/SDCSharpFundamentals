using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType

    {
        Horror =1,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        Romance
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA
    }
    public class StreamingContent
    {
        // POCO - Plain Old C# Object
        // create a property using prop <tab> <tab>
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public int StarRating { get; set; }
        // we're going to create IsFamilyFriendly based on MaturityRating. We won't pass in IsFamilyFriendly
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                // since we "case" values in the same order they're defined,
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:      
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                } //   switch(MaturityRating)
                // Another way to do this
                // if((int)MaturityRating > 1)
                // {
                //     return false;
                // }
                // else
                // {
                //     return true;
                // }
            }  //  getter for IsFamilyFriendly
        }  // public bool IsFamilyFriendly

        // we need to add the enum type into the Class if we want it to be available in references to this class
        public GenreType TypeOfGenre { get; set; }

        // empty constructor before an overloaded constructor
        public StreamingContent() { }
        
        //public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, bool isFamilyFriendly, GenreType typeOfGrenre) 

        // AFter we built our switch, we need to remove isFamilyFriendly
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, GenreType typeOfGrenre) 
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            // IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = typeOfGrenre;
        } //  StreamingContent overloaded constructor
    }  //  public class StreamingContent
} //  namespace _07_RepositoryPattern_Repository
