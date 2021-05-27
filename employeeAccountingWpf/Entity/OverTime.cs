using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class OverTime   
    {
        public int Id { get; set; }      
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? TypeOfAwardId { get; set; }
        public TypeOfAward TypeOfAward { get; set; }
         public ICollection<WorkingDay> WorkingDays { get; set; }
        public OverTime()
        {
            WorkingDays = new List<WorkingDay>();
        }
    }
}
