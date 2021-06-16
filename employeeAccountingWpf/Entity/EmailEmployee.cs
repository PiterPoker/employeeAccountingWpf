using employeeAccountingWpf.Interface;

namespace employeeAccountingWpf.Entity
{
    public class EmailEmployee : IEmailEmployee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }        
        public Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
    }
}
