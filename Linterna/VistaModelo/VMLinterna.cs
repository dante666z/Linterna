using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Linterna.VistaModelo
{
    public class VMLinterna : BaseViewModel
    {
        #region VARIABLES
        bool _encendido;
        string iconoon = "on.png";
        string iconoof = "of.png";
        string focoOn = "focoon.png";
        string focoOf = "focoof.png";
        string _Texto;
        public string OnOficon { get => _encendido ? iconoof : iconoon; }
        public string OnOffoco { get => _encendido ? focoOn : focoOf; }
        #endregion

        #region CONSTRUCTOR
        public VMLinterna()
        {
            
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value);}
        }
        public bool Encendido
        {
            get { return _encendido; }
            set
            {
                SetValue(ref _encendido, value);
                OnPropertyChanged(nameof(OnOficon));
                OnPropertyChanged(nameof(OnOffoco));
            }
        }
        #endregion

        #region PROCESOS
        public async Task OnLuz()
        {
            await Flashlight.TurnOnAsync();
        }
        public async Task OfLuz()
        {
            await Flashlight.TurnOffAsync();
        }
        private void Vibrar()
        {
            Vibration.Vibrate();
            var duracion = TimeSpan.FromSeconds(1);
            Vibration.Vibrate(duracion);
        }
        private async Task OnOf()
        {
            if (_encendido == true)
            {
                Encendido = false;
                await OfLuz();
                Vibrar();
            } else
            {
                Encendido = true;
                await OnLuz();
                Vibrar();
            }
        }
        #endregion

        #region COMANDOS
        
        public ICommand OnOfCommand => new Command(async ()=> await OnOf());
        #endregion
    }
}
