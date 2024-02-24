using Microsoft.EntityFrameworkCore;
using Mission06_Lyons.Models;

namespace Mission6.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options)
        {
        }

        public DbSet<NewMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
