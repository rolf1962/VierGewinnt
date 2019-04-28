using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface ISpielbrettViewModel
    {
        IReadOnlyList<Platz> Plätze { get; }
        IReadOnlyList<IKlickSpalteCommand> KlickSpalteCommands { get; }
    }
}