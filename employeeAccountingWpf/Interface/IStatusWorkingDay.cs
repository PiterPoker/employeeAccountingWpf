using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IStatusWorkingDay
    {
        int Id { get; set; }
        string NameStatusWorkingDay { get; set; }
        string Abbreviation { get; set; }
        int NumberOfHours { get; set; }
        DateTime StartWorkingDay { get; set; }
        ICollection<WorkingDay> WorkingDays { get; set; }
    }
}
