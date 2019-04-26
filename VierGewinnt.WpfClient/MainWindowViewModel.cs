using System;
using System.Collections.Generic;

namespace VierGewinnt.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<ISpielerViewModel> _spielerViewModels;

        public MainWindowViewModel(IReadOnlyList<ISpielerViewModel> spielerViewModels)
        {
            if (null == spielerViewModels)
            {
                throw new ArgumentNullException("Die Liste der Spieler-Viewmodels darf nicht null sein.", nameof(spielerViewModels));
            }

            _spielerViewModels = spielerViewModels;
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get
            {
                return _spielerViewModels;
            }
        }

        public ISpielbrettViewModel SpielbrettViewModel
        {
            get { return null; }
        }
    }
}
