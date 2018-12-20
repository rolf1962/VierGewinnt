namespace VierGewinnt.Core
{
    public class Farbe
    {
        private readonly byte _rot;
        private readonly byte _grün;
        private readonly byte _blau;

        public Farbe(byte rot, byte grün, byte blau)
        {
            _rot = rot;
            _grün = grün;
            _blau = blau;
        }

        public byte Rot
        {
            get
            {
                return _rot;
            }
        }

        public byte Grün
        {
            get
            {
                return _grün;
            }
        }

        public byte Blau
        {
            get
            {
                return _blau;
            }
        }
    }
}