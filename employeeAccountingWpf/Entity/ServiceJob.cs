using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class ServiceJob
    {
        public int Id { get; set; }
        public string NameService { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ServiceJob()
        {
            Employees = new List<Employee>();
        }      
    }
}
