namespace Api_Disney.Models;

public class Genre
{
        public int GenreID {set;get;}
        public string? Name {set;get;}
        public string? Image_url {set;get;}   

        // Collection navigation property
        public IList<GenreMovie>? GenreMovie { get; set; }
}
