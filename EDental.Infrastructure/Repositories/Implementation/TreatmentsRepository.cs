using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDental.Data;
using EDental.Data.Models; // Replace with the namespace where your `Treatment` model is defined
using EDental.Infrastructure.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EDental.Infrastructure.Repositories.Implementation
{
    public class TreatmentsRepository : ITreatmentsRepository
    {
        private readonly EDentalDbContext _context;

        public TreatmentsRepository(EDentalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Treatment>> GetAllTreatmentsAsync()
        {
            return await _context.Treatments.ToListAsync();
        }

        public async Task<Treatment> GetTreatmentByIdAsync(int id)
        {
            return await _context.Treatments.FindAsync(id);
        }

        public async Task AddTreatmentAsync(Treatment treatment)
        {
            await _context.Treatments.AddAsync(treatment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTreatmentAsync(Treatment treatment)
        {
            _context.Treatments.Update(treatment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTreatmentAsync(int id)
        {
            var treatment = await _context.Treatments.FindAsync(id);
            if (treatment != null)
            {
                _context.Treatments.Remove(treatment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
