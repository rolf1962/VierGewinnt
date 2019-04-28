using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    /// <summary>
    /// ToDo: Implementierung Video11, Position 12:50
    /// </summary>
    public class SpielbrettViewModelSampleData : ISpielbrettViewModel
    {
        public IReadOnlyList<Platz> Plätze
        {
            get { throw new NotImplementedException(); }
        }

        public IReadOnlyList<IKlickSpalteCommand> KlickSpalteCommands
        {
            get { throw new NotImplementedException(); }
        }
    }
}
