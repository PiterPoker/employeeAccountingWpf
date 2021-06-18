using employeeAccountingWpf.DAL;
using employeeAccountingWpf.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.ViewModels
{
    public static class LoadDataDBContext
    {
        private static UnitOfWork _unitOfWork = new UnitOfWork();
        public static ObservableCollection<IEmployee> Employees { get; set; }
        public static ObservableCollection<IStatusEmployee> StatusEmployees { get; set; }
        public static ObservableCollection<IStatusWorkingDay> StatusWorkingDays { get; set; }

        public static void LoadDataBase()
        {
            Employees = GetEmployees();
            StatusEmployees = GetStatusEmployees();
            StatusWorkingDays = GetStatusWorkingDays();
        }

        public static ObservableCollection<IEmployee> GetEmployees()
        {
            return new ObservableCollection<IEmployee>(_unitOfWork.EmployeeRepository.Get());
        }

        public static ObservableCollection<IStatusEmployee> GetStatusEmployees()
        {
            return new ObservableCollection<IStatusEmployee>(_unitOfWork.StatusEmployeeRepository.Get());
        }

        public static ObservableCollection<IStatusWorkingDay> GetStatusWorkingDays()
        {
            return  new ObservableCollection<IStatusWorkingDay>(_unitOfWork.StatusWorkingDayRepository.Get());
        }
    }
}
