using Api_Disney.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Disney.Data;

public class DisneyContext : DbContext
{
    public DisneyContext(DbContextOptions<DisneyContext> options): base(options)
    {  
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Foreign keys as composite primary key in the joining table
        modelBuilder.Entity<MovieCharacter>().HasKey(mc => new {mc.IdCharacter, mc.IdMovie});
        modelBuilder.Entity<GenreMovie>().HasKey(gm => new {gm.IdGenre, gm.IdMovie});       
    }

    public DbSet<Character>? Characters {set;get;}
    public DbSet<MovieCharacter>? MoviesCharacters {set;get;}
    public DbSet<Movie>? Movies {set;get;}
    public DbSet<GenreMovie>? GenresMovies {set;get;}
    public DbSet<Genre>? Genres {set;get;}


    
}
