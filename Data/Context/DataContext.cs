using Microsoft.EntityFrameworkCore;
using ShopCqrsMediator.Domain.Entities;

namespace ShopCqrsMediator.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}