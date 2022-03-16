using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Delizia_Project.Helpers;
using Delizia_Project.Models;

namespace Delizia_Project.ViewModels
{
    public class TamaniosViewModel : ViewModelBase
    {
        HelperMaster helpermaster = new HelperMaster();

        public TamaniosViewModel()
        {
            Task.Run(async () => {
                List<Tamanio> lista = await helpermaster.GetTamanios();
                this.Tamanios = new ObservableCollection<Tamanio>(lista);
            });


        }
        private ObservableCollection<Tamanio> _Tamanios;

        public ObservableCollection<Tamanio> Tamanios
        {
            get { return this._Tamanios; }
            set
            {
                this._Tamanios = value;
                OnPropertyChanged("Tamanios");
            }
        }
    }
}
