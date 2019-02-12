using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class SpielerViewModelSamplaData : ISpielerViewModel
    {
        private readonly Spieler _spieler;

        public SpielerViewModelSamplaData()
        {
            var spielerFarbe = new Farbe(0, 0, 255);
            const string spielerName = "Player B";
            var spielsteine = new List<Spielstein>();

            for (int i = 0; i < 21; i++)
            {
                spielsteine.Add(new Spielstein(spielerFarbe, spielerName));
            }
            _spieler = new Spieler(spielerName, spielsteine, spielerFarbe);

            IstAnDerReihe = true;
        }

        public Spieler Spieler
        {
            get
            {
                return _spieler;
            }
        }

        public bool IstAnDerReihe { get; set; }
    }
}
