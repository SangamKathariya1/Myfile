using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Implementation
{
    public class AppointmentsRepository(EDentalDbContext dbContext): IAppointmentsRepository
      
    {
        private readonly EDentalDbContext db = dbContext;

        public List<Doctor> Get()
        {
            return dbContext.Doctors.ToList(); // Executes "SELECT * FROM Doctors"
        }

        // Get a doctor by ID
        public Doctor Get(int id)
        {
            return dbContext.Doctors.Find(id);
        }

        // Insert a new doctor
        public int Insert(Doctor doctor)
        {
            dbContext.Doctors.Add(doctor);
            return dbContext.SaveChanges();
        }

        // Update an existing doctor
        public int Edit(Doctor doctor)
        {
            dbContext.Doctors.Update(doctor);
            return dbContext.SaveChanges();
        }

        // Delete a doctor
        public int Delete(Doctor doctor)
        {
            dbContext.Doctors.Remove(doctor);
            return dbContext.SaveChanges();
        }
    }
}
