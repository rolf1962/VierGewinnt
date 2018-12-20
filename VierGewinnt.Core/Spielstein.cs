namespace VierGewinnt.Core
{
    public class Spielstein
    {
        private readonly Farbe _farbe;
        private readonly string _spielername;

        public Spielstein(Farbe farbe, string spielerName)
        {
            if (farbe == null) throw new System.ArgumentNullException(nameof(farbe));
            if (spielerName== null) throw new System.ArgumentNullException(nameof(spielerName));

            _farbe = farbe;
            _spielername = spielerName;
        }

        public Farbe Farbe { get { return _farbe; } }

        public string Spielername { get { return _spielername; } }
    }
}