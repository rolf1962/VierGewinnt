using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class SpielerViewModelSamplaData : ISpielerViewModel
    {
        private readonly ISpieler _spieler;

        public SpielerViewModelSamplaData() : this("Player B", new Farbe(0, 0, 128))
        {
        }

        public SpielerViewModelSamplaData(string spielerName, Farbe spielerFarbe)
        {
            var spielsteine = new List<Spielstein>();

            for (int i = 0; i < 21; i++)
            {
                spielsteine.Add(new Spielstein(spielerFarbe, spielerName));
            }
            _spieler = new Spieler(spielerName, spielsteine, spielerFarbe);

            IstAnDerReihe = true;
        }

        public ISpieler Spieler
        {
            get
            {
                return _spieler;
            }
        }

        public bool IstAnDerReihe { get; set; }
    }
}
