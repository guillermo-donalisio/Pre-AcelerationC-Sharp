namespace Api_Disney.Models;

public class Character
{
        public int CharacterID {set;get;}
        public string? Image_url {set;get;}
        public string? Name {set;get;}
        public int Age {set;get;}
        public decimal Weight {set;get;}
        public string? Story {set;get;}
        
        // Collection navigation property 
        public IList<MovieCharacter>? MovieCharacter { get; set; }

}
