namespace Api_Disney.Models;

// Many to many Relationships
public class MovieCharacter
{
    public int CharacterID {set;get;}
    public Character? Character {set;get;}
    public int MovieID {set;get;}
    public Movie? Movie {set;get;}
}
