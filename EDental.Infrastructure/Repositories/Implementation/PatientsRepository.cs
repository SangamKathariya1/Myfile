using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDental.Data;
using EDental.Data.Models; // Replace with the namespace where your `Patient` model is defined
using EDental.Infrastructure.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EDental.Infrastructure.Repositories.Implementation
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly EDentalDbContext _context;

        public PatientsRepository(EDentalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
