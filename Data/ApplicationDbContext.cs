namespace StudentRegistration.Data
{
    using Microsoft.EntityFrameworkCore;
    using StudentRegistration.Models; 
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Qualifications)
                .WithOne(q => q.Student)
                .HasForeignKey(q => q.StudentId);
        }
    }
}
