using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public interface ISpieler
    {
        string Name { get; }
        IList<Spielstein> Spielsteine { get; }
        Farbe SpielerFarbe { get; }
        void SpieleZug(ISpalte spalte);
    }
}
