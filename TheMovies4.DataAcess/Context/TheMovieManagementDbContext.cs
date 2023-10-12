using Microsoft.EntityFrameworkCore;
using TheMovies.Domain.Models;

namespace TheMovies4.DataAcess.Context
{
    public class TheMovieManagementDbContext : DbContext
    {
        private readonly string connectionString;

        public TheMovieManagementDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Chuck Norris in Wonderland", Length = 8 },
                new Movie { MovieId = 2, Title = "Chuck Norris never dies", Length = 8 }
                );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Not defined" },
                new Genre { GenreId = 2, GenreName = "Chuck Norris has no genre" }
                );
        }
    }
}
