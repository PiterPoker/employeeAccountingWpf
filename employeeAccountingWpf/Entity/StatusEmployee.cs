using employeeAccountingWpf.Interface;
using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class StatusEmployee : IStatusEmployee
    {
        public int  Id { get; set; }
        public string NameStatusEmployee { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public StatusEmployee()
        {
            Employees = new List<Employee>();
        }

        public StatusEmployee(string nameStatusEmployee) : this(nameStatusEmployee, "")
        {
        }

        public StatusEmployee(string nameStatusEmployee, string abbreviation)
        {
            NameStatusEmployee = nameStatusEmployee;
            Abbreviation = abbreviation;
            Employees = new List<Employee>();
        }
    }
}
