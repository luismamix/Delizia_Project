using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Delizia_Project.Helpers;
using Delizia_Project.Models;

namespace Delizia_Project.ViewModels
{
    public class EspecialidadesViewModel : ViewModelBase
    {
        HelperMaster helpermaster = new HelperMaster();

        public EspecialidadesViewModel()
        {
            Task.Run(async () => {
                List<Especialidad> lista = await helpermaster.GetEspecialidades();
                this.Especialidades = new ObservableCollection<Especialidad>(lista);
            });

       
        }
        private ObservableCollection<Especialidad> _Especialidades;

        public ObservableCollection<Especialidad> Especialidades
        {
            get { return this._Especialidades; }
            set
            {
                this._Especialidades = value;
                OnPropertyChanged("Especialidades");
            }
        }
    }
}
