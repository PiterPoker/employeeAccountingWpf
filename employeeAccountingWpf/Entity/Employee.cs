using employeeAccountingWpf.Interface;
using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class Employee : IEmployee
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
        public ICollection<OverTime> OverTimes { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public ICollection<EmailEmployee> EmailEmployees { get; set; }
        public Employee()
        {
            EmailEmployees = new List<EmailEmployee>();
            WorkingDays = new List<WorkingDay>();
            OverTimes = new List<OverTime>();
        }
    }
}
