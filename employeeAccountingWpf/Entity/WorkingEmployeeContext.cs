using System.Data.Entity;

namespace employeeAccountingWpf.Entity
{
    public class WorkingEmployeeContext : DbContext
    {
        public WorkingEmployeeContext():
            base("EmployeeDBConnection")
        { }

 
        public DbSet<EmailEmployee> EmailEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<NumberPhoneEmployee> NumberPhoneEmployees { get; set; }
        public DbSet<OverTime> OverTimes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ServiceJob> ServiceJobs { get; set; }
        public DbSet<StatusEmployee> StatusEmployees { get; set; }
        public DbSet<StatusNumberPhoneEmployee> StatusNumberPhoneEmployees { get; set; }
        public DbSet<StatusWorkingDay> StatusWorkingDays { get; set; }
        public DbSet<TypeOfAward> TypeOfAwards { get; set; }
        public DbSet<WorkingDay> WorkingDays { get; set; }
    }
}