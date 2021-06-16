using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface INumberPhoneEmployee
    {
        int Id { get; set; }
        string NumberPhone { get; set; }
        Employee Employee { get; set; }
        int? StatusNumberPhoneEmployeeId { get; set; }
        StatusNumberPhoneEmployee StatusNumberPhoneEmployee { get; set; }
    }
}
