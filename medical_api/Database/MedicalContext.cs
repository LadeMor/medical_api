using medical_api.Models;
using Microsoft.EntityFrameworkCore;

namespace medical_api.Database
{
    public class MedicalContext : DbContext
    {
        public MedicalContext(DbContextOptions<MedicalContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<Diagnose> diagnoses { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}