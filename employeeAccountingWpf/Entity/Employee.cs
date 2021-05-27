using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }        
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int? ServiceJobId { get; set; }
        public ServiceJob ServiceJob { get; set; }
        public EmailEmployee EmailEmployee { get; set; }        
        public int? StatusEmployeeId { get; set; }
        public StatusEmployee StatusEmployee { get; set; }
        public StatusNumberPhoneEmployee StatusNumberPhoneEmployee { get; set; }
        public ICollection<OverTime> OverTimes { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public Employee()
        {
            WorkingDays = new List<WorkingDay>();
            OverTimes = new List<OverTime>();
        }
    }
}
