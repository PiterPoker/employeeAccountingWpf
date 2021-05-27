using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class StatusEmployee
    {
        public int  Id { get; set; }
        public string NameStatusEmployee { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public StatusEmployee()
        {
            Employees = new List<Employee>();
        }
    }
}
