namespace Api_Disney.Models;

// Many to many Relationships
public class GenreMovie
{
    // reference fk_genre
    public int IdGenre {set;get;}
    // reference navigation properties
    public Genre? Genre {set;get;}
    public int IdMovie {set;get;}
    public Movie? Movie {set;get;}
}
