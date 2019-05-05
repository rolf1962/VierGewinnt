using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    internal class SpalteMock : ISpalte
    {
        public bool IstSpalteVoll { get; set; }

        public int Index => throw new System.NotImplementedException();

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            throw new System.NotImplementedException();
        }
    }
}