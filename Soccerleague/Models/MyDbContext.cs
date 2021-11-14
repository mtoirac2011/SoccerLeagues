using Microsoft.EntityFrameworkCore;

namespace Soccerleague.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<League> League { get; set; }
        public DbSet<Team> Team { set; get; }
        public DbSet<Player> Player { get; set; }
    }
}
