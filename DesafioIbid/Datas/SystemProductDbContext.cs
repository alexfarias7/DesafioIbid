using DesafioIbid.Datas.Maps;
using DesafioIbid.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioIbid.Datas
{
    public class SystemProductDbContext : DbContext
    {
        public SystemProductDbContext(DbContextOptions<SystemProductDbContext> options)
            :base(options)
        { }

        public DbSet<ProductModel> ProductsTable {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();


            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DataBase"));


        }

    }
}
