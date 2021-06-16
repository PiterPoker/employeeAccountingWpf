using employeeAccountingWpf.Interface;
using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class Position : IPosition
    {
        public int Id { get; set; }
        public string NamePosition { get; set; }
        public string Abbreviation { get; set; }    
        public ICollection<Employee> Employees { get; set; }
        public Position()
        {
            Employees = new List<Employee>();
        }    
    }
}
