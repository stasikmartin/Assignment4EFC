using AdultsWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AdultsWebApi.Persistance
{
    public class UsersContext : DbContext
    {
        
        public DbSet<User> users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Users.db");
        }
        
        
    }
}