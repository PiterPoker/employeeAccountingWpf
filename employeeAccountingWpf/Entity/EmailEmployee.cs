namespace employeeAccountingWpf.Entity
{
    public class EmailEmployee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }        
        public Employee Employee { get; set; }
    }
}
