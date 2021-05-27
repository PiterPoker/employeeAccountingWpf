using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class StatusWorkingDay   
    {
        public int Id { get; set; }
        public string NameStatusWorkingDay { get; set; }      
        public string Abbreviation { get; set; }
        public int NumberOfHours { get; set; }  
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public StatusWorkingDay()
        {
            WorkingDays = new List<WorkingDay>();
        }
    }
}
