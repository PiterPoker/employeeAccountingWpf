using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Interface
{
    public interface ITypeOfAward
    {
        int Id { get; set; }
        string NammeTypeOfAward { get; set; }
        double Coefficient { get; set; }
        ICollection<OverTime> OverTimes { get; set; }
    }
}
