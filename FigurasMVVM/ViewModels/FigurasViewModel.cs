using FigurasMVVM.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FigurasMVVM.ViewModels
{
    public class FigurasViewModel : INotifyPropertyChanged
    {
        //Modelos
        public ObservableCollection<Figura> Lista { get; set; } = new ObservableCollection<Figura>();
        //
        void PropertyChange(string? propiedad = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }
        public Figura? Figura { get; set; }
        public string Vista { get; set; } = "Ver";
        public string? Error { get; set; }

        //Commands
        public ICommand CancelarCommand { get; set; }
        public ICommand CambiarVistaCommand { get; set; }
        public ICommand AgregarCommand { get; set; }
        public ICommand GuardarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        //CTR
        public FigurasViewModel()
        {
            CancelarCommand = new RelayCommand(Cancelar);
            CambiarVistaCommand = new RelayCommand<String>(CambiarVista);
            AgregarCommand = new RelayCommand(Agregar);
            GuardarCommand = new RelayCommand(Guardar);
            EliminarCommand = new RelayCommand(Eliminar);
        }

        private void Eliminar()
        {
            throw new NotImplementedException();
        }

        private void Guardar()
        {
            throw new NotImplementedException();
        }

        private void Agregar()
        {
            throw new NotImplementedException();
        }

        private void CambiarVista(string obj)
        {
            throw new NotImplementedException();
        }

        private void Cancelar()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
