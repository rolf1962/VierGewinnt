using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<ISpielerViewModel> _spielerViewModels;
        private readonly ISpielbrettViewModel _spielbrettViewModel;
        private readonly ISpielbrett _spielbrett;
        private string _gewinnername;

        public MainWindowViewModel(
            IReadOnlyList<ISpielerViewModel> spielerViewModels,
            ISpielbrettViewModel spielbrettViewModel,
            ISpielbrett spielbrett)
        {
            if (null == spielerViewModels) { throw new ArgumentNullException(nameof(spielerViewModels)); }
            if (null == spielbrettViewModel) { throw new ArgumentNullException(nameof(spielbrettViewModel)); }
            if (null == spielbrett) { throw new ArgumentNullException(nameof(spielbrett)); }

            _spielerViewModels = spielerViewModels;
            _spielbrettViewModel = spielbrettViewModel;
            _spielbrett = spielbrett;
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { return _spielerViewModels; }
        }

        public ISpielbrettViewModel SpielbrettViewModel
        {
            get { return _spielbrettViewModel; }
        }

        public string Gewinnername
        {
            get { return _gewinnername; }
            private set
            {
                if (_gewinnername == value) { return; }
                _gewinnername = value;
                OnPropertyChanged();

            }
        }

        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) { throw new ArgumentNullException(nameof(spalte)); }
            var aktuellerSpielerViewModel = _spielerViewModels.First(vm => vm.IstAnDerReihe);
            aktuellerSpielerViewModel.Spieler.SpieleZug(spalte);

            Gewinnername = _spielbrett.BestimmerGewinnername();
            if (Gewinnername != null)
            {
                return;
            }

            foreach (var spielerViewModel in _spielerViewModels)
            {
                spielerViewModel.IstAnDerReihe = !spielerViewModel.IstAnDerReihe;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

        }
    }
}
