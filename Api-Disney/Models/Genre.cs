namespace Api_Disney.Models;

public class Genre
{
        public int IdGenre {set;get;}
        public string? Name {set;get;}
        public string? Image_url {set;get;}   

        // Collection navigation property fk_GenreMovie
        public IList<GenreMovie>? GenreMovie { get; set; }
}
