using Abc.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Abc.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MCELEBIDELL\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}