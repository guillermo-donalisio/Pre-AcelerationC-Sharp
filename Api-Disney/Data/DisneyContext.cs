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
    }

    public DbSet<Character>? Characters {set;get;}
    public DbSet<MovieCharacter>? MoviesCharacters {set;get;}
    public DbSet<Movie>? Movies {set;get;}
    public DbSet<GenreMovie>? GenresMovies {set;get;}
    public DbSet<Genre>? Genres {set;get;}


    
}
