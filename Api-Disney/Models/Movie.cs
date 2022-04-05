namespace Api_Disney.Models;

public class Movie
{
        public int IdMovie {set;get;}
        public string? Image_url {set;get;}
        public string? Title {set;get;}
        public string? Date_creation {set;get;}
        public int Rating {set;get;}  

        // Collection navigation property 
        public IList<GenreMovie>? GenreMovie { get; set; }

        // Collection navigation property 
        public IList<MovieCharacter>? MovieCharacter { get; set; }

}
