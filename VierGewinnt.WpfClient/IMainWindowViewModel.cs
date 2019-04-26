using System.Collections.Generic;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel
    {
        ISpielbrettViewModel SpielbrettViewModel { get; }
        IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }
        string Gewinnername { get; }
    }
}
