using System;
using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private IReadOnlyList<ISpielerViewModel> _spielerViewModels;

        public MainWindowViewModelSampleData()
        {
            var spielerViewModels = new List<ISpielerViewModel>()
            {
                new SpielerViewModelSamplaData("Player A", new Farbe(128, 0, 0)) { IstAnDerReihe = true },
                new SpielerViewModelSamplaData("Player B", new Farbe(0, 0, 128)) { IstAnDerReihe = false }
            };
            _spielerViewModels = spielerViewModels;
        }

        public ISpielbrettViewModel SpielbrettViewModel
        {
            get { return null; }
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { return _spielerViewModels; }
        }

        public string Gewinnername
        {
            get { return _spielerViewModels[0].Spieler.Name; }
        }
    }
}
