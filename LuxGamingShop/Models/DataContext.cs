using Microsoft.EntityFrameworkCore;

namespace LuxGamingShop.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }

        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gaming> Gamings { get; set; }
        public DbSet<HomePageIntro> HomePageIntros {  get; set; }
        public DbSet<HomePageTrendingGames> HomePageTrendingGames { get; set; }
    }
}
