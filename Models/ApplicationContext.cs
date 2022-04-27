using Microsoft.EntityFrameworkCore;

namespace lametsy_server.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CalcResult> CalcResults { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CalcResultDB;Trusted_Connection=True;");
        }
    }
}
