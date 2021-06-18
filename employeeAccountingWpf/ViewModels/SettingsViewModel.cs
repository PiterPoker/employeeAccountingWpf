using employeeAccountingWpf.DAL;
using employeeAccountingWpf.Entity;
using employeeAccountingWpf.Interface;
using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using employeeAccountingWpf.ViewModels.helper;
using employeeAccountingWpf.Views.DialogWindow;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Threading;

namespace employeeAccountingWpf.ViewModels
{
    public class SettingsViewModel : BaseViewModel, IPageViewModel
    {
        
        private StatusEmployeeCard _statusEmployeeCard;
        private StatusDayCard _statusDayCard;
        private IStatusEmployee _selectStatusEmployeeModel;
        private IStatusWorkingDay _selectStatusWorkingDayModel;
        private IStatusEmployee _statusEmployeeModel;
        private IStatusWorkingDay _statusWorkingDayModel;
        private ViewModelHelper _workingDayHelper;
        private bool _isOpenDialog;
        private DateTime? _startDateTime;

        /// <summary>
        /// Сonstructor SettingViewModel
        /// </summary>
        public SettingsViewModel()
        {
            _statusEmployeeCard = new StatusEmployeeCard();
            _statusDayCard = new StatusDayCard();
            SelectStatusEmployeeModel = new StatusEmployee();
            SelectStatusWorkingDayModel = new StatusWorkingDay();
            StatusEmployeeModel = new StatusEmployee();
            StatusWorkingDayModel = new StatusWorkingDay();
            _workingDayHelper = new ViewModelHelper();
            _startDateTime = DateTime.Today;
            StatusEmployees = LoadDataDBContext.StatusEmployees;
            StatusWorkingDays = LoadDataDBContext.StatusWorkingDays;

            #region ConnectToServerCommand
            //just some demo code for the SAVE button
            ConnectToServerCommand = new RelayCommand(_ =>
            {
                if (IsSaveComplete == true)
                {
                    IsSaveComplete = false;
                    return;
                }
                if (SaveProgress != 0) return;

                var started = DateTime.Now;
                IsSaving = true;

                new DispatcherTimer(
                    TimeSpan.FromMilliseconds(50),
                    DispatcherPriority.Normal,
                    new EventHandler((o, e) =>
                    {
                        var totalDuration = started.AddSeconds(3).Ticks - started.Ticks;
                        var currentProgress = DateTime.Now.Ticks - started.Ticks;
                        var currentProgressPercent = 100.0 / totalDuration * currentProgress;

                        SaveProgress = currentProgressPercent;

                        if (SaveProgress >= 100)
                        {
                            IsSaveComplete = true;
                            IsSaving = false;
                            SaveProgress = 0;
                            if (o is DispatcherTimer timer)
                            {
                                timer.Stop();
                            }
                        }

                    }), Dispatcher.CurrentDispatcher);
            });
            #endregion

            #region ConnectToDBCommand
            //just some demo code for the SAVE button
            ConnectToDBCommand = new RelayCommand(_ =>
            {
                if (IsSaveComplete1 == true)
                {
                    IsSaveComplete1 = false;
                    return;
                }
                if (SaveProgress1 != 0) return;

                var started1 = DateTime.Now;
                IsSaving1 = true;

                new DispatcherTimer(
                    TimeSpan.FromMilliseconds(50),
                    DispatcherPriority.Normal,
                    new EventHandler((o, e) =>
                    {
                        var totalDuration1 = started1.AddSeconds(3).Ticks - started1.Ticks;
                        var currentProgress1 = DateTime.Now.Ticks - started1.Ticks;
                        var currentProgressPercent1 = 100.0 / totalDuration1 * currentProgress1;

                        SaveProgress1 = currentProgressPercent1;

                        if (SaveProgress1 >= 100)
                        {
                            IsSaveComplete1 = true;
                            IsSaving1 = false;
                            SaveProgress1 = 0;
                            if (o is DispatcherTimer timer)
                            {
                                timer.Stop();
                            }
                        }

                    }), Dispatcher.CurrentDispatcher);
            });
            #endregion
        }

        #region Property SettingViewModel
        /// <summary>
        /// Property SettingViewModel
        /// </summary>
        public IStatusEmployee SelectStatusEmployeeModel
        {
            get
            {
                return _selectStatusEmployeeModel;
            }
            set
            {
                _selectStatusEmployeeModel = value;
                OnPropertyChanged("SelectStatusEmployeeModel");
            }
        }

        public IStatusWorkingDay SelectStatusWorkingDayModel
        {
            get
            {
                return _selectStatusWorkingDayModel;
            }
            set
            {
                _selectStatusWorkingDayModel = value;
                OnPropertyChanged("SelectStatusWorkingDayModel");
            }
        }

        public IStatusEmployee StatusEmployeeModel
        {
            get
            {
                return _statusEmployeeModel;
            }
            set
            {
                _statusEmployeeModel = value;
                OnPropertyChanged("StatusEmployeeModel");
            }
        }

