using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        int? PositionId { get; set; }
        Position Position { get; set; }
        int? ServiceJobId { get; set; }
        ServiceJob ServiceJob { get; set; }
        EmailEmployee EmailEmployee { get; set; }
        int? StatusEmployeeId { get; set; }
        StatusEmployee StatusEmployee { get; set; }
        ICollection<OverTime> OverTimes { get; set; }
        ICollection<WorkingDay> WorkingDays { get; set; }
        ICollection<EmailEmployee> EmailEmployees { get; set; }
    }
}
