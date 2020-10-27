using Microsoft.EntityFrameworkCore;
using dotnet__rpg.Models;

namespace dotnet__rpg.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}