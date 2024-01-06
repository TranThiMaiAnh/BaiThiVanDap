using Microsoft.EntityFrameworkCore;


namespace TranThiMaiAnh093.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<TranThiMaiAnh> TranThiMaiAnh { get; set;} 
         public DbSet<Khoa> Khoa { get; set;} 

    }
}