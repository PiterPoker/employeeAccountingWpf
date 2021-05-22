using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using System.Collections.ObjectModel;

namespace employeeAccountingWpf.ViewModels
{
    internal class SchedulesViewModel : IPageViewModel
    {
        public SchedulesViewModel()
        {
            Items1 = TestDataViewModel.CreateDataEmploees();
            Items2 = TestDataViewModel.CreateDataWorkingDays();
            _employees = Items1[0];

        }

        public Employee _employees { get; set; }
        public ObservableCollection<Employee> Items1 { get; set; }
        public ObservableCollection<WorkingDay> Items2 { get; set; }
    }
}