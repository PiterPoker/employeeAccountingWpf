using employeeAccountingWpf.Models;
using employeeAccountingWpf.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace employeeAccountingWpf.ViewModels
{
    internal class SettingsViewModel : BaseViewModel, IPageViewModel
    {
        private Mark _mark;
        public SettingsViewModel()
        {
            Marks = TestDataViewModel.CreateDataMarks();
            _mark = new Mark();
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
                          var _markDel = Marks.Where(p => p.Id == _mark.Id).FirstOrDefault();
                          _markDel.Name = _mark.Name;
                          _markDel.MarkKey = _mark.MarkKey;
                          _markDel.NumberOfHours = _mark.NumberOfHours;
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
                        Mark _mark = SelectMark;
                        if (_mark != null)
                        {
                            Marks.Remove(_mark);
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
        public ObservableCollection<Mark> Marks { get; set; }
    }
}