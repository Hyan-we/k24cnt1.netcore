using Microsoft.EntityFrameworkCore;

namespace NguyenHuyAnh_2410900003_exam.Models
{
    public class NhaDbContext : DbContext
    {
        public NhaDbContext(DbContextOptions<NhaDbContext> options) : base(options)
        {
        }

        public DbSet<NhaStudent> NhaStudents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NhaStudent>().ToTable("NhaStudent");
        }
    }
}

