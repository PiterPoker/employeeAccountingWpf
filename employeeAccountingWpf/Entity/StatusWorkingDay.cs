using employeeAccountingWpf.Interface;
using employeeAccountingWpf.Models;
using System;
using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class StatusWorkingDay : IStatusWorkingDay
    {
        public int Id { get; set; }
        public string NameStatusWorkingDay { get; set; }      
        public string Abbreviation { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime StartWorkingDay { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public StatusWorkingDay()
        {
            WorkingDays = new List<WorkingDay>();
        }
    }
}
