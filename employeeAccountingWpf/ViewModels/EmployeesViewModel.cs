using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace employeeAccountingWpf.ViewModels
{
    public class EmployeesViewModel : BaseViewModel, IPageViewModel
    {

        public EmployeesViewModel()
        {
            Items1 = TestDataViewModel.CreateDataEmploees();
            Items2 = TestDataViewModel.CreateDataWorkingDays();
            EmployeeModel = new EmployeeModel();
        }

        public ObservableCollection<EmployeeModel> Items1 { get; set; }
        public ObservableCollection<WorkingDayModel> Items2 { get; set; }

        private RelayCommand saveCardCommand;
        public RelayCommand SaveCardCommand
        {
            get
            {
                return saveCardCommand ??
                    (saveCardCommand = new RelayCommand(obj =>
                    {
                        EmployeeModel employee = obj as EmployeeModel;
                        if(employee != null)
                        {
                            if (employee.IsCheckFlipped == false)
                            {
                                employee.IsCheckFlipped = true;
                            }
                            else if (employee.IsCheckFlipped == true)
                            {
                                var _employeeDel = Items1.Where(p => p.Id == employee.Id).FirstOrDefault();
                                _employeeDel.FirstName = employee.FirstName;
                                _employeeDel.LastName = employee.LastName;
                                _employeeDel.MiddleName = employee.MiddleName;
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
                      EmployeeModel _employeesNew = new EmployeeModel()
                      {
                          FirstName = EmployeeModel.FirstName,
                          LastName = EmployeeModel.LastName,
                          MiddleName = EmployeeModel.MiddleName
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
                        EmployeeModel _employees = SelectEmployee;
                        if (_employees != null&& _employees.IsCheckDelete==true)
                        {
                            Items1.Remove(_employees);
                        }else if(_employees.IsCheckDelete == false) 
                        {
                            MessageBox.Show("Сотрудник не может быть удален т. к. он работал посдедние 5 лет. Дождитесь срока окончания хранения карточки.");
                        }
                    },
                    (obj) => Items1.Count > 0));
            }
        }

        private EmployeeModel _employeeModel { get; set; }
        public EmployeeModel EmployeeModel
        {
            get { return _employeeModel; }
            set
            {
                _employeeModel = value;
                OnPropertyChanged("EmployeeModel");
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

        private EmployeeModel _selectEmployee { get; set; }
        public EmployeeModel SelectEmployee
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