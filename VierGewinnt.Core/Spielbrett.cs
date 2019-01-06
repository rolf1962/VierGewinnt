using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {
        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plätze;
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<Spalte> _spalten;
        private readonly IReadOnlyList<Diagonale> _diagonalen;

        public Spielbrett(IReadOnlyList<IReadOnlyList<Platz>> plätze,
                          IReadOnlyList<Reihe> reihen,
                          IReadOnlyList<Spalte> spalten,
                          IReadOnlyList<Diagonale> diagonalen)
        {
            if (plätze == null) throw new ArgumentNullException(nameof(plätze));
            if (reihen == null) throw new ArgumentNullException(nameof(reihen));
            if (spalten == null) throw new ArgumentNullException(nameof(spalten));
            if (diagonalen == null) throw new ArgumentNullException(nameof(diagonalen));

            _plätze = plätze;
            _reihen = reihen;
            _spalten = spalten;
            _diagonalen = diagonalen;
        }

        public IReadOnlyList<IReadOnlyList<Platz>> Plätze
        {
            get
            {
                return _plätze;
            }
        }

        public IReadOnlyList<Reihe> Reihen
        {
            get
            {
                return _reihen;
            }
        }

        public IReadOnlyList<Spalte> Spalten
        {
            get
            {
                return _spalten;
            }
        }

        public IReadOnlyList<Diagonale> Diagonalen
        {
            get
            {
                return _diagonalen;
            }
        }
    }
}