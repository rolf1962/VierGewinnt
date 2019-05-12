using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class SpielerViewModel : ISpielerViewModel, INotifyPropertyChanged
    {
        private readonly ISpieler _spieler;
        private bool _istAnDerReihe;

        public SpielerViewModel(ISpieler spieler)
        {
            if (spieler == null)
            {
                throw new ArgumentNullException(nameof(spieler));
            }

            _spieler = spieler;
        }

        public ISpieler Spieler
        {
            get
            {
                return _spieler;
            }
        }

        public bool IstAnDerReihe
        {
            get
            {
                return _istAnDerReihe;
            }
            set
            {
                if (_istAnDerReihe == value) return;

                _istAnDerReihe = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
