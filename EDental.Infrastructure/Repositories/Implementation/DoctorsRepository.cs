
using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;

namespace EDental.Infrastructure.Repositories.Implementations;

public class DoctorsRepository(EDentalDbContext dbContext)
{
    private readonly EDentalDbContext db = dbContext;

    public List<Doctor> Get()
    {
        var doctors = db.Doctors.ToList(); // select * from doctor
        return doctors;
    }

    public Doctor Get(int id)
    {
        var doctor = db.Doctors.Find(id);
        return doctor;
    }

    public int Insert(Doctor doctor)
    {
        db.Doctors.Add(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public int Edit(Doctor doctor)
    {
        db.Doctors.Update(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public int Delete(Doctor doctor)
    {
        db.Doctors.Remove(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public object Delete(int doctor)
    {
        throw new NotImplementedException();
    }
}
