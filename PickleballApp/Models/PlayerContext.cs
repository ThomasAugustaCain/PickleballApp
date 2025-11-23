using Microsoft.EntityFrameworkCore;
namespace PickleballApp.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        { }


        public DbSet<Player> Players { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    FirstName = "Augusta",
                    LastName = "Cain",
                    Gender = "Male"
                }, 
                new Player
                {
                    PlayerId = 2,
                    FirstName = "Brian",
                    LastName = "Cain",
                    Gender = "Male"
                },
                new Player
                {
                    PlayerId = 3,
                    FirstName = "Amethyst Cain",
                    LastName = "Cain",
                    Gender = "Female"
                }
                );
        }

    }
}
