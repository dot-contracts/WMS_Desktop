using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FicmaDT.UIcomponents.UserControls
{
    /// <summary>
    /// Interaction logic for Dispatch.xaml
    /// </summary>
    public class DispatchViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DispatchItem> _dispatchItems;
        public ObservableCollection<DispatchItem> DispatchItems
        {
            get => _dispatchItems;
            set
            {
                _dispatchItems = value;
                OnPropertyChanged();
            }
        }

        // Implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Add methods for filtering, pagination, etc.
    }

    public class DispatchItem
    {
        public string WaybillNo { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public string TrackingNo { get; set; }
        public string Vehicle { get; set; }
    }
}
