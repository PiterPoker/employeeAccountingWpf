using employeeAccountingWpf.Interface;
using System;

namespace employeeAccountingWpf.Entity
{
    public class WorkingDay : IWorkingDay
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int? StatusWorkingDayId { get; set; }
        public StatusWorkingDay StatusWorkingDay { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
