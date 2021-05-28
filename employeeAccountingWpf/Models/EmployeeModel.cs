using employeeAccountingWpf.ViewModels;
using System.Collections.ObjectModel;

namespace employeeAccountingWpf.Models
{
    public class EmployeeModel : BaseViewModel
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private bool _isCheckFlipped;
        private bool _isCheckDelete;

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

        public bool IsCheckDelete
        {
            get { return _isCheckDelete; }
            set
            {
                _isCheckDelete = value;
                OnPropertyChanged("IsCheckDelete");
            }
        }
        public ObservableCollection<WorkingDayModel> WorkingDays { get; set; }
    }
}
