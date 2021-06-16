using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IServiceJob
    {
        int Id { get; set; }
        string NameService { get; set; }
        string Abbreviation { get; set; }
        ICollection<Employee> Employees { get; set; }
    }
}
