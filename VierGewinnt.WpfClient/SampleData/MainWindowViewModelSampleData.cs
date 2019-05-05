using System;
using System.Collections.Generic;
using System.ComponentModel;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private readonly IReadOnlyList<ISpielerViewModel> _spielerViewModels;
        private readonly ISpielbrettViewModel _spielbrettViewModel;

        public MainWindowViewModelSampleData()
        {
            var spielerViewModels = new List<ISpielerViewModel>()
            {
                new SpielerViewModelSamplaData("Player A", new Farbe(128, 0, 0)) { IstAnDerReihe = true },
                new SpielerViewModelSamplaData("Player B", new Farbe(0, 0, 128)) { IstAnDerReihe = false }
            };
            _spielerViewModels = spielerViewModels;

            _spielbrettViewModel = new SpielbrettViewModelSampleData();
        }

        public ISpielbrettViewModel SpielbrettViewModel
        {
            get { return _spielbrettViewModel; }
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { return _spielerViewModels; }
        }

        public string Gewinnername
        {
            get { return _spielerViewModels[0].Spieler.Name; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SpieleZug(ISpalte spalte)
        {
            throw new NotImplementedException();
        }
    }
}
