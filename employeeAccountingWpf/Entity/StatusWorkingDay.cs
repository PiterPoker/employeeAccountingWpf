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
        public StatusWorkingDay():this("")
        {            
        }
        public StatusWorkingDay(string nameStatusWorkingDay) : this(nameStatusWorkingDay, "")
        {
        }
        public StatusWorkingDay(string nameStatusWorkingDay, string abbreviation) : this(nameStatusWorkingDay, abbreviation, 0)
        {
        }
        public StatusWorkingDay(string nameStatusWorkingDay, string abbreviation, int numberOfHours) : this(nameStatusWorkingDay, abbreviation, numberOfHours, DateTime.Now)
        {
        }
        public StatusWorkingDay(string nameStatusWorkingDay, string abbreviation, int numberOfHours, DateTime startWorkingDay)
        {
            NameStatusWorkingDay = nameStatusWorkingDay;
            Abbreviation = abbreviation;
            NumberOfHours = numberOfHours;
            StartWorkingDay = startWorkingDay;
            WorkingDays = new List<WorkingDay>();
        }
    }
}
