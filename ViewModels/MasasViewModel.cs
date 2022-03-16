using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Delizia_Project.Helpers;
using Delizia_Project.Models;

namespace Delizia_Project.ViewModels
{
    public class MasasViewModel : ViewModelBase
    {
        HelperMaster helpermaster = new HelperMaster();

        public MasasViewModel()
        {
            Task.Run(async () => {
                List<Masa> lista = await helpermaster.GetMasas();
                this.Masas = new ObservableCollection<Masa>(lista);
            });


        }
        private ObservableCollection<Masa> _Masas;

        public ObservableCollection<Masa> Masas
        {
            get { return this._Masas; }
            set
            {
                this._Masas = value;
                OnPropertyChanged("Masas");
            }
        }
    }
}
