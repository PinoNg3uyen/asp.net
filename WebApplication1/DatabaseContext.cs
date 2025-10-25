using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Entities;

namespace WebApplication1.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<NhomHangEntity> NhomHangs { get; set; }
        public DbSet<HangHoaEntity> HangHoas { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
