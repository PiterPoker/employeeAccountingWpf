using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IEmailEmployee
    {
        int Id { get; set; }
        string Email { get; set; }
        string Domain { get; set; }
        Employee Employee { get; set; }
        int? EmployeeId { get; set; }
    }
}
