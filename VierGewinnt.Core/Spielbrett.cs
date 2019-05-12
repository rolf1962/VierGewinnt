using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Spielbrett : ISpielbrett
    {
        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plätze;
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<Spalte> _spalten;
        private readonly IReadOnlyList<Diagonale> _diagonalen;

        private readonly IReadOnlyList<Linie> _spielbrettLinien;

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

            _spielbrettLinien = _reihen.Cast<Linie>()
                .Concat(spalten)
                .Concat(diagonalen)
                .ToList();
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

        public IReadOnlyList<ISpalte> Spalten
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

        public string BestimmerGewinnername()
        {
            foreach(var linie in _spielbrettLinien)
            {
                var gewinnername = linie.ÜberprüfeObEinSpielerVierInEinerReiheHat();
                if (gewinnername != null)
                {
                    return gewinnername;
                }
            }
            return null;
        }
    }
}