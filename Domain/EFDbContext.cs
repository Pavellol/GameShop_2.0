using GameStoreShop_2.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreShop_2.Data
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {
        }

        public DbSet<Games> Games { get; set; }
    }
}
