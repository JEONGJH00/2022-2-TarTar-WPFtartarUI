using System;
using WPFtartarUI.Core;

namespace WPFtartarUI.MVVM.ViewModel
{
    class TartarDataViewModel : ObservableObject
    {
        
        public RelayCommand RecentTartarDataCommand { get; set; }

        public RecentTartarDataViewModel RecentTartarDataVM { get; set; }
        

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }

        }
        public TartarDataViewModel()
        {
            RecentTartarDataVM = new RecentTartarDataViewModel();
            

            CurrentView = RecentTartarDataVM;

            RecentTartarDataCommand = new RelayCommand(o =>
            {
                CurrentView = RecentTartarDataVM;
            });

        }
    }
}
