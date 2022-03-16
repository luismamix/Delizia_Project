using System;
using System.ComponentModel;
namespace Delizia_Project.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
     
        public void OnPropertyChanged(String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
