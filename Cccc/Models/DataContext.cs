using System.Data.Entity;

namespace Cccc.Models
{
    public class DataContext : DbContext
    {
        // Use the constructor to target a specific named connection string
        public DataContext()
            : base("name=ConnStr")
        {

        }

        // Disable creation of the EdmMetadata table.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}




