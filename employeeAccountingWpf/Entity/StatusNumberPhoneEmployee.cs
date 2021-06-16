using employeeAccountingWpf.Interface;
using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class StatusNumberPhoneEmployee : IStatusNumberPhoneEmployee
    {
        public int Id { get; set; } 
        public string NameStatusNumberPhone { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<NumberPhoneEmployee> NumberPhoneEmployees { get; set; }
        StatusNumberPhoneEmployee(){
            NumberPhoneEmployees = new List<NumberPhoneEmployee>();
        }
    }
}
