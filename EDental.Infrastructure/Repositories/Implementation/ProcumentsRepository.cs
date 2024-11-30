using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDental.Data;
using EDental.Data.Models; // Replace with the namespace where your `Procurement` model is defined
using EDental.Infrastructure.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EDental.Infrastructure.Repositories.Implementation
{
    public class ProcurementsRepository : IProcurementsRepository
    {
        private readonly EDentalDbContext _context;

        public ProcurementsRepository(EDentalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Procurement>> GetAllProcurementsAsync()
        {
            return await _context.Procurements.ToListAsync();
        }

        public async Task<Procurement> GetProcurementByIdAsync(int id)
        {
            return await _context.Procurements.FindAsync(id);
        }

        public async Task AddProcurementAsync(Procurement procurement)
        {
            await _context.Procurements.AddAsync(procurement);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProcurementAsync(Procurement procurement)
        {
            _context.Procurements.Update(procurement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProcurementAsync(int id)
        {
            var procurement = await _context.Procurements.FindAsync(id);
            if (procurement != null)
            {
                _context.Procurements.Remove(procurement);
                await _context.SaveChangesAsync();
            }
        }
    }
}
