namespace VierGewinnt.Core.Tests
{
    internal class SpalteMock : ISpalte
    {
        private int _anzahlLasseSpielsteinFallenAufrufe;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }

        public bool WurdeLasseSpielsteinFallenGenauEinmalAufgerufen
        {
            get { return _anzahlLasseSpielsteinFallenAufrufe == 1; }
        }

        public bool IstSpalteVoll { get { throw new System.NotSupportedException(); } }
    }
}