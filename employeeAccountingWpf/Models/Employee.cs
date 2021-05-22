using employeeAccountingWpf.ViewModels;
using System.Collections.ObjectModel;

namespace employeeAccountingWpf.Models
{
    public class Employee : BaseViewModel
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private bool _isCheckFlipped;

        public int Id { 
            get { 
                return id; 
            }
            set { }
        }

        public string FirstName { 
            get {
                return firstName;
            } 
            set {
                firstName = value;
                OnPropertyChanged("FirstName");
            } 
        }

        public string MiddleName {
            get {
                return middleName;
            }
            set {
                middleName = value;
                OnPropertyChanged("MiddleName");
            } 
        }

        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public bool IsCheckFlipped
        {
            get { return _isCheckFlipped; }
            set
            {
                _isCheckFlipped = value;
                OnPropertyChanged("IsCheckFlipped");
            }
        }
        public ObservableCollection<WorkingDay> WorkingDays { get; set; }
    }
}
