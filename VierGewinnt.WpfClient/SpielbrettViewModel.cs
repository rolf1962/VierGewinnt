using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class SpielbrettViewModel : ISpielbrettViewModel
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
