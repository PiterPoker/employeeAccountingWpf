using employeeAccountingWpf.Models;
using System;
using System.Collections.ObjectModel;

namespace employeeAccountingWpf.ViewModels
{
    public class TestDataViewModel
    {
        public static ObservableCollection<EmployeeModel> CreateDataEmploees()
        {
            return new ObservableCollection<EmployeeModel>
            {
                new EmployeeModel
                {
                    Id = 1,
                    FirstName = "Artem",
                    MiddleName = "Vasilevich",
                    LastName = "Konkov",
                    IsCheckDelete = true,
                    WorkingDays = new ObservableCollection<WorkingDayModel>
                    {
                        new WorkingDayModel{
                            Id = 1,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 2,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
                            Id = 3,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
                    }
                },
                new EmployeeModel
                {
                    Id = 2,
                    FirstName = "Alex",
                    MiddleName = "Andreevch",
                    LastName = "Koplov",
                    IsCheckDelete = true,
                    WorkingDays = new ObservableCollection<WorkingDayModel>
                    {
                        new WorkingDayModel{
                            Id = 4,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 5,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
                            Id = 6,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
                    }
                },
                new EmployeeModel
                {
                    Id = 3,
                    FirstName = "Alex",
                    MiddleName = "Andreevch",
                    LastName = "Koplov",
                    IsCheckDelete = true,
                    WorkingDays = new ObservableCollection<WorkingDayModel>
                    {
                        new WorkingDayModel{
                            Id = 7,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 8,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
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

        public static ObservableCollection<WorkingDayModel> CreateDataWorkingDays()
        {
            return new ObservableCollection<WorkingDayModel>
            {
                new WorkingDayModel{
                    Id = 1,
                    EmployeesId = null,
                    OperatingId = 1,
                    StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                    EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                },
                new WorkingDayModel{
                            Id = 2,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                },
                new WorkingDayModel{
                            Id = 3,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                },
                        new WorkingDayModel{
                            Id = 4,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 5,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
                            Id = 6,
                            EmployeesId = null,
                            OperatingId = 2,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 7,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2013, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 8,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2015, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2014, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
                            Id = 9,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2014, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2014, 7, 10, 23, 49, 0)
                        }
            };
        }

        public static EmployeeModel CreateDataEmploee()
        {
            return new EmployeeModel
            {
                Id = 4,
                FirstName = "Paul",
                MiddleName = "Solkov",
                LastName = "Evseevich",
                IsCheckDelete = false,
                WorkingDays = new ObservableCollection<WorkingDayModel>
                    {
                        new WorkingDayModel{
                            Id = 10,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2021, 6, 1, 12, 32, 30),
                            EndDateTime = new DateTime(2021, 7, 10, 23, 49, 0)
                        },
                        new WorkingDayModel{
                            Id = 11,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2021, 1, 10, 1, 16, 0),
                            EndDateTime = new DateTime(2021, 12, 20, 21, 45, 0)
                        },
                        new WorkingDayModel{
                            Id = 12,
                            EmployeesId = null,
                            OperatingId = 1,
                            StartDateTime = new DateTime(2021, 6, 2, 15, 14, 0),
                            EndDateTime = new DateTime(2021, 7, 10, 23, 49, 0)
                        }
                    }
            };
        }

        public static ObservableCollection<Mark> CreateDataMarks()
        {
            return new ObservableCollection<Mark>
            {
                new Mark
                {
                    Id = 0,
                    Name = "Первая смена",
                    MarkKey = "1",
                    NumberOfHours = 8
                },new Mark
                {
                    Id = 1,
                    Name = "Второая смена",
                    MarkKey = "2",
                    NumberOfHours = 8
                },new Mark
                {
                    Id = 2,
                    Name = "Третья смена",
                    MarkKey = "3",
                    NumberOfHours = 8
                },new Mark
                {
                    Id = 3,
                    Name = "Выходной",
                    MarkKey = "ВХ",
                    NumberOfHours = 0
                },new Mark
                {
                    Id = 4,
                    Name = "Праздник",
                    MarkKey = "П",
                    NumberOfHours = 0
                },new Mark
                {
                    Id = 5,
                    Name = "Больничный",
                    MarkKey = "Б",
                    NumberOfHours = 0
                }
            };
        }

        public static ObservableCollection<StatusEmployeeModel> CreateDataModelEmployee()
        {
            return new ObservableCollection<StatusEmployeeModel>{
                new StatusEmployeeModel
                {
                    StatusEmployeeId = 6,
                    NameStatusEmployee = "Уволен",
                    AbbreviationStatusEmployee = "У",
                    Employees = null
                }
            };
        }
    }
}
