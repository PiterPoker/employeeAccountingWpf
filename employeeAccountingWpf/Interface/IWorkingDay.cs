using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IWorkingDay
    {
        int Id { get; set; }
        DateTime StartDateTime { get; set; }
        DateTime EndDateTime { get; set; }
        int? StatusWorkingDayId { get; set; }
        StatusWorkingDay StatusWorkingDay { get; set; }
        int? EmployeeId { get; set; }
        Employee Employee { get; set; }
    }
}
