using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler
    {
        private readonly string _name;
        private readonly IList<Spielstein> _spielsteine;

        public Spieler(string name, IList<Spielstein> spielsteine)
        {
            if (spielsteine == null) throw new ArgumentNullException(nameof(spielsteine));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

            _name = name;
            _spielsteine = spielsteine;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public IList<Spielstein> Spielsteine
        {
            get
            {
                return _spielsteine;
            }
        }

        public void SpieleZug(Spalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));

            var spielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);

            spalte.LasseSpielsteinFallen(spielstein);
        }
    }
}