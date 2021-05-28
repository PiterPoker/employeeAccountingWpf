using employeeAccountingWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Models
{
    public class StatusEmployeeModel : BaseViewModel
    {
        private int id;
        private string nameStatusEmployee;
        private string abbreviation;
        private bool isEdit;

        public int StatusEmployeeId
        { 
            get 
            { 
                return id; 
            } set { 
                id = value;
                OnPropertyChanged("StatusEmployeeId");
            }
        }
        public string NameStatusEmployee {
            get { return nameStatusEmployee; }
            set { 
                nameStatusEmployee = value;
                OnPropertyChanged("NameStatusEmployee");
            }
        }
        public string AbbreviationStatusEmployee
        {
            get { return abbreviation; }
            set
            {
                abbreviation = value;
                OnPropertyChanged("AbbreviationStatusEmployee");
            }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set
            {
                isEdit = value;
                OnPropertyChanged("IsEdit");
            }
        }


        public ObservableCollection<EmployeeModel> Employees { get; set; }
    }
}
