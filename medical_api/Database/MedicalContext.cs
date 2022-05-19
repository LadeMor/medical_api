using medical_api.Models;
using Microsoft.EntityFrameworkCore;

namespace medical_api.Database
{
    public class MedicalContext : DbContext
    {
        public DbSet<Patient> patients { get; set; }
        public DbSet<Diagnose> diagnoses { get; set; }
        public DbSet<Course> courses { get; set; }
        public MedicalContext(DbContextOptions<MedicalContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Diagnose)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.diagnosis);
            
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Course)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.courses);
        }
    }
}