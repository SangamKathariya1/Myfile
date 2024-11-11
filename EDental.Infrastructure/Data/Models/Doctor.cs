using EDental.Data.Enums;

namespace EDental.Data.Models;
public class Doctor
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public required string Address { get; set; }
    public required string Phone { get; set; }
    public required string NDCNumber { get; set; }
    public required string Qualification { get; set; }
    public required string Specialization { get; set; }
    public Gender Gender { get; set; }
    public DateTime DOB { get; set; }
}