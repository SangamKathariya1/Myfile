using EDental.Data.Models;

namespace EDental.Infrastructure.Data.Models;
public class Treatment
{
    public int Id { get; set; }
    public double Cost { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public int DiagnosisId { get; set; }
    public Diagnosis Diagnosis { get; set; }
}