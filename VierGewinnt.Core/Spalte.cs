using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Spalte : Linie, ISpalte
    {
        private readonly int _index;

        public Spalte(int index, IReadOnlyList<Platz> plätze) : base(plätze)
        {
            _index = index;
        }

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            foreach (var platz in Plätze)
            {
                if (platz.Spielstein == null)
                {
                    platz.Spielstein = spielstein;
                    return;
                }

                throw new InvalidOperationException("Die Spalte ist bereits voll");
            }
        }

        public bool IstSpalteVoll
        {
            get { return Plätze.All(platz => platz.Spielstein != null); }
        }

        public int Index
        {
            get
            {
                return _index;
            }
        }
    }
}