using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces
{
    public interface IDoctorsRepository
    {
        public List<Doctor> Get();
        public Doctor Get(int id);
        public int Insert(Doctor doctor);
        public int Edit(Doctor doctor);
        public int Delete(Doctor doctor);
        //object Delete(int doctor);
    }
}
