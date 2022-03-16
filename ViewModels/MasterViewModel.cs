using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Delizia_Project.Helpers;
using Delizia_Project.Models;

namespace Delizia_Project.ViewModels
{
    public class MasterViewModel : ViewModelBase
    {
        HelperMaster helpermaster = new HelperMaster();

        public MasterViewModel()
        {
            Task.Run(async () => {
                List<Especialidad> lista = await helpermaster.GetEspecialidades();
                this.Especialidades = new ObservableCollection<Especialidad>(lista);
            });

            Task.Run(async () => {
                List<Masa> lista = await helpermaster.GetMasas();
                this.Masas = new ObservableCollection<Masa>(lista);
            });

            Task.Run(async () => {
                List<Tamanio> lista = await helpermaster.GetTamanios();
                this.Tamanios = new ObservableCollection<Tamanio>(lista);
            });
            Task.Run(async () => {
               Contenido con = await helpermaster.GetContenido();
                this.contenido = con;
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

        private Contenido _contenido;
        public Contenido contenido
        {
            get { return this._contenido; }
            set
            {
                this._contenido = value;
                OnPropertyChanged("contenido");
            }
        }
    }
}
