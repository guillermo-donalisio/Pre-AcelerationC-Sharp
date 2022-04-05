namespace Api_Disney.Models;

// Many to many Relationships
public class GenreMovie
{
    public int IdGenre {set;get;}
    public Genre? Genre {set;get;}
    public int IdMovie {set;get;}
    public Movie? Movie {set;get;}
}
