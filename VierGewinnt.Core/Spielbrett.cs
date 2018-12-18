using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {
        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plätze;
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<Spalte> _spalte;
    }
}