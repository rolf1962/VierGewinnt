using System.Collections.Generic;
using System.ComponentModel;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel : INotifyPropertyChanged
    {
        ISpielbrettViewModel SpielbrettViewModel { get; }
        IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }
        string Gewinnername { get; }

        void SpieleZug(ISpalte spalte);
    }
}
