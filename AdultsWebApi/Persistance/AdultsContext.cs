using AdultsWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AdultsWebApi.Persistance
{
    public class AdultsContext : DbContext
    {
        
        
        public DbSet<Adult> adults { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Adults.db");
        }
        
    }
}