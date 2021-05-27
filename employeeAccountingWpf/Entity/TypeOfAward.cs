using System.Collections.Generic;

namespace employeeAccountingWpf.Entity
{
    public class TypeOfAward
    {
        public int Id { get; set; }
        public string NammeTypeOfAward { get; set; }
        public double Coefficient { get; set; }
        public ICollection<OverTime> OverTimes { get; set; }
        public TypeOfAward()
        {
            OverTimes = new List<OverTime>();
        }
    }
}
