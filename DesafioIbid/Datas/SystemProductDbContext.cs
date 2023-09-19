using DesafioIbid.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioIbid.Datas
{
    public class SystemProductDbContext : DbContext
    {
        public SystemProductDbContext(DbContextOptions<SystemProductDbContext> options)
            :base(options)
        { }

        public DbSet<ProductModel> Products { get; set; }
    }
}
