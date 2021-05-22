using employeeAccountingWpf.ViewModels;
using System;

namespace employeeAccountingWpf.Models
{
    public class WorkingDay : BaseViewModel
    {
        private int id;
        private Employee employeesId;
        private int operatingId;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private bool isSelected;

        public int Id {
            get {
                return id;
            }
            set {
                id = value;
                OnPropertyChanged("Id");
            } 
        }

        public Employee EmployeesId {
            get {
                return employeesId;
            }
            set {
                employeesId = value;
                OnPropertyChanged("EmployeesId");
            } 
        }

        public int OperatingId {
            get {
                return operatingId;
            }
            set {
                operatingId = value;
                OnPropertyChanged("OperatingId");
            } 
        }

        public DateTime StartDateTime {
            get {
                return startDateTime;
            }
            set {
                startDateTime = value;
                OnPropertyChanged("StartDateTime");
            }
        }

        public DateTime EndDateTime { 
            get {
                return endDateTime;
            }
            set {
                endDateTime = value;
                OnPropertyChanged("EndDateTime");
            } 
        }

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                if (isSelected == value) return;
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }
    }
}
