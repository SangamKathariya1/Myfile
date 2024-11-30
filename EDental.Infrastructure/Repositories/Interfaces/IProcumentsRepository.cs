using EDental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces
{
    public interface IProcurementsRepository
    {
        // Define method signatures for the repository, e.g.:
        Task<IEnumerable<Procurement>> GetAllProcurementsAsync();
        Task<Procurement> GetProcurementByIdAsync(int id);
        Task AddProcurementAsync(Procurement procurement);
        Task UpdateProcurementAsync(Procurement procurement);
        Task DeleteProcurementAsync(int id);
    }
}
