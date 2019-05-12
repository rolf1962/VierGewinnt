using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    internal class SpielerMock : ISpieler
    {
        public string Name => throw new System.NotImplementedException();

        public IList<Spielstein> Spielsteine => throw new System.NotImplementedException();

        public Farbe SpielerFarbe => throw new System.NotImplementedException();

        public bool WurdeSpieleZugGenauEinmalAufgerufen { get; internal set; }
        public int AnzahlSpieleZugAufrufe { get; internal set; }

        public void SpieleZug(ISpalte spalte)
        {
            throw new System.NotImplementedException();
        }
    }
}