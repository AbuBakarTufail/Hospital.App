using Microsoft.EntityFrameworkCore;

namespace Hospital.Library.Entities
{
    public class HmsContext:DbContext
    {
        public HmsContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasOne(x => x.Doctor).WithMany(x => x.Patients)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Patient>().HasOne(x => x.Person).WithMany(x => x.Patients)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Patient>().HasOne(x => x.PatientType).WithMany(x => x.Patients)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDesignation> EmployeeDesignations { get; set; }
        public DbSet<EmployeeRecord> EmployeeRecords { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientTest> PatientTests { get; set; }
        public DbSet<PatientType> PatientTypes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}
