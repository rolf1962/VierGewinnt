using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public abstract class Linie
    {
        private readonly IReadOnlyList<Platz> _plätze;

        protected Linie(IReadOnlyList<Platz> plätze)
        {
            if (plätze == null) throw new ArgumentNullException(nameof(plätze));
            _plätze = plätze;
        }

        public IReadOnlyList<Platz> Plätze
        {
            get
            {
                return _plätze;
            }
        }

        public string ÜberprüfeObEinSpielerVierInEinerReiheHat()
        {
            var zähler = 0;
            string aktuellerSpielername = null;

            foreach (var platz in _plätze)
            {
                var spielstein = platz.Spielstein;

                if (spielstein == null)
                {
                    aktuellerSpielername = null;
                    zähler = 0;
                    continue;
                }

                if (aktuellerSpielername != spielstein.Spielername)
                {
                    zähler = 1;
                    aktuellerSpielername = spielstein.Spielername;
                    continue;
                }

                zähler++;

                if (zähler == 4)
                {
                    return aktuellerSpielername;
                }
            }

            return null;
        }
    }
}
