using employeeAccountingWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.ViewModels
{
    public class TestDataViewModel
    {
        public static ObservableCollection<Employee> CreateDataEmploees()
        {
            return new ObservableCollection<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Artem",
                    MiddleName = "Vasilevich",
                    LastName = "Konkov",
                    WorkingDays = new ObservableCollection<WorkingDay>
                    {
                        new WorkingDay{
                            Id = 1,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 2,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDay{
                            Id = 3,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
                    }
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Alex",
                    MiddleName = "Andreevch",
                    LastName = "Koplov",
                    WorkingDays = new ObservableCollection<WorkingDay>
                    {
                        new WorkingDay{
                            Id = 4,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 5,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDay{
                            Id = 6,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
                    }
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Alex",
                    MiddleName = "Andreevch",
                    LastName = "Koplov",
                    WorkingDays = new ObservableCollection<WorkingDay>
                    {
                        new WorkingDay{
                            Id = 7,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 8,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDay{
                            Id = 9,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
                    }
                },
            };
        }

        public static ObservableCollection<WorkingDay> CreateDataWorkingDays()
        {
            return new ObservableCollection<WorkingDay>
            {
                new WorkingDay{
                    Id = 1,
                    EmployeesId = null,
                    OperatingId = 1,
                    StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                    EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                },
                new WorkingDay{
                            Id = 2,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                },
                new WorkingDay{
                            Id = 3,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                },
                        new WorkingDay{
                            Id = 4,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 5,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDay{
                            Id = 6,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 7,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDay{
                            Id = 8,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDay{
                            Id = 9,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
            };
        }
    }
}
