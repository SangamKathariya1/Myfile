using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EDental.Infrastructure.Repositories.Implementations
{
    public class DiagnosesRepository : IDiagnosesRepository
    {
        private readonly EDentalDbContext db;

        public DiagnosesRepository(EDentalDbContext dbContext)
        {
            db = dbContext;
        }

        public List<Diagnosis> Get()
        {
            var diagnoses = db.Diagnoses.ToList(); // select * from diagnoses
            return diagnoses;
        }

        public Diagnosis Get(int id)
        {
            var diagnoses = db.Diagnoses.Find(id);
            return diagnoses;
        }

        public int Insert(Diagnosis diagnosis)
        {
            db.Diagnoses.Add(diagnosis);
            var rowsAffected = db.SaveChanges();
            return rowsAffected;
        }

        public int Edit(Diagnosis diagnosis)
        {
            db.Diagnoses.Update(diagnosis);
            var rowsAffected = db.SaveChanges();
            return rowsAffected;
        }

        public int Delete(Diagnosis diagnosis)
        {
            db.Diagnoses.Remove(diagnosis);
            var rowsAffected = db.SaveChanges();
            return rowsAffected;
        }

        public object Delete(int id)
        {
            throw new NotImplementedException();
        }

        int IDiagnosesRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
