using employeeAccountingWpf.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAccountingWpf.DAL
{
    public class UnitOfWork : IDisposable
    {
        private WorkingEmployeeContext context = new WorkingEmployeeContext();
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<EmailEmployee> emailEmployeeRepository;
        private GenericRepository<NumberPhoneEmployee> numberPhoneEmployeeRepository;
        private GenericRepository<OverTime> overTimeRepository;
        private GenericRepository<Position> positionRepository;
        private GenericRepository<ServiceJob> serviceJobRepository;
        private GenericRepository<StatusEmployee> statusEmployeeRepository;
        private GenericRepository<StatusNumberPhoneEmployee> statusnumberPhoneEmployeeRepository;
        private GenericRepository<StatusWorkingDay> statusWorkingDayRepository;
        private GenericRepository<TypeOfAward> typeOfAwardRepository;
        private GenericRepository<WorkingDay> workingDayRepository;

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {

                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(context);
                }
                return employeeRepository;
            }
        }

        public GenericRepository<EmailEmployee> EmailEmployeeRepository
        {
            get
            {

                if (this.emailEmployeeRepository == null)
                {
                    this.emailEmployeeRepository = new GenericRepository<EmailEmployee>(context);
                }
                return emailEmployeeRepository;
            }
        }

        public GenericRepository<NumberPhoneEmployee> NumberPhoneEmployeeRepository
        {
            get
            {

                if (this.numberPhoneEmployeeRepository == null)
                {
                    this.numberPhoneEmployeeRepository = new GenericRepository<NumberPhoneEmployee>(context);
                }
                return numberPhoneEmployeeRepository;
            }
        }

        public GenericRepository<OverTime> OverTimeRepository
        {
            get
            {

                if (this.overTimeRepository == null)
                {
                    this.overTimeRepository = new GenericRepository<OverTime>(context);
                }
                return overTimeRepository;
            }
        }

        public GenericRepository<Position> PositionRepository
        {
            get
            {

                if (this.positionRepository == null)
                {
                    this.positionRepository = new GenericRepository<Position>(context);
                }
                return positionRepository;
            }
        }
        
        public GenericRepository<ServiceJob> ServiceJobRepository
        {
            get
            {

                if (this.serviceJobRepository == null)
                {
                    this.serviceJobRepository = new GenericRepository<ServiceJob>(context);
                }
                return serviceJobRepository;
            }
        }
        
        public GenericRepository<StatusEmployee> StatusEmployeeRepository
        {
            get
            {

                if (this.statusEmployeeRepository == null)
                {
                    this.statusEmployeeRepository = new GenericRepository<StatusEmployee>(context);
                }
                return statusEmployeeRepository;
            }
        }
        
        public GenericRepository<StatusNumberPhoneEmployee> StatusNumberPhoneEmployeeRepository
        {
            get
            {

                if (this.statusnumberPhoneEmployeeRepository == null)
                {
                    this.statusnumberPhoneEmployeeRepository = new GenericRepository<StatusNumberPhoneEmployee>(context);
                }
                return statusnumberPhoneEmployeeRepository;
            }
        }
        
        public GenericRepository<StatusWorkingDay> StatusWorkingDayRepository
        {
            get
            {

                if (this.statusWorkingDayRepository == null)
                {
                    this.statusWorkingDayRepository = new GenericRepository<StatusWorkingDay>(context);
                }
                return statusWorkingDayRepository;
            }
        }
        
        public GenericRepository<TypeOfAward> TypeOfAwardRepository
        {
            get
            {

                if (this.typeOfAwardRepository == null)
                {
                    this.typeOfAwardRepository = new GenericRepository<TypeOfAward>(context);
                }
                return typeOfAwardRepository;
            }
        }
        
        public GenericRepository<WorkingDay> WorkingDayRepository
        {
            get
            {

                if (this.workingDayRepository == null)
                {
                    this.workingDayRepository = new GenericRepository<WorkingDay>(context);
                }
                return workingDayRepository;
            }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
