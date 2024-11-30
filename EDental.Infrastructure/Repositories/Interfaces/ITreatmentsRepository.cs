using EDental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces
{
    public interface ITreatmentsRepository
    {
        // Define method signatures for the repository, e.g.:
        Task<IEnumerable<Treatment>> GetAllTreatmentsAsync();
        Task<Treatment> GetTreatmentByIdAsync(int id);
        Task AddTreatmentAsync(Treatment treatment);
        Task UpdateTreatmentAsync(Treatment treatment);
        Task DeleteTreatmentAsync(int id);
    }
}
