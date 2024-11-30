using EDental.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces
{
    public interface IAppointmentsRepository
    {
        // Define method signatures for the repository, e.g.:
        Task<IEnumerable<Appointment>> GetAppointmentsAsync();
        Task<Appointment> GetAppointmentByIdAsync(int id);
        Task AddAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
