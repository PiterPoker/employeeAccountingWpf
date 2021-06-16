using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IOverTime
    {
        int Id { get; set; }
        int? EmployeeId { get; set; }
        Employee Employee { get; set; }
        int? TypeOfAwardId { get; set; }
        TypeOfAward TypeOfAward { get; set; }
        ICollection<WorkingDay> WorkingDays { get; set; }
    }
}
