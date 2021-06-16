using employeeAccountingWpf.Interface;

namespace employeeAccountingWpf.Entity
{
    public class NumberPhoneEmployee : INumberPhoneEmployee
    {
        public int Id { get; set; }
        public string NumberPhone { get; set; }
        public Employee Employee { get; set; }
        public int? StatusNumberPhoneEmployeeId { get; set; }
        public StatusNumberPhoneEmployee StatusNumberPhoneEmployee { get; set; }       
    }
}
