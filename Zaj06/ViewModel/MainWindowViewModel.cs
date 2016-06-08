using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Zaj06.ViewModel
{
    public class AddNoticeCommand : ICommand
    {
        public AddNoticeCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        private Action _execute;

        public void Execute(object parameter)
        {
            _execute();
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<NoticeViewModel> Notices { get; set; }

        NoticeViewModel _noticeToAdd;
        public NoticeViewModel NoticeToAdd 
        {
            get 
            {
                return _noticeToAdd;
            }
            set
            {
                _noticeToAdd = value;
                RaisePropertyChanged("NoticeToAdd");
            }
        }

        public ICommand AddNotice { get; set; }

        private void RaisePropertyChanged(string p)
        {
            var pCh = PropertyChanged;
            if (pCh != null)
            {
                pCh(this, new PropertyChangedEventArgs(p));
            }
        }

        public MainWindowViewModel()
        {
            NoticeToAdd = new NoticeViewModel { Creted = DateTime.Now };

            AddNotice = new AddNoticeCommand(() =>
            {
                Notices.Add(NoticeToAdd);
                NoticeToAdd = new NoticeViewModel { Creted = DateTime.Now };
            });

            //komunikacja z baza w celu np. zaciagniecia notatek
            Notices = new ObservableCollection<NoticeViewModel> 
            {
                new NoticeViewModel{Title="Zrobic projekt", Description="Na zaliczenie z C#", Creted=DateTime.Now },
                new NoticeViewModel{Title="Title 2", Description="Desc 1", Creted=DateTime.Now },
                new NoticeViewModel{Title="Title 3", Description="Desc 2", Creted=DateTime.Now },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
