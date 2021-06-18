using employeeAccountingWpf.Entity;
using employeeAccountingWpf.Interface;
using employeeAccountingWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.ViewModels.helper
{
    public class ViewModelHelper
    {
        public EmployeeModel AddNewDay(WorkingDayModel _workingModel, IStatusWorkingDay _mark, EmployeeModel _employee)
        {
            _workingModel.EndDateTime = _workingModel.EndDateTime.AddDays(1);
            while (_workingModel.StartDateTime != _workingModel.EndDateTime)
            {
                var _hours = (double)_mark.StartWorkingDay.Hour;
                var _minuts = (double)_mark.StartWorkingDay.Minute;
                _employee.WorkingDays.Add(new WorkingDay
                {
                    StartDateTime = _workingModel.StartDateTime.AddHours(_hours).AddMinutes(_minuts),
                    EndDateTime = _workingModel.StartDateTime.AddHours(_hours + _mark.NumberOfHours).AddMinutes(_minuts),
                    EmployeeId = _employee.Id

                });
                _workingModel.StartDateTime = _workingModel.StartDateTime.AddDays(1);
            }
            return _employee;
        }

        public IStatusEmployee NewItemStatusEmployee(object obj)
        {
            var _obj = obj as StatusEmployee;
            IStatusEmployee statusEmployee = new StatusEmployee(_obj.NameStatusEmployee, _obj.Abbreviation);
            return statusEmployee;
        }

        public IStatusWorkingDay NewItemStatusWorkingDayModel(object obj)
        {
            var _obj = obj as StatusWorkingDay;
            IStatusWorkingDay statusWorkingDay = new StatusWorkingDay(_obj.NameStatusWorkingDay, _obj.Abbreviation, _obj.NumberOfHours, _obj.StartWorkingDay);
            return statusWorkingDay;
        }
    }
}
