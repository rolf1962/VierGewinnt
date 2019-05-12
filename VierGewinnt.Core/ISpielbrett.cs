using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public interface ISpielbrett
    {
        IReadOnlyList<IReadOnlyList<Platz>> Plätze { get; }
        IReadOnlyList<Reihe> Reihen { get; }
        IReadOnlyList<ISpalte> Spalten { get; }
        IReadOnlyList<Diagonale> Diagonalen { get; }
        string BestimmerGewinnername();
    }
}
