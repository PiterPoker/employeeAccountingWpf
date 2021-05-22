using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Controls;

namespace employeeAccountingWpf.ViewModels
{
    internal class EmployeesViewModel : BaseViewModel, IPageViewModel
    {

        public EmployeesViewModel()
        {
            Items1 = TestDataViewModel.CreateDataEmploees();
            Items2 = TestDataViewModel.CreateDataWorkingDays();
            Employee = new Employee();
        }

        public ObservableCollection<Employee> Items1 { get; set; }
        public ObservableCollection<WorkingDay> Items2 { get; set; }

        private RelayCommand saveCardCommand;
        public RelayCommand SaveCardCommand
        {
            get
            {
                return saveCardCommand ??
                    (saveCardCommand = new RelayCommand(obj =>
                    {
                        Employee employee = obj as Employee;
                        if(employee != null)
                        {
                            if (employee.IsCheckFlipped == false)
                            {
                                employee.IsCheckFlipped = true;
                            }
                            else if (employee.IsCheckFlipped == true)
                            {
                                var _employeeDel = Items1.Where(p => p.Id == employee.Id).FirstOrDefault();
                                _employee.FirstName = employee.FirstName;
                                _employee.LastName = employee.LastName;
                                _employee.MiddleName = employee.MiddleName;
                                employee.IsCheckFlipped = false;
                            }
                        }
                    },
                    (obj) => Items1.Count > 0));
            }
        }

        private RelayCommand _addCradCommand;
        public RelayCommand AddCardCommand
        {
            get
            {
                return _addCradCommand ??
                  (_addCradCommand = new RelayCommand(obj =>
                  {
                      Employee _employeesNew = new Employee()
                      {
                          FirstName = Employee.FirstName,
                          LastName = Employee.LastName,
                          MiddleName = Employee.MiddleName
                      };
                      Items1.Insert(0, _employeesNew);
                      IsCheck = false;
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Employee _employees = SelectEmployee;
                        if (_employees != null)
                        {
                            Items1.Remove(_employees);
                        }
                    },
                    (obj) => Items1.Count > 0));
            }
        }

        private Employee _employee { get; set; }
        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                OnPropertyChanged("Employee");
            }
        }

        private bool _isCheck;
        public bool IsCheck
        {
            get { return _isCheck; }
            set
            {
                _isCheck = value;
                OnPropertyChanged("IsCheck");
            }
        }

        private Employee _selectEmployee { get; set; }
        public Employee SelectEmployee
        {
            get { return _selectEmployee; }
            set
            {
                _selectEmployee = value;
                OnPropertyChanged("SelectEmployee");
            }
        }
    }
}