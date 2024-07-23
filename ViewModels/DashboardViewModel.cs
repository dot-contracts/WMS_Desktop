using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FicmaDT.UIcomponents.UserControls;
using System.Windows.Input;

namespace FicmaDT.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public ICommand HomeCommand { get; private set; }
        public ICommand DispatchCommand { get; private set; }
        //public ICommand OtherCommand2 { get; private set; }

        public DashboardViewModel()
        {
            // Initialize with Home view
            CurrentView = new Home();

            // Initialize commands
            HomeCommand = new RelayCommand(ShowHome);
            DispatchCommand = new RelayCommand(ShowDispatch);
            //OtherCommand2 = new RelayCommand(ShowOtherView2);
        }

        private void ShowHome(object parameter)
        {
            CurrentView = new Home();
        }

        private void ShowDispatch(object parameter)
        {
            CurrentView = new Dispatch();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
