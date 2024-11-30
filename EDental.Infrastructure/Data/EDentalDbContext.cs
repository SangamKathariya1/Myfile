using Microsoft.EntityFrameworkCore;
using EDental.Data.Models;
using EDental.Infrastructure.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EDental.Data
{
    public class EDentalDbContext : IdentityDbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EDentalDb;Integrated Security=True;");
            }
        }
    }
}
