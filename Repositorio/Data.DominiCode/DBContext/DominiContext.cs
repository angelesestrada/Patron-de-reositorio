using Data.DominiCode.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DominiCode.DBContext
{
    public class DominiContext : DbContext
    {
        public DbSet<ClientCategory> ClientCategories { get; set; }
        public DbSet<Clients> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=DominiBD;Trusted_Connection=True;");
        }
    }
}