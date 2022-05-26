using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> option) : base(option)
        {

        } 

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