        public IStatusWorkingDay StatusWorkingDayModel
        {
            get
            {
                return _statusWorkingDayModel;
            }
            set
            {
                _statusWorkingDayModel = value;
                OnPropertyChanged("StatusWorkingDayModel");
            }
        }

        public bool IsOpenDialog
        {
            get
            {
                return _isOpenDialog;
            }
            set
            {
                _isOpenDialog = value;
                OnPropertyChanged("IsOpenDialog");
            }
        }

        public DateTime? StartDateTime
        {
            get
            {
                return _startDateTime;
            }
            set
            {
                _startDateTime = value;
                OnPropertyChanged("StartDateTime");
            }
        }
        #endregion

        #region Collection SettingViewModel
        /// <summary>
        /// Collection SettingViewModel
        /// </summary>
        public ObservableCollection<IStatusEmployee> StatusEmployees { get; set; }
        public ObservableCollection<IStatusWorkingDay> StatusWorkingDays { get; set; }

        #endregion

        /// <summary>
        /// Command SettingViewModel
        /// </summary>
        private RelayCommand _openStatusEmployeeCardCommand;
        private RelayCommand _openStatusDayCardCommand;
        private RelayCommand _removeCommand;
        private RelayCommand _saveCardCommand;

        public RelayCommand OpenStatusEmployeeCardCommand
        {
            get
            {
                return _openStatusEmployeeCardCommand ??
                    (_openStatusEmployeeCardCommand = new RelayCommand(obj =>
                    {
                        DialogHost.Show(_statusEmployeeCard);
                    }));
            }
        }

        public RelayCommand OpenStatusDayCardCommand
        {
            get
            {
                return _openStatusDayCardCommand ??
                    (_openStatusDayCardCommand = new RelayCommand(obj =>
                    {
                        DialogHost.Show(_statusDayCard);
                    }));
            }
        }
        
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        if (obj is StatusEmployee)
                        {
                            LoadDataDBContext.StatusEmployees.Remove(obj as IStatusEmployee);
                            if (StatusEmployees.Count > 0)
                                SelectStatusEmployeeModel = StatusEmployees.FirstOrDefault() as StatusEmployeeModel;
                        }
                        else if (obj is StatusWorkingDay)
                        {
                            LoadDataDBContext.StatusWorkingDays.Remove(obj as IStatusWorkingDay);
                            if (StatusWorkingDays.Count > 0)
                                SelectStatusWorkingDayModel = StatusWorkingDays.FirstOrDefault() as StatusWorkingDayModel;
                        }
                    }));
            }
        }

        public RelayCommand SaveCardCommand
        {
            get
            {
                return _saveCardCommand ??
                    (_saveCardCommand = new RelayCommand(obj =>
                    {
                        if (obj is StatusEmployee)
                        {                            
                            LoadDataDBContext.StatusEmployees.Add(_workingDayHelper.NewItemStatusEmployee(obj));
                            SelectStatusEmployeeModel = StatusEmployees.FirstOrDefault() as StatusEmployeeModel;
                        }
                        else if (obj is StatusWorkingDay)
                        {
                            LoadDataDBContext.StatusWorkingDays.Add(_workingDayHelper.NewItemStatusWorkingDayModel(obj));
                            SelectStatusWorkingDayModel = StatusWorkingDays.FirstOrDefault() as StatusWorkingDayModel;
                        }
                        IsOpenDialog = false;
                    }));
            }
        }

        #region

        #region ConnectToServerCommand

        public RelayCommand ConnectToServerCommand { get; }

        private bool _isSaving;
        public bool IsSaving
        {
            get => _isSaving;
            private set => this.MutateVerbose(ref _isSaving, value, RaisePropertyChanged());
        }

        private bool _isSaveComplete;
        public bool IsSaveComplete
        {
            get => _isSaveComplete;
            private set => this.MutateVerbose(ref _isSaveComplete, value, RaisePropertyChanged());
        }

        private double _saveProgress;
        public double SaveProgress
        {
            get => _saveProgress;
            private set => this.MutateVerbose(ref _saveProgress, value, RaisePropertyChanged());
        }

        #endregion

        #region ConnectToDBCommand
        public RelayCommand ConnectToDBCommand { get; }

        private bool _isSaving1;
        public bool IsSaving1
        {
            get => _isSaving1;
            private set => this.MutateVerbose(ref _isSaving1, value, RaisePropertyChanged());
        }

        private bool _isSaveComplete1;
        public bool IsSaveComplete1
        {
            get => _isSaveComplete1;
            private set => this.MutateVerbose(ref _isSaveComplete1, value, RaisePropertyChanged());
        }

        private double _saveProgress1;
        public double SaveProgress1
        {
            get => _saveProgress1;
            private set => this.MutateVerbose(ref _saveProgress1, value, RaisePropertyChanged());
        }

        #endregion
        #endregion

    }
}