using employeeAccountingWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.Models
{
    public class Mark : BaseViewModel
    {
        private int _id;
        private string _name;
        private string _markKey;
        private int _numberOfHours;

        public int Id { get 
            {
                return _id;
            } set 
            {
                _id=value;
                OnPropertyChanged("Id");
            } 
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string MarkKey
        {
            get
            {
                return _markKey;
            }
            set
            {
                _markKey = value;
                OnPropertyChanged("MarkKey");
            }
        }

        public int NumberOfHours
        {
            get
            {
                return _numberOfHours;
            }
            set
            {
                _numberOfHours = value;
                OnPropertyChanged("NumberOfHours");
            }
        }
    }
}
