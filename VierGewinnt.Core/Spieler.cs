using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler : ISpieler
    {
        private readonly string _name;

        private readonly IList<Spielstein> _spielsteine;
        private readonly Farbe _spielerFarbe;

        public Spieler(string name, IList<Spielstein> spielsteine, Farbe spielerFarbe)
        {
            if (spielsteine == null) throw new ArgumentNullException(nameof(spielsteine));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

            _name = name;
            _spielsteine = spielsteine;
            _spielerFarbe = spielerFarbe;
        }

        public string Name
        {
            get { return _name; }
        }

        public IList<Spielstein> Spielsteine
        {
            get { return _spielsteine; }
        }

        public Farbe SpielerFarbe
        {
            get { return _spielerFarbe; }
        }

        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));

            var spielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);

            spalte.LasseSpielsteinFallen(spielstein);
        }
    }
}