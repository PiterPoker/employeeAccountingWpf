using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface IStatusNumberPhoneEmployee
    {
        int Id { get; set; }
        string NameStatusNumberPhone { get; set; }
        string Abbreviation { get; set; }
        ICollection<NumberPhoneEmployee> NumberPhoneEmployees { get; set; }
    }
}
