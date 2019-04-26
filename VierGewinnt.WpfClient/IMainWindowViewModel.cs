using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel
    {
        ISpielbrettViewModel SpielbrettViewModel { get; }
        IReadOnlyList<ISpielerViewModel> SpielerViewModels { get; }
    }
}
