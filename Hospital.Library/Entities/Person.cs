using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblPerson")]
    public class Person:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; } = default!;
        public bool IsMarried { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}
