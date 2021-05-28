using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using employeeAccountingWpf.Views.DialogWindow;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace employeeAccountingWpf.ViewModels
{
    internal class SettingsViewModel : BaseViewModel, IPageViewModel
    {
        private Mark _mark;
        private StatusEmployeeModel _statusEmployeeModel;
        StatusEmployeeCard _statusEmployeeCard;
        StatusDayCard _statusDayCard;
        public SettingsViewModel()
        {
            Marks = TestDataViewModel.CreateDataMarks();
            StatusEmployeeModels = new ObservableCollection<StatusEmployeeModel>();
            _mark = new Mark();
            StatusEmployeeModel = new StatusEmployeeModel();
            _statusEmployeeCard = new StatusEmployeeCard();
            _statusDayCard = new StatusDayCard();
        }

        public Mark Mark
        {
            get { return _mark; }
            set
            {
                _mark = value;
                OnPropertyChanged("Mark");
            }
        }

        public StatusEmployeeModel StatusEmployeeModel
        {
            get { return _statusEmployeeModel; }
            set
            {
                _statusEmployeeModel = value;
                OnPropertyChanged("StatusEmployeeModel");
            }
        }

        private bool _isCheck;
        public bool IsCheck
        {
            get { return _isCheck; }
            set
            {
                _isCheck = value;
                OnPropertyChanged("IsCheck");
            }
        }

        private bool _isEdit = false;
        private bool _isOpenDialog;
        public bool IsOpenDialog
        {
            get { return _isCheck; }
            set
            {
                _isCheck = value;
                OnPropertyChanged("IsOpenDialog");
            }
        }

        private RelayCommand _addNewMarkCommand;
        public RelayCommand AddNewMarkCommand
        {
            get
            {
                return _addNewMarkCommand ??
                  (_addNewMarkCommand = new RelayCommand(obj =>
                  {
                          if (_isEdit == false)
                          {
                              Mark _newMark = new Mark()
                              {
                                  Name = _mark.Name,
                                  MarkKey = _mark.MarkKey,
                                  NumberOfHours = _mark.NumberOfHours
                              };
                              Marks.Insert(0, _newMark);
                          }
                          else if (_isEdit == true)
                          {
                              SelectMark.Name = _mark.Name;
                              SelectMark.MarkKey = _mark.MarkKey;
                              SelectMark.NumberOfHours = _mark.NumberOfHours;
                              _isEdit = false;
                          }

                      IsOpenDialog = false;
                  }));
            }
        }

        private RelayCommand _saveCardCommand;
        public RelayCommand SaveCardCommand
        {
            get
            {
                return _saveCardCommand ??
                    (_saveCardCommand = new RelayCommand(obj =>
                    {
                        StatusEmployeeModel = obj as StatusEmployeeModel;
                        if (StatusEmployeeModel.IsEdit == false)
                        {
                            StatusEmployeeModel _newStatusEmployeeModel = new StatusEmployeeModel()
                            {
                                NameStatusEmployee = StatusEmployeeModel.NameStatusEmployee,
                                AbbreviationStatusEmployee = StatusEmployeeModel.AbbreviationStatusEmployee
                            };
                            StatusEmployeeModels.Insert(0, _newStatusEmployeeModel);
                        }
                        else if (StatusEmployeeModel.IsEdit == true)
                        {
                            SelectStatusEmployeeModel.NameStatusEmployee = StatusEmployeeModel.NameStatusEmployee;
                            SelectStatusEmployeeModel.AbbreviationStatusEmployee = StatusEmployeeModel.AbbreviationStatusEmployee;
                            StatusEmployeeModel.IsEdit = false;
                        }
                        IsOpenDialog = false;
                    }));
            }
        }

        private RelayCommand _editStatusEmployeeCommand;
        public RelayCommand EditStatusEmployeeCommand
        {
            get
            {
                return _editStatusEmployeeCommand ??
                  (_editStatusEmployeeCommand = new RelayCommand(obj =>
                  {
                      if (_isEdit == false)
                      {
                          StatusEmployeeModel _newStatusEmployee = new StatusEmployeeModel()
                          {
                              NameStatusEmployee = _statusEmployeeModel.NameStatusEmployee,
                              AbbreviationStatusEmployee = _statusEmployeeModel.AbbreviationStatusEmployee
                          };
                          StatusEmployeeModels.Insert(0, _newStatusEmployee);
                      }
                      else if (_isEdit == true)
                      {
                          SelectStatusEmployeeModel.NameStatusEmployee = _statusEmployeeModel.NameStatusEmployee;
                          SelectStatusEmployeeModel.AbbreviationStatusEmployee = _statusEmployeeModel.AbbreviationStatusEmployee;
                          _isEdit = false;
                      }
                      IsOpenDialog = false;
                  }));
            }
        }

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                    (_saveCommand = new RelayCommand(obj =>
                    {
                        IsCheck = !(bool)obj;
                    }));
            }
        }

        private RelayCommand _openStatusEmployeeCardCommand;
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

        private RelayCommand _openStatusDayCardCommand;
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


        private bool _isCheckServer;
        public bool IsCheckServer
        {
            get { return _isCheckServer; }
            set
            {
                _isCheckServer = value;
                OnPropertyChanged("IsCheckServer");
            }
        }

        private RelayCommand _serverSaveCommand;
        public RelayCommand ServerSaveCommand
        {
            get
            {
                return _serverSaveCommand ??
                    (_serverSaveCommand = new RelayCommand(obj =>
                    {
                        IsCheckServer = !(bool)obj;
                    }));
            }
        }

        private RelayCommand _editMarkCommand;
        public RelayCommand EditMarkCommand
        {
            get
            {
                return _editMarkCommand ??
                    (_editMarkCommand = new RelayCommand(obj =>
                    {
                        Mark _mark = obj as Mark;
                        if (_mark != null)
                        {
                            if (IsOpenDialog == false)
                            {
                                Mark.Name = _mark.Name;
                                Mark.MarkKey = _mark.MarkKey;
                                Mark.NumberOfHours = _mark.NumberOfHours;
                                IsOpenDialog = true;
                            }
                            _isEdit = true;
                        }
                    },
                    (obj) => Marks.Count > 0));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        if (true == (obj is Mark))
                        {
                            Mark _mark = SelectMark;
                            if (_mark != null)
                            {
                                Marks.Remove(_mark);
                            }
                            SelectMark = Marks.FirstOrDefault();
                        }else if (obj is StatusEmployeeModel)
                        {
                            StatusEmployeeModel _selectStatusEmployee = SelectStatusEmployeeModel;
                            if (_selectStatusEmployee != null)
                            {
                                StatusEmployeeModels.Remove(_selectStatusEmployee);
                            }
                            SelectStatusEmployeeModel = StatusEmployeeModels.FirstOrDefault();
                        }
                    },
                    (obj) => Marks.Count > 0));
            }
        }

        private Mark _selectMark { get; set; }
        public Mark SelectMark
        {
            get { return _selectMark; }
            set
            {
                _selectMark = value;
                OnPropertyChanged("SelectMark");
            }
        }
        private StatusEmployeeModel _selectStatusEmployeeModel { get; set; }
        public StatusEmployeeModel SelectStatusEmployeeModel
        {
            get { return _selectStatusEmployeeModel; }
            set
            {
                _selectStatusEmployeeModel = value;
                OnPropertyChanged("SelectStatusEmployeeModel");
            }
        }
        public ObservableCollection<Mark> Marks { get; set; }
        public ObservableCollection<StatusEmployeeModel> StatusEmployeeModels { get; set; }
    }
}