namespace Api_Disney.Models;

// Many to many Relationships
public class MovieCharacter
{
    public int IdCharacter {set;get;}
    public Character? Character {set;get;}
    public int IdMovie {set;get;}
    public Movie? Movie {set;get;}
}
