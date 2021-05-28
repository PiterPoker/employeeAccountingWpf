using employeeAccountingWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.ViewModels
{
    public class ServiceJobModel : BaseViewModel
    {
        private int id;
        private string nameService;
        private string abbreviation;

        public int ServiceJobId
        { get { return id; } 
            set { 
                id = value;
                OnPropertyChanged("ServiceJobId");
            } 
        }
        public string NameServiceJob { get { return nameService; }
            set { 
                nameService = value;
                OnPropertyChanged("NameServiceJob");
            }
        }
        public string AbbreviationServiceJob { get { return abbreviation; }
            set { abbreviation = value;
                OnPropertyChanged("AbbreviationServiceJob");
            }
        }
        public ObservableCollection<EmployeeModel> Employees { get; set; }
    }
}
