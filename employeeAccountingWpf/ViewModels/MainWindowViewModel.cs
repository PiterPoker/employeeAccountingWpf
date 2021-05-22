using employeeAccountingWpf.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace employeeAccountingWpf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        private void Schedules(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }

        private void Employees(object obj)
        {
            ChangeViewModel(PageViewModels[1]);
        }

        private void Settings(object obj)
        {
            ChangeViewModel(PageViewModels[2]);
        }

        public MainWindowViewModel()
        {
            // Add available pages and set page
            PageViewModels.Add(new SchedulesViewModel());
            PageViewModels.Add(new EmployeesViewModel());
            PageViewModels.Add(new SettingsViewModel());

            CurrentPageViewModel = PageViewModels[0];

            Mediator.Subscribe("Schedules", Schedules);
            Mediator.Subscribe("Employee", Employees);
            Mediator.Subscribe("Settings", Settings);

        }

        private ICommand _openDrawerCommand;

        public ICommand OpenDrawerCommand
        {
            get
            {
                return _openDrawerCommand ?? (_openDrawerCommand = new RelayCommand(x =>
                {
                    IsChecked = true;
                }));
            }
        }

        private ICommand _closeDrawerCommand;

        public ICommand CloseDrawerCommand
        {
            get
            {
                return _closeDrawerCommand ?? (_closeDrawerCommand = new RelayCommand(x =>
                {
                    IsChecked = false;
                }));
            }
        }

        private ICommand _goToSchedules;

        public ICommand GoToSchedules
        {
            get
            {
                return _goToSchedules ?? (_goToSchedules = new RelayCommand(x =>
                {
                    Mediator.Notify("Schedules", "");
                    IsChecked = false;
                }));
            }
        }

        private ICommand _goToEmployees;

        public ICommand GoToEmployees
        {
            get
            {
                return _goToEmployees ?? (_goToEmployees = new RelayCommand(x =>
                {
                    Mediator.Notify("Employee", "");
                    IsChecked = false;
                }));
            }
        }

        private ICommand _goToSettings;

        public ICommand GoToSettings
        {
            get
            {
                return _goToSettings ?? (_goToSettings = new RelayCommand(x =>
                {
                    Mediator.Notify("Settings", "");
                    IsChecked = false;
                }));
            }
        }

        private bool _isChecked;

        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }
    }
}
