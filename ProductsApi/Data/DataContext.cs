using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
 
namespace ProductsApi.Data
{
    public class DataContext: DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);
        }
 
        public DbSet<Product> Products { get; init; }
    }
}