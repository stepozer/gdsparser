using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=ms;database=gdsparser;Allow User Variables=True");
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
        }
    }
}